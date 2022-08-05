#region license
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
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Sql.Pipeline
{
    public class SelectQueryExpressionExecutionPipeline<TDatabase> : 
        ISelectQueryExecutionPipeline<TDatabase>,
        ISelectSetQueryExecutionPipeline<TDatabase>
        where TDatabase : class, ISqlDatabaseRuntime
    {
        #region internals
        private readonly ISqlStatementExecutor<TDatabase> statementExecutor;
        private readonly IValueConverterFactory<TDatabase> valueConverterFactory;
        private readonly IMapperFactory<TDatabase> mapperFactory;
        private readonly IEntityFactory<TDatabase> entityFactory;
        private readonly ISqlStatementBuilder<TDatabase> statementBuilder;
        private readonly PipelineEventHooks<TDatabase> events;
        #endregion

        #region constructors
        public SelectQueryExpressionExecutionPipeline(
            ISqlStatementExecutor<TDatabase> statementExecutor,
            IValueConverterFactory<TDatabase> valueConverterFactory,
            IMapperFactory<TDatabase> mapperFactory,
            IEntityFactory<TDatabase> entityFactory,
            ISqlStatementBuilder<TDatabase> statementBuilder,
            PipelineEventHooks<TDatabase> events
        )
        {
            this.statementExecutor = statementExecutor ?? throw new ArgumentNullException(nameof(statementExecutor));
            this.valueConverterFactory = valueConverterFactory ?? throw new ArgumentNullException(nameof(valueConverterFactory));
            this.mapperFactory = mapperFactory ?? throw new ArgumentNullException(nameof(mapperFactory));
            this.entityFactory = entityFactory ?? throw new ArgumentNullException(nameof(entityFactory));
            this.statementBuilder = statementBuilder ?? throw new ArgumentNullException(nameof(statementBuilder));
            this.events = events ?? throw new ArgumentNullException(nameof(events));
        }
        #endregion

        #region methods
        #region entity
        public virtual TEntity? ExecuteSelectEntity<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            where TEntity : class, IDbEntity, new()
        {
            TEntity? entity = default;
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
                connection,
                configureCommand,
                reader =>
                {
                    var row = reader.ReadRow();
                    reader.Close();
                    if (row is null)
                        return;

                    entity = entityFactory.CreateEntity<TEntity>();
                    if (entity is null)
                        return;

                    var mapper = mapperFactory.CreateEntityMapper(table ?? throw new ArgumentNullException(nameof(table)));
                    mapper.Map(row, entity);
                }
            );
            return entity;
        }

        public virtual TEntity? ExecuteSelectEntity<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map)
           where TEntity : class, IDbEntity
        {
            TEntity? entity = default;
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        entity = map(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                }
            );
            return entity;
        }

        public virtual void ExecuteSelectEntity<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map)
           where TEntity : class, IDbEntity
        {
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        map(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                }
            );
        }

        public virtual TEntity? ExecuteSelectEntity<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map)
           where TEntity : class, IDbEntity, new()
        {
            TEntity? entity = default;
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        map(row, entity);
                    }
                    catch (Exception e)
                    {
                        if (e is DbExpressionException)
                            throw;
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                }
            );
            return entity;
        }

        public virtual async Task<TEntity?> ExecuteSelectEntityAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
        {
            TEntity? entity = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        var mapper = mapperFactory.CreateEntityMapper(table ?? throw new ArgumentNullException(nameof(table)));
                        mapper.Map(row, entity);
                    }
                    catch (Exception e)
                    {
                        if (e is DbExpressionException)
                            throw;
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return entity;
        }

        public virtual async Task ExecuteSelectEntityAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map, CancellationToken ct)
            where TEntity : class, IDbEntity
        {
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        map(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
        }

        public virtual async Task<TEntity?> ExecuteSelectEntityAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
        {
            TEntity? entity = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        entity = entityFactory.CreateEntity<TEntity>() 
                            ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        map(row, entity);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return entity;
        }

        public virtual async Task<TEntity?> ExecuteSelectEntityAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map, CancellationToken ct)
            where TEntity : class, IDbEntity
        {
            TEntity? entity = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        entity = map(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return entity;
        }

        public virtual async Task ExecuteSelectEntityAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> map, CancellationToken ct)
            where TEntity : class, IDbEntity
        {
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        await map(row).ConfigureAwait(false);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
        }

        public virtual async Task<TEntity?> ExecuteSelectEntityAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity, Task> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
        {
            TEntity? entity = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        await map(row, entity).ConfigureAwait(false);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return entity;
        }
        #endregion

        #region entity list
        public virtual IList<TEntity> ExecuteSelectEntityList<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityList<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand
            );

        public virtual IList<TEntity> ExecuteSelectEntityList<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityList<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
                connection,
                configureCommand
            );

        private IList<TEntity> ExecuteSelectEntityList<TEntity>(QueryExpression expression, Table<TEntity> from, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            where TEntity : class, IDbEntity, new()
        {
            var entities = new List<TEntity>();
            var mapper = mapperFactory.CreateEntityMapper(from ?? throw new ArgumentNullException(nameof(from))); 
            ExecuteSelectQuery(
                expression,
                converterProvider,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        var entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        mapper.Map(row, entity);
                        entities.Add(entity);
                    }
                    reader.Close();
                }
            );
            return entities;
        }

        public virtual IList<TEntity> ExecuteSelectEntityList<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityList<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select),
                connection,
                configureCommand,
                map
            );

        public virtual IList<TEntity> ExecuteSelectEntityList<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityList<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
                connection,
                configureCommand,
                map
            );

        private IList<TEntity> ExecuteSelectEntityList<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map)
            where TEntity : class, IDbEntity, new()
        {
            var entities = new List<TEntity>();
            var mapper = mapperFactory.CreateEntityMapper(table ?? throw new ArgumentNullException(nameof(table)));
            ExecuteSelectQuery(
                expression,
                converterProvider,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        try
                        {
                            var entity = map(row);
                            if (entity is not null)
                                entities.Add(entity);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                    }
                    reader.Close();
                }
            );
            return entities;
        }

        public virtual void ExecuteSelectEntityList<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map)
            where TEntity : class, IDbEntity
            => ExecuteSelectEntityList<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select),
                connection,
                configureCommand,
                map
            );

        public virtual void ExecuteSelectEntityList<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map)
            where TEntity : class, IDbEntity
            => ExecuteSelectEntityList<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
                connection,
                configureCommand,
                map
            );

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE0060 // Remove unused parameter
        private void ExecuteSelectEntityList<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map)
