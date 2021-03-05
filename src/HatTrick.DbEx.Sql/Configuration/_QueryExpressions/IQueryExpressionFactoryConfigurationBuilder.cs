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

namespace HatTrick.DbEx.Sql.Configuration
{
    public interface IQueryExpressionFactoryConfigurationBuilder
    {
        /// <summary>
        /// Use a custom factory to create query expressions used in fluent builders.
        /// </summary>
        void Use(IQueryExpressionFactory factory);

        /// <summary>
        /// Use a custom factory to create query expressions used in fluent builders.
        /// </summary>
        void Use<TQueryExpressionFactory>()
            where TQueryExpressionFactory : class, IQueryExpressionFactory, new();

        /// <summary>
        /// Use a custom factory to create query expressions used in fluent builders.
        /// </summary>
        /// <param name="configureFactory">Configure the query expression factory.</param>
        void Use<TQueryExpressionFactory>(Action<TQueryExpressionFactory> configureFactory)
            where TQueryExpressionFactory : class, IQueryExpressionFactory, new();

        /// <summary>
        /// Use the default factory to create query expressions used in fluent builders.
        /// </summary>
        void UseDefaultFactory();
    }
}
