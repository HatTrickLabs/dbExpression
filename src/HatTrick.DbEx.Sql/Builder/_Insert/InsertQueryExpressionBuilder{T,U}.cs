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

using HatTrick.DbEx.Sql.Connection;
using HatTrick.DbEx.Sql.Expression;
using HatTrick.DbEx.Sql.Pipeline;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Sql.Builder
{
    public class InsertQueryExpressionBuilder<TDatabase, TEntity> : QueryExpressionBuilder<TDatabase>,
        InsertEntity<TDatabase, TEntity>,
        InsertEntities<TDatabase, TEntity>,
        InsertEntityTermination<TDatabase, TEntity>,
        InsertEntitiesTermination<TDatabase, TEntity>,
        InsertEntityTermination<TDatabase>,
        InsertEntitiesTermination<TDatabase>
        where TDatabase : class, ISqlDatabaseRuntime
        where TEntity : class, IDbEntity
    {
        #region internals
        private readonly InsertQueryExpression _expression;
        private readonly IEnumerable<TEntity> _instances;
        protected Func<IInsertQueryExecutionPipeline> ExecutionPipelineFactory { get; private set; }
        protected override QueryExpression Expression => InsertQueryExpression;
        public InsertQueryExpression InsertQueryExpression => _expression;
        #endregion

        #region constructors
        public InsertQueryExpressionBuilder(
            InsertQueryExpression expression,
            IEnumerable<TEntity> instances,
            Func<IInsertQueryExecutionPipeline> executionPipelineFactory
        )
        {
            _expression = expression ?? throw new ArgumentNullException(nameof(expression));
            _instances = instances ?? throw new ArgumentNullException(nameof(instances));
            ExecutionPipelineFactory = executionPipelineFactory ?? throw new ArgumentNullException(nameof(executionPipelineFactory));
        }
        #endregion

        #region methods
        #region InsertEntity<TDatabase, TEntity>
        /// <inheritdoc />
        InsertEntityTermination<TDatabase, TEntity> InsertEntity<TDatabase, TEntity>.Into(Table<TEntity> entity)
        {
            Into(entity);
            return this;
        }

        /// <inheritdoc />
        InsertEntitiesTermination<TDatabase, TEntity> InsertEntities<TDatabase, TEntity>.Into(Table<TEntity> entity)
        {
            Into(entity);
            return this;
        }
        #endregion

        protected virtual void Into(Table<TEntity> entity)
        {
            var i = 0;
            InsertQueryExpression.Into = entity;
            InsertQueryExpression.Inserts = _instances.ToDictionary(x => i++, x => new InsertExpressionSet(x, (entity.BuildInclusiveInsertExpression(x) as IExpressionListProvider<InsertExpression>).Expressions));
            InsertQueryExpression.Outputs = entity.BuildInclusiveSelectExpression().Expressions.Select(x => x.AsFieldExpression()).Where(x => x is not null).Cast<FieldExpression>().ToList();
        }

        #region InsertEntityTermination<TDatabase>
        /// <inheritdoc />
        void InsertEntityTermination<TDatabase>.Execute()
        {
            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                null,
                null
            );
        }

        /// <inheritdoc />
        void InsertEntityTermination<TDatabase>.Execute(int commandTimeout)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                null,
                command => command.CommandTimeout = commandTimeout
            );
        }

        /// <inheritdoc />
        void InsertEntityTermination<TDatabase>.Execute(ISqlConnection connection)
        {
            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                null
            );
        }

        /// <inheritdoc />
        void InsertEntityTermination<TDatabase>.Execute(ISqlConnection connection, int commandTimeout)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                command => command.CommandTimeout = commandTimeout
            );
        }

        /// <inheritdoc />
        Task InsertEntityTermination<TDatabase>.ExecuteAsync(CancellationToken cancellationToken)
        {
            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                null,
                null,
                cancellationToken
            );
        }

        /// <inheritdoc />
        Task InsertEntityTermination<TDatabase>.ExecuteAsync(ISqlConnection connection, CancellationToken cancellationToken)
        {
            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                null,
                cancellationToken
            );
        }

        /// <inheritdoc />
        Task InsertEntityTermination<TDatabase>.ExecuteAsync(int commandTimeout, CancellationToken cancellationToken)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                null,
                command => command.CommandTimeout = commandTimeout,
                cancellationToken
            );
        }

        /// <inheritdoc />
        Task InsertEntityTermination<TDatabase>.ExecuteAsync(ISqlConnection connection, int commandTimeout, CancellationToken cancellationToken)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                command => command.CommandTimeout = commandTimeout,
                cancellationToken
            );
        }
        #endregion

        #region InsertEntitiesTermination<TDatabase>
        /// <inheritdoc />
        void InsertEntitiesTermination<TDatabase>.Execute()
        {
            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                null,
                null
            );
        }

        /// <inheritdoc />
        void InsertEntitiesTermination<TDatabase>.Execute(int commandTimeout)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                null,
                command => command.CommandTimeout = commandTimeout
            );
        }

        /// <inheritdoc />
        void InsertEntitiesTermination<TDatabase>.Execute(ISqlConnection connection)
        {
            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                null
            );
        }

        /// <inheritdoc />
        void InsertEntitiesTermination<TDatabase>.Execute(ISqlConnection connection, int commandTimeout)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return;

            ExecutePipeline(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                command => command.CommandTimeout = commandTimeout
            );
        }

        /// <inheritdoc />
        Task InsertEntitiesTermination<TDatabase>.ExecuteAsync(CancellationToken cancellationToken)
        {
            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                null,
                null,
                cancellationToken
            );
        }

        /// <inheritdoc />
        Task InsertEntitiesTermination<TDatabase>.ExecuteAsync(ISqlConnection connection, CancellationToken cancellationToken)
        {
            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                null,
                cancellationToken
            );
        }

        /// <inheritdoc />
        Task InsertEntitiesTermination<TDatabase>.ExecuteAsync(int commandTimeout, CancellationToken cancellationToken)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                null,
                command => command.CommandTimeout = commandTimeout,
                cancellationToken
            );
        }
        
        /// <inheritdoc />
        Task InsertEntitiesTermination<TDatabase>.ExecuteAsync(ISqlConnection connection, int commandTimeout, CancellationToken cancellationToken)
        {
            if (commandTimeout <= 0)
                throw new ArgumentException($"{nameof(commandTimeout)} must be a number greater than 0.");

            if (!InsertQueryExpression.Inserts.Any())
                return Task.CompletedTask;

            return ExecutePipelineAsync(
                connection ?? throw new ArgumentNullException(nameof(connection)),
                command => command.CommandTimeout = commandTimeout,
                cancellationToken
            );
        }

        #endregion
        private void ExecutePipeline(ISqlConnection? connection, Action<IDbCommand>? configureCommand)
            => ExecutionPipelineFactory().ExecuteInsert<TEntity>(InsertQueryExpression, connection, configureCommand);

        private Task ExecutePipelineAsync(ISqlConnection? connection, Action<IDbCommand>? configureCommand, CancellationToken cancellationToken)
            => ExecutionPipelineFactory().ExecuteInsertAsync<TEntity>(InsertQueryExpression, connection, configureCommand, cancellationToken);
        #endregion
    }
}