#pragma warning restore IDE0060 // Remove unused parameter
#pragma warning restore IDE0079 // Remove unnecessary suppression
            where TEntity : class, IDbEntity
        {
            ExecuteSelectQuery(
                expression,
                converterProvider,
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
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                    }
                    reader.Close();
                }
            );
        }

        public virtual IList<TEntity> ExecuteSelectEntityList<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityList<TEntity>(
                expression, 
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                map
            );

        public virtual IList<TEntity> ExecuteSelectEntityList<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityList<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                map
            );

#pragma warning disable IDE0060 // Remove unused parameter
        private IList<TEntity> ExecuteSelectEntityList<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map)
#pragma warning restore IDE0060 // Remove unused parameter
            where TEntity : class, IDbEntity, new()
        {
            var entities = new List<TEntity>();
            ExecuteSelectQuery(
                expression,
                converterProvider,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        var entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        try
                        {
                            map(row, entity);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                        entities.Add(entity);
                    }
                    reader.Close();
                }
            );
            return entities;
        }

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select),
                connection,
                configureCommand,
                ct
            );

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
                connection,
                configureCommand,
                ct
            );

        private async Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
        {
            var entities = new List<TEntity>();
            var mapper = mapperFactory.CreateEntityMapper(table ?? throw new ArgumentNullException(nameof(table)));
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        var entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        mapper.Map(row, entity);
                        entities.Add(entity);
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return entities;
        }

        public virtual Task ExecuteSelectEntityListAsync<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map, CancellationToken ct)
            where TEntity : class, IDbEntity
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select),
                connection,
                configureCommand,
                map,
                ct
            );

        public virtual Task ExecuteSelectEntityListAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map, CancellationToken ct)
            where TEntity : class, IDbEntity
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

#pragma warning disable IDE0060 // Remove unused parameter
        private async Task ExecuteSelectEntityListAsync<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> map, CancellationToken ct)
#pragma warning restore IDE0060 // Remove unused parameter
            where TEntity : class, IDbEntity
        {
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
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
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
        }

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

#pragma warning disable IDE0060 // Remove unused parameter
        private async Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader, TEntity> map, CancellationToken ct)
