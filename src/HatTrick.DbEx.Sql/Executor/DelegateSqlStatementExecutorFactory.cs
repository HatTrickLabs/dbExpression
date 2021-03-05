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

﻿using HatTrick.DbEx.Sql.Expression;
using System;
using System.Collections.Generic;
using System.Text;

namespace HatTrick.DbEx.Sql.Executor
{
    public class DelegateSqlStatementExecutorFactory : ISqlStatementExecutorFactory
    {
        #region internals
        private readonly Func<QueryExpression, ISqlStatementExecutor> factory;
        #endregion

        #region constructors
        public DelegateSqlStatementExecutorFactory(Func<QueryExpression, ISqlStatementExecutor> factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public DelegateSqlStatementExecutorFactory(Func<ISqlStatementExecutorFactory> factory)
        {
            if (factory is null)
                throw new ArgumentNullException(nameof(factory));

            this.factory = (queryExpression) => factory()?.CreateSqlStatementExecutor(queryExpression) ?? throw new DbExpressionException("Cannot create a Sql Statement Executor: The factory returned a null value.");
        }
        #endregion

        #region methods
       public ISqlStatementExecutor CreateSqlStatementExecutor(QueryExpression queryExpression)
            => factory(queryExpression);
        #endregion
    }
}
