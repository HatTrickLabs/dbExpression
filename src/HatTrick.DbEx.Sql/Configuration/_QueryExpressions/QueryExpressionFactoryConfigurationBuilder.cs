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
    public class QueryExpressionFactoryConfigurationBuilder : IQueryExpressionFactoryConfigurationBuilder
    {
        #region internals
        private readonly RuntimeSqlDatabaseConfiguration configuration;
        #endregion

        #region constructors
        public QueryExpressionFactoryConfigurationBuilder(RuntimeSqlDatabaseConfiguration configuration)
        {
            this.configuration = configuration;
        }
        #endregion

        #region methods
        public void Use(IQueryExpressionFactory factory)
            => configuration.QueryExpressionFactory = factory;

        public void Use<TQueryExpressionFactory>()
            where TQueryExpressionFactory : class, IQueryExpressionFactory, new()
            => Use<TQueryExpressionFactory>(_ => { });

        public void Use<TQueryExpressionFactory>(Action<TQueryExpressionFactory> configureFactory)
            where TQueryExpressionFactory : class, IQueryExpressionFactory, new()
        {
            if (configuration.QueryExpressionFactory is not TQueryExpressionFactory)
                configuration.QueryExpressionFactory = new TQueryExpressionFactory();
#pragma warning disable CS8604 // Possible null reference argument.
            configureFactory?.Invoke(configuration.QueryExpressionFactory as TQueryExpressionFactory); //TODO: interface
#pragma warning restore CS8604 // Possible null reference argument.
        }

        public void UseDefaultFactory()
        {
            if (configuration.QueryExpressionFactory is not QueryExpressionFactory)
                configuration.QueryExpressionFactory = new QueryExpressionFactory();
        }
        #endregion
    }
}
