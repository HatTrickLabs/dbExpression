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

﻿using HatTrick.DbEx.Sql.Assembler;
using System;

namespace HatTrick.DbEx.Sql.Configuration
{
    public interface IExpressionElementAppenderFactoryConfigurationBuilder
    {
        /// <summary>
        /// Use a custom factory for creating appenders for appending the elements of a query expression to a sql statement writer.
        /// </summary>
        ISqlStatementAssemblyGroupingConfigurationBuilders Use(IExpressionElementAppenderFactory factory);

        /// <summary>
        /// Use a custom factory for creating appenders for appending the elements of a query expression to a sql statement writer.
        /// </summary>
        ISqlStatementAssemblyGroupingConfigurationBuilders Use<TExpressionElementAppenderFactory>()
            where TExpressionElementAppenderFactory : class, IExpressionElementAppenderFactory, new();

        /// <summary>
        /// Use a custom factory for creating appenders for appending the elements of a query expression to a sql statement writer.
        /// </summary>
        /// <param name="configureFactory">Configure the <typeparamref name="TExpressionElementAppenderFactory"/> factory.</param>
        ISqlStatementAssemblyGroupingConfigurationBuilders Use<TExpressionElementAppenderFactory>(Action<TExpressionElementAppenderFactory> configureFactory)
            where TExpressionElementAppenderFactory : class, IExpressionElementAppenderFactory, new();

        /// <summary>
        /// Use a custom factory for creating appenders for appending the elements of a query expression to a sql statement writer.
        /// </summary>
        /// <param name="factory">A delegate responsible for creating an <see cref="IExpressionElementAppender"/>.</param>
        ISqlStatementAssemblyGroupingConfigurationBuilders Use(Func<Type, IExpressionElementAppender> factory);

        /// <summary>
        /// Use the default factory for creating appenders for appending the elements of a query expression to a sql statement writer.
        /// </summary>
        ISqlStatementAssemblyGroupingConfigurationBuilders UseDefaultFactory();
    }
}
