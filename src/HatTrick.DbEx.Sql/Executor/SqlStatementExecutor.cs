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

using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Connection;
using HatTrick.DbEx.Sql.Expression;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Sql.Executor
{
    public class SqlStatementExecutor : ISqlStatementExecutor
    {
        private readonly ILogger<SqlStatementExecutor> logger;
        private readonly LoggingOptions loggingOptions;

        public SqlStatementExecutor(ILogger<SqlStatementExecutor> logger, LoggingOptions loggingOptions)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.loggingOptions = loggingOptions ?? throw new ArgumentNullException(nameof(loggingOptions));
        }

        public virtual int ExecuteNonQuery(SqlStatement statement, ISqlConnection connection, Action<IDbCommand>? beforeExecution, Action<IDbCommand>? afterExecution)
        {
            int @return = 0;

            if (statement is null)
                throw new ArgumentNullException(nameof(statement));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            using IDbCommand cmd = connection.CreateCommand();
            cmd.Connection = connection.DbConnection;
            cmd.Transaction = connection.IsTransactional ? connection.DbTransaction : null;
            cmd.CommandType = CommandType.Text;
            foreach (var parameter in statement.Parameters.Select(x => x.Parameter))
                cmd.Parameters.Add(parameter);

            beforeExecution?.Invoke(cmd);

            if (string.IsNullOrWhiteSpace(cmd.CommandText))
                cmd.CommandText = statement.CommandTextWriter.ToString();

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Executing query:\r\n{query}\r\n{parameters}", cmd.CommandText, ConvertParametersForLogging(statement.Parameters));
            connection.EnsureOpen();
            @return = cmd.ExecuteNonQuery();
            afterExecution?.Invoke(cmd);

            return @return;
        }

        public virtual async Task<int> ExecuteNonQueryAsync(SqlStatement statement, ISqlConnection connection, Action<IDbCommand>? beforeExecution, Action<IDbCommand>? afterExecution, CancellationToken ct)
        {
            int @return = 0;

            if (statement is null)
                throw new ArgumentNullException(nameof(statement));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            using IDbCommand cmd = connection.CreateCommand();
            cmd.Connection = connection.DbConnection;
            cmd.Transaction = connection.IsTransactional ? connection.DbTransaction : null;
            cmd.CommandText = statement.CommandTextWriter.ToString();
            cmd.CommandType = CommandType.Text;
            foreach (var parameter in statement.Parameters.Select(x => x.Parameter))
                cmd.Parameters.Add(parameter);

            beforeExecution?.Invoke(cmd);
            ct.ThrowIfCancellationRequested();

            if (string.IsNullOrWhiteSpace(cmd.CommandText))
                cmd.CommandText = statement.CommandTextWriter.ToString();

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Executing query:\r\n{query}\r\n{parameters}", cmd.CommandText, ConvertParametersForLogging(statement.Parameters));
            await connection.EnsureOpenAsync(ct).ConfigureAwait(false);
            @return = cmd is DbCommand dbCommand ? await dbCommand.ExecuteNonQueryAsync(ct).ConfigureAwait(false) : throw new DbExpressionException($"Async query execution requires a command of type {typeof(DbCommand)}, but a command of type {cmd.GetType()} was provided.");

            afterExecution?.Invoke(cmd);
            ct.ThrowIfCancellationRequested();
            return @return;
        }

        public virtual ISqlRowReader ExecuteQuery(SqlStatement statement, ISqlConnection connection, IValueConverterProvider finder, Action<IDbCommand>? beforeExecution, Action<IDbCommand>? afterExecution)
        {
            if (statement is null)
                throw new ArgumentNullException(nameof(statement));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            if (finder is null)
                throw new ArgumentNullException(nameof(finder));

            using IDbCommand cmd = connection.CreateCommand();
            cmd.Connection = connection.DbConnection;
            cmd.Transaction = connection.IsTransactional ? connection.DbTransaction : null;
            cmd.CommandType = CommandType.Text;
            foreach (var parameter in statement.Parameters.Select(x => x.Parameter))
                cmd.Parameters.Add(parameter);

            beforeExecution?.Invoke(cmd);

            if (string.IsNullOrWhiteSpace(cmd.CommandText))
                cmd.CommandText = statement.CommandTextWriter.ToString();

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Executing query:\r\n{query}\r\n{parameters}", cmd.CommandText, ConvertParametersForLogging(statement.Parameters));
            connection.EnsureOpen();
            var reader = cmd.ExecuteReader();
            afterExecution?.Invoke(cmd);
            return new DataReaderWrapper(connection, reader, finder);
        }

        public virtual async Task<IAsyncSqlRowReader> ExecuteQueryAsync(SqlStatement statement, ISqlConnection connection, IValueConverterProvider finder, Action<IDbCommand>? beforeExecution, Action<IDbCommand>? afterExecution, CancellationToken ct)
        {
            if (statement is null)
                throw new ArgumentNullException(nameof(statement));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            if (finder is null)
                throw new ArgumentNullException(nameof(finder));

            using IDbCommand cmd = connection.CreateCommand();
            cmd.Connection = connection.DbConnection;
            cmd.Transaction = connection.IsTransactional ? connection.DbTransaction : null;
            cmd.CommandText = statement.CommandTextWriter.ToString();
            cmd.CommandType = CommandType.Text;
            foreach (var parameter in statement.Parameters.Select(x => x.Parameter))
                cmd.Parameters.Add(parameter);

            beforeExecution?.Invoke(cmd);
            ct.ThrowIfCancellationRequested();

            if (string.IsNullOrWhiteSpace(cmd.CommandText))
                cmd.CommandText = statement.CommandTextWriter.ToString();

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Executing query:\r\n{query}\r\n{parameters}", cmd.CommandText, ConvertParametersForLogging(statement.Parameters));
            await connection.EnsureOpenAsync(ct).ConfigureAwait(false);
            var reader = cmd is DbCommand dbCommand ? await dbCommand.ExecuteReaderAsync(ct).ConfigureAwait(false) : throw new DbExpressionException($"Async query execution requires a command of type {typeof(DbCommand)}, but a command of type {cmd.GetType()} was provided.");

            afterExecution?.Invoke(cmd);
            ct.ThrowIfCancellationRequested();
            return new AsyncDataReaderWrapper(connection, reader, finder, ct);
        }

        public virtual T? ExecuteScalar<T>(SqlStatement statement, ISqlConnection connection, Action<IDbCommand>? beforeExecution, Action<IDbCommand>? afterExecution)
        {
            if (statement is null)
                throw new ArgumentNullException(nameof(statement));

            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            using IDbCommand cmd = connection.CreateCommand();
            cmd.Connection = connection.DbConnection;
            cmd.Transaction = connection.IsTransactional ? connection.DbTransaction : null;
            cmd.CommandType = CommandType.Text;
            foreach (var parameter in statement.Parameters.Select(x => x.Parameter))
                cmd.Parameters.Add(parameter);

            beforeExecution?.Invoke(cmd);

            if (string.IsNullOrWhiteSpace(cmd.CommandText))
                cmd.CommandText = statement.CommandTextWriter.ToString();

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Executing query:\r\n{query}\r\n{parameters}", cmd.CommandText, ConvertParametersForLogging(statement.Parameters));
            connection.EnsureOpen();
            var output = cmd.ExecuteScalar();
            afterExecution?.Invoke(cmd);

            if (output is null)
                return default;

            return (T)Convert.ChangeType(output, typeof(T));
        }

        public virtual async Task<T?> ExecuteScalarAsync<T>(SqlStatement statement, ISqlConnection connection, Action<IDbCommand>? beforeExecution, Action<IDbCommand>? afterExecution, CancellationToken ct)
        {
            using IDbCommand cmd = connection.CreateCommand();
            cmd.Connection = connection.DbConnection;
            cmd.Transaction = connection.IsTransactional ? connection.DbTransaction : null;
            cmd.CommandText = statement.CommandTextWriter.ToString();
            cmd.CommandType = CommandType.Text;
            foreach (var parameter in statement.Parameters.Select(x => x.Parameter))
                cmd.Parameters.Add(parameter);

            beforeExecution?.Invoke(cmd);
            ct.ThrowIfCancellationRequested();
            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Executing query:\r\n{query}\r\n{parameters}", cmd.CommandText, ConvertParametersForLogging(statement.Parameters));
            connection.EnsureOpen();
            var output = cmd is DbCommand dbCommand ? await dbCommand.ExecuteScalarAsync(ct).ConfigureAwait(false) : throw new DbExpressionException($"Async query execution requires a command of type {typeof(DbCommand)}, but a command of type {cmd.GetType()} was provided.");
            afterExecution?.Invoke(cmd);
            ct.ThrowIfCancellationRequested();

            if (output is null)
                return default;

            return (T)Convert.ChangeType(output, typeof(T));
        }

        private IEnumerable<string> ConvertParametersForLogging(IList<ParameterizedExpression> parameters)
        {
            if (!loggingOptions.LogParameterValues)
                return Enumerable.Empty<string>();
            return parameters.Select(p => $"{p.Parameter.ParameterName}={p.Parameter.Value}");
        }
    }
}
