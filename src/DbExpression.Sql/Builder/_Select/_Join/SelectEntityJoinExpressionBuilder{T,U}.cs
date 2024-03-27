#region license
// Copyright (c) dbExpression.  All rights reserved.
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
// The latest version of this file can be found at https://github.com/dbexpression-team/dbexpression
#endregion

﻿using DbExpression.Sql.Expression;
using System;

namespace DbExpression.Sql.Builder
{
    public class SelectEntityJoinExpressionBuilder<TDatabase, TEntity> : SelectJoinExpressionBuilder<TDatabase, SelectEntityContinuation<TDatabase, TEntity>>,
        JoinOn<SelectEntityContinuation<TDatabase, TEntity>>,
        WithAlias<JoinOn<SelectEntityContinuation<TDatabase, TEntity>>>
        where TDatabase : class, ISqlDatabaseRuntime
        where TEntity : class, IDbEntity, new()
    {
        #region internals
        private readonly SelectEntityContinuation<TDatabase, TEntity> caller;
        #endregion

        #region constructors
        public SelectEntityJoinExpressionBuilder(SelectQueryExpression expression, IExpressionElement joinTo, JoinOperationExpressionOperator joinType, SelectEntityContinuation<TDatabase, TEntity> caller)
            : base(expression, joinTo, joinType)
        {
            this.caller = caller ?? throw new ArgumentNullException(nameof(caller));
        }
        #endregion

        #region methods
        /// <inheritdoc />
        JoinOn<SelectEntityContinuation<TDatabase, TEntity>> WithAlias<JoinOn<SelectEntityContinuation<TDatabase, TEntity>>>.As(string alias)
        {
            As(alias);
            return this;
        }

        /// <inheritdoc />
        SelectEntityContinuation<TDatabase, TEntity> JoinOn<SelectEntityContinuation<TDatabase, TEntity>>.On(AnyJoinOnExpression joinOn)
        {
            On(joinOn);
            return caller;
        }
        #endregion
    }
}