#pragma warning restore IDE0060 // Remove unused parameter
            where TEntity : class, IDbEntity, new()
        {
            var values = new List<TEntity>();
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        var entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        try
                        {
                            map(row, entity);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                        values.Add(entity);
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return values;
        }

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression,
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

        private async Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity?> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
        {
            var entities = new List<TEntity>();
            var mapper = mapperFactory.CreateEntityMapper(table ?? throw new ArgumentNullException(nameof(table)));
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            var entity = map(row);
                            if (entity is not null)
                                entities.Add(entity);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return entities;
        }

        public virtual Task ExecuteSelectEntityListAsync<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> map, CancellationToken ct)
            where TEntity : class, IDbEntity
            => ExecuteSelectEntityListAsync<TEntity>(
                expression, 
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );
        
        public virtual Task ExecuteSelectEntityListAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> map, CancellationToken ct)
            where TEntity : class, IDbEntity
            => ExecuteSelectEntityListAsync<TEntity>(expression, table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

#pragma warning disable IDE0060 // Remove unused parameter
        private async Task ExecuteSelectEntityListAsync<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> map, CancellationToken ct)
#pragma warning restore IDE0060 // Remove unused parameter
            where TEntity : class, IDbEntity
        {
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            await map(row).ConfigureAwait(false);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
        }

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectSetQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity, Task> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression, 
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

        public virtual Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(SelectQueryExpression expression, Table<TEntity> table, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity, Task> map, CancellationToken ct)
            where TEntity : class, IDbEntity, new()
            => ExecuteSelectEntityListAsync<TEntity>(
                expression, 
                table,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                map, 
                ct
            );

#pragma warning disable IDE0060 // Remove unused parameter
        private async Task<IList<TEntity>> ExecuteSelectEntityListAsync<TEntity>(QueryExpression expression, Table<TEntity> table, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, TEntity, Task> map, CancellationToken ct)
