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

﻿using HatTrick.DbEx.Sql.Executor;
using System.Data;

namespace HatTrick.DbEx.Sql.Configuration
{
    public interface ISqlStatementExecutionGroupingConfigurationBuilders : ISqlStatementConfigurationBuilderAssemblyGrouping
    {
        /// <summary>
        /// Configure the factory used for creating an <see cref="ISqlStatementExecutor"/> used to execute a sql statement against the target database.  
        /// </summary>
        ISqlStatementFactoryConfigurationBuilder Executor { get; }

        /// <summary>
        /// Configure the factory used for creating an execution pipeline used to create and execute a sql statement.  The pipeline specifies
        /// the order of events from assembly to execution.  Use with caution, there is almost certainly
        /// a better integration point to achieve something other than overriding the default factory.
        /// </summary>
        IQueryExecutionPipelineFactoryConfigurationBuilder Pipeline { get; }

        /// <summary>
        /// Configure the factory used for creating an <see cref="IDbConnection"/> used to execute sql statements against the target database.  
        /// </summary>
        ISqlConnectionFactoryConfigurationBuilder Connection { get; }
    }
}
