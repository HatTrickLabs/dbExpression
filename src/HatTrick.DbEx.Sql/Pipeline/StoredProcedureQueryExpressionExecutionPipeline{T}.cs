﻿#region license
// Copyright (c) HatTrick Labs, LLC.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/HatTrickLabs/db-ex
#endregion

using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Connection;
using HatTrick.DbEx.Sql.Converter;
using HatTrick.DbEx.Sql.Executor;
using HatTrick.DbEx.Sql.Expression;
using HatTrick.DbEx.Sql.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Sql.Pipeline
{
    public class StoredProcedureQueryExpressionExecutionPipeline<TDatabase> : IStoredProcedureExecutionPipeline<TDatabase>
        where TDatabase : class, ISqlDatabaseRuntime
    {
        #region internals
        private readonly ISqlStatementExecutor<TDatabase> statementExecutor;
        private readonly IValueConverterFactory<TDatabase> valueConverterFactory;
        private readonly IMapperFactory<TDatabase> mapperFactory;
        private readonly ISqlStatementBuilder<TDatabase> statementBuilder;
        private readonly PipelineEventHooks<TDatabase> events;
        #endregion

        #region constructors
        public StoredProcedureQueryExpressionExecutionPipeline(
            ISqlStatementExecutor<TDatabase> statementExecutor,
            IValueConverterFactory<TDatabase> valueConverterFactory,
            IMapperFactory<TDatabase> mapperFactory,
            ISqlStatementBuilder<TDatabase> statementBuilder,
            PipelineEventHooks<TDatabase> events
        )
        {
            this.statementExecutor = statementExecutor ?? throw new ArgumentNullException(nameof(statementExecutor));
            this.valueConverterFactory = valueConverterFactory ?? throw new ArgumentNullException(nameof(valueConverterFactory));
            this.mapperFactory = mapperFactory ?? throw new ArgumentNullException(nameof(mapperFactory));
            this.statementBuilder = statementBuilder ?? throw new ArgumentNullException(nameof(statementBuilder));
            this.events = events ?? throw new ArgumentNullException(nameof(events));
        }
        #endregion

        #region methods
        public virtual void Execute(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                null
            );
        }

        public virtual void Execute(StoredProcedureQueryExpression expression, Action<ISqlFieldReader> map, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        try
                        {
                            map(row);
                        }
                        catch (Exception e)
                        {
                            reader.Close();
                            throw new DbExpressionException("Error in delegate managing the field reader.", e);
                        }
                    }
                    reader.Close();
                }
            );
        }

        public virtual Task ExecuteAsync(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            return ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                null,
                ct
            );
        }

        public virtual async Task ExecuteAsync(StoredProcedureQueryExpression expression, Action<ISqlFieldReader> map, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            await ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            map(row);
                        }
                        catch (Exception e)
                        {
                            reader.Close();
                            throw new DbExpressionException("Error in delegate managing the field reader.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
        }
        
        public virtual dynamic? ExecuteSelectDynamic(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            dynamic? value = default;
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                reader =>
                {
                    var row = reader.ReadRow();
                    reader.Close();
                    if (row is null)
                        return;

                    value = new ExpandoObject();
                    var mapper = mapperFactory.CreateExpandoObjectMapper();
                    mapper.Map(value, row);
                }
            );
            return value;
        }

        public virtual async Task<dynamic?> ExecuteSelectDynamicAsync(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            dynamic? value = default;
            await ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                async reader =>
                {
                    var row = await reader.ReadRowAsync().ConfigureAwait(false);
                    reader.Close();
                    if (row is null)
                        return;

                    value = new ExpandoObject();
                    var mapper = mapperFactory.CreateExpandoObjectMapper();
                    mapper.Map(value, row);
                },
                ct
            ).ConfigureAwait(false);
            return value;
        }

        public virtual IList<dynamic> ExecuteSelectDynamicList(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            var values = new List<dynamic>();
            var mapper = mapperFactory.CreateExpandoObjectMapper();
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        var value = new ExpandoObject();
                        mapper.Map(value, row);
                        values.Add(value);
                    }
                    reader.Close();
                }
            );
            return values;
        }

        public virtual async Task<IList<dynamic>> ExecuteSelectDynamicListAsync(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            var values = new List<dynamic>();
            var mapper = mapperFactory.CreateExpandoObjectMapper();
            await ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        var value = new ExpandoObject();
                        mapper.Map(value, row);
                        values.Add(value);
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return values;
        }

        public virtual T? ExecuteSelectValue<T>(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            T? value = default;
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                reader =>
                {
                    var field = reader.ReadRow()?.ReadField();
                    reader.Close();
                    if (field is null)
                        return;

                    try
                    {
                        value = field.GetValue<T>();
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error converting value to {typeof(T)}, actual type in reader is {field.DataType}.", e);
                    }
                }
            );
            return value;
        }

        public virtual async Task<T?> ExecuteSelectValueAsync<T>(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            T? value = default;
            await ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                async reader =>
                {
                    var row = await reader.ReadRowAsync().ConfigureAwait(false);
                    reader.Close();
                    if (row is null)
                        return;

                    var field = row.ReadField();
                    if (field is null)
                        return;

                    try
                    {
                        value = field.GetValue<T>();
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error converting value to {typeof(T)}, actual type in reader is {field.DataType}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return value;
        }

        public virtual IList<T> ExecuteSelectValueList<T>(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            var values = new List<T>();
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        var field = row.ReadField();
                        if (field is null)
                            return;

                        try
                        {
                            values.Add(field.GetValue<T>()!);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error converting value to {typeof(T)}, actual type in reader is {field.DataType}.", e);
                        }
                    }
                    reader.Close();
                }
            );
            return values;
        }

        public virtual async Task<IList<T>> ExecuteSelectValueListAsync<T>(StoredProcedureQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            var values = new List<T>();
            await ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        var field = row.ReadField();
                        if (field is null)
                            return;

                        try
                        {
                            values.Add(field.GetValue<T>()!);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error converting value to {typeof(T)}, actual type in reader is {field.DataType}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return values;
        }

        public virtual T? ExecuteSelectObject<T>(StoredProcedureQueryExpression expression, Func<ISqlFieldReader, T> map, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            T? value = default;
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                reader =>
                {
                    var row = reader.ReadRow();
                    reader.Close();
                    if (row is null)
                        return;

                    try
                    {
                        value = map(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error converting values to {typeof(T)}.", e);
                    }
                }
            );
            return value;
        }

        public virtual async Task<T?> ExecuteSelectObjectAsync<T>(StoredProcedureQueryExpression expression, Func<ISqlFieldReader, T> map, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            T? value = default;
            await ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                async reader =>
                {
                    var row = await reader.ReadRowAsync().ConfigureAwait(false);
                    reader.Close();
                    if (row is null)
                        return;

                    try
                    {
                        value = map(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error converting values to {typeof(T)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return value;
        }

        public virtual IList<T> ExecuteSelectObjectList<T>(StoredProcedureQueryExpression expression, Func<ISqlFieldReader, T> map, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            var values = new List<T>();
            ExecuteStoredProcedure(
                expression,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        try
                        {
                            values.Add(map(row));
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to {typeof(T)}.", e);
                        }
                    }
                    reader.Close();
                }
            );
            return values;
        }

        public virtual async Task<IList<T>> ExecuteSelectObjectListAsync<T>(StoredProcedureQueryExpression expression, Func<ISqlFieldReader, T> map, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            var values = new List<T>();
            await ExecuteStoredProcedureAsync(
                expression,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            values.Add(map(row));
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to {typeof(T)}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return values;
        }
        #endregion

        private void ExecuteStoredProcedure(
            StoredProcedureQueryExpression expression,
            ISqlConnection connection,
            Action<IDbCommand>? configureCommand,
            Action<ISqlRowReader>? transform
        )
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            events.BeforeAssembly?.Invoke(new Lazy<BeforeAssemblyPipelineExecutionContext>(() => new BeforeAssemblyPipelineExecutionContext(expression, statementBuilder.Parameters)));
            var statement = statementBuilder.CreateSqlStatement(expression) ?? throw new DbExpressionException("The sql statement builder returned a null value, cannot execute a stored procedure without a sql statement.");
            events.AfterAssembly?.Invoke(new Lazy<AfterAssemblyPipelineExecutionContext>(() => new AfterAssemblyPipelineExecutionContext(expression, statementBuilder.Parameters, statement)));

            events.BeforeStoredProcedure?.Invoke(new Lazy<BeforeStoredProcedurePipelineExecutionContext>(() => new BeforeStoredProcedurePipelineExecutionContext(expression, statement, statementBuilder.Parameters)));

            var converters = new SqlStatementValueConverterProvider(valueConverterFactory);

            if (transform is not null)
            {
                IDbCommand? command = default;
                var reader = statementExecutor.ExecuteQuery(
                    statement,
                    connection,
                    converters,
                    cmd =>
                    {
                        command = cmd;
                        cmd.CommandType = CommandType.StoredProcedure;
                        events.BeforeExecution?.Invoke(new Lazy<BeforeExecutionPipelineExecutionContext>(() => new BeforeExecutionPipelineExecutionContext(expression, cmd, statement)));
                        configureCommand?.Invoke(cmd);
                    },
                    null
                );

                if (reader is not null)
                    transform(reader);

                MapOutputParameters(expression, command!.Parameters, statement.Parameters, valueConverterFactory);
                events.AfterExecution?.Invoke(new Lazy<AfterExecutionPipelineExecutionContext>(() => new AfterExecutionPipelineExecutionContext(expression, command)));
            }
            else
            {
                statementExecutor.ExecuteNonQuery(
                    statement,
                    connection,
                    cmd =>
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        events.BeforeExecution?.Invoke(new Lazy<BeforeExecutionPipelineExecutionContext>(() => new BeforeExecutionPipelineExecutionContext(expression, cmd, statement)));
                        configureCommand?.Invoke(cmd);
                    },
                    cmd =>
                    {
                        MapOutputParameters(expression, cmd.Parameters, statement.Parameters, valueConverterFactory);
                        events.AfterExecution?.Invoke(new Lazy<AfterExecutionPipelineExecutionContext>(() => new AfterExecutionPipelineExecutionContext(expression, cmd)));
                    }
                );
            }

            events.AfterStoredProcedure?.Invoke(new Lazy<AfterStoredProcedurePipelineExecutionContext>(() => new AfterStoredProcedurePipelineExecutionContext(expression)));
        }

        private async Task ExecuteStoredProcedureAsync(
            StoredProcedureQueryExpression expression,
            ISqlConnection connection,
            Action<IDbCommand>? configureCommand,
            Func<IAsyncSqlRowReader, Task>? transform,
            CancellationToken ct
        )
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            if (events.BeforeAssembly is not null)
            {
                await events.BeforeAssembly.InvokeAsync(new Lazy<BeforeAssemblyPipelineExecutionContext>(() => new BeforeAssemblyPipelineExecutionContext(expression, statementBuilder.Parameters)), ct).ConfigureAwait(false);
                ct.ThrowIfCancellationRequested();
            }

            var statement = statementBuilder.CreateSqlStatement(expression) ?? throw new DbExpressionException("The sql statement builder returned a null value, cannot execute a stored procedure without a sql statement.");
            if (events.AfterAssembly is not null)
            {
                await events.AfterAssembly.InvokeAsync(new Lazy<AfterAssemblyPipelineExecutionContext>(() => new AfterAssemblyPipelineExecutionContext(expression, statementBuilder.Parameters, statement)), ct).ConfigureAwait(false);
                ct.ThrowIfCancellationRequested();
            }

            if (events.BeforeStoredProcedure is not null)
            {
                await events.BeforeStoredProcedure.InvokeAsync(new Lazy<BeforeStoredProcedurePipelineExecutionContext>(() => new BeforeStoredProcedurePipelineExecutionContext(expression, statement, statementBuilder.Parameters)), ct).ConfigureAwait(false);
                ct.ThrowIfCancellationRequested();
            }

            var converters = new SqlStatementValueConverterProvider(valueConverterFactory);

            if (transform is not null)
            {
                IDbCommand? command = default;
                var reader = await statementExecutor.ExecuteQueryAsync(
                    statement,
                    connection,
                    converters,
                    async cmd =>
                    {
                        command = cmd;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (events.BeforeExecution is not null)
                        {
                            await events.BeforeExecution.InvokeAsync(new Lazy<BeforeExecutionPipelineExecutionContext>(() => new BeforeExecutionPipelineExecutionContext(expression, cmd, statement)), ct).ConfigureAwait(false);
                        }
                        configureCommand?.Invoke(cmd);
                    },
                    null,
                    ct
                ).ConfigureAwait(false);

                ct.ThrowIfCancellationRequested();

                if (reader is not null)
                    await transform(reader).ConfigureAwait(false);

                MapOutputParameters(expression, command!.Parameters, statement.Parameters, valueConverterFactory);
                if (events.AfterExecution is not null)
                {
                    await events.AfterExecution.InvokeAsync(new Lazy<AfterExecutionPipelineExecutionContext>(() => new AfterExecutionPipelineExecutionContext(expression, command)), ct).ConfigureAwait(false);
                }
            }
            else
            {
                await statementExecutor.ExecuteNonQueryAsync(
                    statement,
                    connection,
                    cmd =>
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        events.BeforeExecution?.Invoke(new Lazy<BeforeExecutionPipelineExecutionContext>(() => new BeforeExecutionPipelineExecutionContext(expression, cmd, statement)));
                        configureCommand?.Invoke(cmd);
                    },
                    cmd =>
                    {
                        MapOutputParameters(expression, cmd.Parameters, statement.Parameters, valueConverterFactory);
                        events.AfterExecution?.Invoke(new Lazy<AfterExecutionPipelineExecutionContext>(() => new AfterExecutionPipelineExecutionContext(expression, cmd)));
                    },
                    ct
                ).ConfigureAwait(false);
            }

            if (events.AfterStoredProcedure is not null)
            {
                await events.AfterStoredProcedure.InvokeAsync(new Lazy<AfterStoredProcedurePipelineExecutionContext>(() => new AfterStoredProcedurePipelineExecutionContext(expression)), ct).ConfigureAwait(false);
                ct.ThrowIfCancellationRequested();
            }
        }

        private static void MapOutputParameters(StoredProcedureQueryExpression expression, IDataParameterCollection executedParameters, IList<ParameterizedExpression> statementParameters, IValueConverterFactory valueConverterFactory)
        {
            IValueConverter finder(ISqlOutputParameter p, Type t)
            {
                if (p.RawValue is DBNull && !t.IsNullableType() && t.IsConvertibleToNullableType())
                    return valueConverterFactory.CreateConverter(typeof(Nullable<>).MakeGenericType(t));

                return valueConverterFactory.CreateConverter(t);
            }

            var map = (expression.BaseEntity as IOutputParameterMappingDelegateProvider)?.MapDelegate;

            //map not provided or there are no output parameters, nothing to do
            if (map is null || !statementParameters.Any(p => p.Parameter.Direction != ParameterDirection.Input))
                return;

            var provider = new SqlStatementValueConverterProvider(valueConverterFactory, statementParameters.Where(p => p.Parameter.Direction != ParameterDirection.Input));
            var values = new SqlOutputParameterList();

            var index = 0;
            var enumerator = executedParameters.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current is not DbParameter parameter)
                    continue;

                if (parameter.Direction == ParameterDirection.Input)
                    continue;

                var statementParameter = statementParameters.Single(x => x.Parameter.ParameterName == parameter.ParameterName);

                var outputParameter = new OutputParameter(index, parameter.ParameterName, statementParameter.DeclaredType, parameter.Value, finder);

                values.Add(outputParameter);

                index++;
            }

            map(values);
        }
    }
}