#pragma warning restore IDE0060 // Remove unused parameter
            where TEntity : class, IDbEntity, new()
        {
            var entities = new List<TEntity>();
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        var entity = entityFactory.CreateEntity<TEntity>() ?? throw new DbExpressionException($"Expected entity factory to provide an entity of type {typeof(TEntity)}.");
                        try
                        {
                            await map(row, entity).ConfigureAwait(false);
                            entities.Add(entity);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error mapping data reader to entity {typeof(TEntity)}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return entities;
        }
        #endregion

        #region value
        public virtual T? ExecuteSelectValue<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            T? value = default;
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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

        public virtual async Task<T?> ExecuteSelectValueAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            T? value = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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

        #endregion

        #region value list
        public virtual IList<T> ExecuteSelectValueList<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            => ExecuteSelectValueList<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand
            );

        public virtual IList<T> ExecuteSelectValueList<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            => ExecuteSelectValueList<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand
            );

        private IList<T> ExecuteSelectValueList<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            var values = new List<T>();
            ExecuteSelectQuery(
                expression,
                converterProvider,
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
                            values.Add(field.GetValue<T>());
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

        public virtual void ExecuteSelectValueList<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<T?> read)
            => ExecuteSelectValueList<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                read
            );

        public virtual void ExecuteSelectValueList<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<T?> read)
            => ExecuteSelectValueList<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                read
            );

        private void ExecuteSelectValueList<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<T?> read)
        {
            ExecuteSelectQuery(
                expression,
                converterProvider,
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

                        T? value = default;
                        try
                        {
                            value = field.GetValue<T>();
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error converting value to {typeof(T)}, actual type in reader is {field.DataType}.", e);
                        }
                        try
                        {
                            read(value);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException("Error occurred in the delegate managing the value", e);
                        }
                    }
                    reader.Close();
                }
            );
        }

        public virtual Task<IList<T>> ExecuteSelectValueListAsync<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            => ExecuteSelectValueListAsync<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                ct
            );

        public virtual Task<IList<T>> ExecuteSelectValueListAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            => ExecuteSelectValueListAsync<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                ct
            );

        private async Task<IList<T>> ExecuteSelectValueListAsync<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            var values = new List<T>();
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
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

        public virtual Task ExecuteSelectValueListAsync<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<T?> read, CancellationToken ct)
            => ExecuteSelectValueListAsync<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                read, 
                ct
            );

        public virtual Task ExecuteSelectValueListAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<T?> read, CancellationToken ct)
            => ExecuteSelectValueListAsync<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                read, 
                ct
            );
        
        private async Task ExecuteSelectValueListAsync<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<T?> read, CancellationToken ct)
        {
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
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

                        T? value = default;
                        try
                        {
                            value = field.GetValue<T>();
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error converting value to {typeof(T)}, actual type in reader is {field.DataType}.", e);
                        }

                        try
                        {
                            read(value);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException("Error occurred in the delegate managing the value", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
        }

        public virtual Task ExecuteSelectValueListAsync<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<T?, Task> read, CancellationToken ct)
            => ExecuteSelectValueListAsync<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), 
                connection, 
                configureCommand, 
                read, 
                ct
            );

        public virtual Task ExecuteSelectValueListAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<T?, Task> read, CancellationToken ct)
            => ExecuteSelectValueListAsync<T>(
                expression, 
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), 
                connection, 
                configureCommand, 
                read, 
                ct
            );
        
        private async Task ExecuteSelectValueListAsync<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<T?, Task> read, CancellationToken ct)
        {
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
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

                        T? value = default;
                        try
                        {
                            value = field.GetValue<T>();
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error converting value to {typeof(T)}, actual type in reader is {field.DataType}.", e);
                        }

                        try
                        {
                            await read(value).ConfigureAwait(false);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException("Error occurred in the delegate managing the value", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
        }
        #endregion

        #region dynamic
        public virtual dynamic? ExecuteSelectDynamic(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            dynamic? value = default;
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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

        public virtual void ExecuteSelectDynamic(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read)
        {
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        read(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException("Error occurred in the delegate managing the field reader.", e);
                    }
                }
            );
        }

        public virtual async Task<dynamic?> ExecuteSelectDynamicAsync(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            dynamic? value = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
                connection,
                configureCommand,
                async reader =>
                {
                    var row = await reader.ReadRowAsync().ConfigureAwait(false);
                    if (row is null)
                        return;
                    
                    reader.Close();

                    value = new ExpandoObject();
                    var mapper = mapperFactory.CreateExpandoObjectMapper();
                    mapper.Map(value, row);
                },
                ct
            ).ConfigureAwait(false);
            return value;
        }

        public virtual async Task ExecuteSelectDynamicAsync(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read, CancellationToken ct)
        {
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        read(row);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException("Error occurred in the delegate managing the field reader.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
        }

        public virtual async Task ExecuteSelectDynamicAsync(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> read, CancellationToken ct)
        {
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        await read(row).ConfigureAwait(false);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException("Error occurred in the delegate managing the field reader.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
        }
        #endregion

        #region dynamic list
        public virtual IList<dynamic> ExecuteSelectDynamicList(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            => ExecuteSelectDynamicList(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand);

        public virtual IList<dynamic> ExecuteSelectDynamicList(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand)
            => ExecuteSelectDynamicList(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand);

        private IList<dynamic> ExecuteSelectDynamicList(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand)
        {
            var values = new List<dynamic>();
            var mapper = mapperFactory.CreateExpandoObjectMapper();
            ExecuteSelectQuery(
                expression,
                converterProvider,
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

        public virtual void ExecuteSelectDynamicList(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read)
            => ExecuteSelectDynamicList(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand, read);

        public virtual void ExecuteSelectDynamicList(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read)
            => ExecuteSelectDynamicList(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand, read);

        private void ExecuteSelectDynamicList(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read)
        {
            ExecuteSelectQuery(
                expression,
                converterProvider,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        try
                        {
                            read(row);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException("Error occurred in the delegate managing the field reader.", e);
                        }
                    }
                    reader.Close();
                }
            );
        }

        public virtual Task<IList<dynamic>> ExecuteSelectDynamicListAsync(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            => ExecuteSelectDynamicListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand, ct);

        public virtual Task<IList<dynamic>> ExecuteSelectDynamicListAsync(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
            => ExecuteSelectDynamicListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand, ct);

        private async Task<IList<dynamic>> ExecuteSelectDynamicListAsync(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, CancellationToken ct)
        {
            var values = new List<dynamic>();
            var mapper = mapperFactory.CreateExpandoObjectMapper();
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
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

        public virtual Task ExecuteSelectDynamicListAsync(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read, CancellationToken ct)
            => ExecuteSelectDynamicListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand, read, ct);

        public virtual Task ExecuteSelectDynamicListAsync(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read, CancellationToken ct)
            => ExecuteSelectDynamicListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand, read, ct);
        
        private async Task ExecuteSelectDynamicListAsync(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Action<ISqlFieldReader> read, CancellationToken ct)
        {
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            read(row);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException("Error occurred in the delegate managing the field reader.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
        }

        public virtual Task ExecuteSelectDynamicListAsync(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> read, CancellationToken ct)
            => ExecuteSelectDynamicListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand, read, ct);
        
        public virtual Task ExecuteSelectDynamicListAsync(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> read, CancellationToken ct)
            => ExecuteSelectDynamicListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand, read, ct);

        private async Task ExecuteSelectDynamicListAsync(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task> read, CancellationToken ct)
        {
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            await read(row).ConfigureAwait(false);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException("Error occurred in the delegate managing the field reader.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
        }

        #endregion

        #region object
        public virtual T? ExecuteSelectObject<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map)
        {
            T? value = default;
            ExecuteSelectQuery(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        throw new DbExpressionException($"Error occurred in the delegate mapping the field reader to a {typeof(T)}.", e);
                    }
                }
            );
            return value;
        }

        public virtual async Task<T?> ExecuteSelectObjectAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map, CancellationToken ct)
        {
            T? value = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        throw new DbExpressionException($"Error occurred in the delegate mapping the field reader to a {typeof(T)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return value;
        }

        public virtual async Task<T?> ExecuteSelectObjectAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task<T?>> map, CancellationToken ct)
        {
            T? value = default;
            await ExecuteSelectQueryAsync(
                expression,
                new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select),
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
                        value = await map(row).ConfigureAwait(false);
                    }
                    catch (Exception e)
                    {
                        throw new DbExpressionException($"Error occurred in the delegate mapping the field reader to a {typeof(T)}.", e);
                    }
                },
                ct
            ).ConfigureAwait(false);
            return value;
        }
        #endregion

        #region object list
        public virtual IList<T> ExecuteSelectObjectList<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map)
            => ExecuteSelectObjectList(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand, map);

        public virtual IList<T> ExecuteSelectObjectList<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map)
            => ExecuteSelectObjectList(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand, map);

        private IList<T> ExecuteSelectObjectList<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map)
        {
            var values = new List<T>();
            ExecuteSelectQuery(
                expression,
                converterProvider,
                connection,
                configureCommand,
                reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = reader.ReadRow()) is not null)
                    {
                        try
                        {
                            var value = map(row);
                            if (value is not null)
                                values.Add(value);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error occurred in the delegate mapping the field reader to a {typeof(T)}.", e);
                        }
                    }
                    reader.Close();
                }
            );
            return values;
        }

        public virtual Task<IList<T>> ExecuteSelectObjectListAsync<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map, CancellationToken ct)
            => ExecuteSelectObjectListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand, map, ct);
        
        public virtual Task<IList<T>> ExecuteSelectObjectListAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map, CancellationToken ct)
             => ExecuteSelectObjectListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand, map, ct);
        
        private async Task<IList<T>> ExecuteSelectObjectListAsync<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, T?> map, CancellationToken ct)
        {
            var values = new List<T>();
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            var value = map(row);
                            if (value is not null)
                                values.Add(value);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error occurred in the delegate mapping the field reader to a {typeof(T)}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return values;
        }

        public virtual Task<IList<T>> ExecuteSelectObjectListAsync<T>(SelectSetQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task<T?>> map, CancellationToken ct)
            => ExecuteSelectObjectListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Expressions.First().SelectQueryExpression.Select), connection, configureCommand, map, ct);
        
        public virtual Task<IList<T>> ExecuteSelectObjectListAsync<T>(SelectQueryExpression expression, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task<T?>> map, CancellationToken ct)
            => ExecuteSelectObjectListAsync(expression, new SqlStatementValueConverterProvider(valueConverterFactory, expression.Select), connection, configureCommand, map, ct);

        private async Task<IList<T>> ExecuteSelectObjectListAsync<T>(QueryExpression expression, IValueConverterProvider converterProvider, ISqlConnection connection, Action<IDbCommand>? configureCommand, Func<ISqlFieldReader, Task<T?>> map, CancellationToken ct)
        {
            var values = new List<T>();
            await ExecuteSelectQueryAsync(
                expression,
                converterProvider,
                connection,
                configureCommand,
                async reader =>
                {
                    ISqlFieldReader? row;
                    while ((row = await reader.ReadRowAsync().ConfigureAwait(false)) is not null)
                    {
                        try
                        {
                            var value = await map(row).ConfigureAwait(false);
                            if (value is not null)
                                values.Add(value);
                        }
                        catch (Exception e)
                        {
                            throw new DbExpressionException($"Error occurred in the delegate mapping the field reader to a {typeof(T)}.", e);
                        }
                    }
                    reader.Close();
                },
                ct
            ).ConfigureAwait(false);
            return values;
        }
        #endregion

        private void ExecuteSelectQuery(
            QueryExpression expression,
            IValueConverterProvider valueConverterProvider,
            ISqlConnection connection,
            Action<IDbCommand>? configureCommand,
            Action<ISqlRowReader> transform
        )
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            events.BeforeAssembly?.Invoke(new Lazy<BeforeAssemblyPipelineExecutionContext>(() => new BeforeAssemblyPipelineExecutionContext(expression, statementBuilder.Parameters)));
            var statement = statementBuilder.CreateSqlStatement(expression) ?? throw new DbExpressionException("The sql statement builder returned a null value, cannot execute a select query without a sql statement.");
            events.AfterAssembly?.Invoke(new Lazy<AfterAssemblyPipelineExecutionContext>(() => new AfterAssemblyPipelineExecutionContext(expression, statementBuilder.Parameters, statement)));

            events.BeforeSelect?.Invoke(new Lazy<BeforeSelectPipelineExecutionContext>(() => new BeforeSelectPipelineExecutionContext(expression, statement, statementBuilder.Parameters)));

            var reader = statementExecutor.ExecuteQuery(
                statement, 
                connection,
                valueConverterProvider,
                cmd => {
                    events.BeforeExecution?.Invoke(new Lazy<BeforeExecutionPipelineExecutionContext>(() => new BeforeExecutionPipelineExecutionContext(expression, cmd, statement))); 
                    configureCommand?.Invoke(cmd); 
                },
                cmd => events.AfterExecution?.Invoke(new Lazy<AfterExecutionPipelineExecutionContext>(() => new AfterExecutionPipelineExecutionContext(expression, cmd)))
            );

            if (reader is null)
                return;

            transform(reader);

            events.AfterSelect?.Invoke(new Lazy<AfterSelectPipelineExecutionContext>(() => new AfterSelectPipelineExecutionContext(expression)));
        }

        private async Task ExecuteSelectQueryAsync(
            QueryExpression expression,
            IValueConverterProvider valueConverterProvider,
            ISqlConnection connection,
            Action<IDbCommand>? configureCommand,
            Func<IAsyncSqlRowReader, Task> transform,
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

            var statement = statementBuilder.CreateSqlStatement(expression) ?? throw new DbExpressionException("The sql statement builder returned a null value, cannot execute a select query without a sql statement.");
            if (events.AfterAssembly is not null)
            {
                await events.AfterAssembly.InvokeAsync(new Lazy<AfterAssemblyPipelineExecutionContext>(() => new AfterAssemblyPipelineExecutionContext(expression, statementBuilder.Parameters, statement)), ct).ConfigureAwait(false);
                ct.ThrowIfCancellationRequested();
            }

            if (events.BeforeSelect is not null)
            {
                await events.BeforeSelect.InvokeAsync(new Lazy<BeforeSelectPipelineExecutionContext>(() => new BeforeSelectPipelineExecutionContext(expression, statement, statementBuilder.Parameters)), ct).ConfigureAwait(false);
                ct.ThrowIfCancellationRequested();
            }

            var reader = await statementExecutor.ExecuteQueryAsync(
                statement,
                connection,
                valueConverterProvider,
                async cmd =>
                {
                    if (events.BeforeExecution is not null)
                    {
                        await events.BeforeExecution.InvokeAsync(new Lazy<BeforeExecutionPipelineExecutionContext>(() => new BeforeExecutionPipelineExecutionContext(expression, cmd, statement)), ct).ConfigureAwait(false);
                    }
                    configureCommand?.Invoke(cmd);
                },
                async cmd =>
                {
                    if (events.AfterExecution is not null)
                    {
                        await events.AfterExecution.InvokeAsync(new Lazy<AfterExecutionPipelineExecutionContext>(() => new AfterExecutionPipelineExecutionContext(expression, cmd)), ct).ConfigureAwait(false);
                    }
                },
                ct
            ).ConfigureAwait(false);

            ct.ThrowIfCancellationRequested();

            if (reader is null)
                return;

            await transform(reader).ConfigureAwait(false);

            if (events.AfterSelect is not null)
            {
                await events.AfterSelect.InvokeAsync(new Lazy<AfterSelectPipelineExecutionContext>(() => new AfterSelectPipelineExecutionContext(expression)), ct).ConfigureAwait(false);
                ct.ThrowIfCancellationRequested();
            }
        }
    }
    #endregion
}