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

using System;

namespace HatTrick.DbEx.Sql.Configuration
{
    public abstract class SqlDatabaseRuntimeConfigurationBuilder :
        ISqlDatabaseRuntimeConfigurationBuilder
    {
        #region internals
        private readonly SqlDatabaseRuntimeConfiguration? configuration;
        #endregion

        #region internals
        private IConnectionStringFactoryConfigurationBuilder? _connectionString;
        private ISqlStatementsConfigurationBuilderGrouping? _assembler;
        private ISqlDatabaseMetadataProviderConfigurationBuilder? _metadata;
        private IQueryExpressionFactoryConfigurationBuilder? _queryExpressions;
        private IValueConverterFactoryConfigurationBuilder? _valueConverter;
        private IQueryExecutionPipelineEventConfigurationBuilder? _event;

        private IEntitiesConfigurationBuilderGrouping? _entities;
        #endregion

        #region interface
        public IConnectionStringFactoryConfigurationBuilder ConnectionString => _connectionString ??= new ConnectionStringFactoryConfigurationBuilder(configuration!);
        public ISqlDatabaseMetadataProviderConfigurationBuilder SchemaMetadata => _metadata ??= new SqlDatabaseMetadataProviderConfigurationBuilder(configuration!);
        public IQueryExpressionFactoryConfigurationBuilder QueryExpressions => _queryExpressions ??= new QueryExpressionFactoryConfigurationBuilder(configuration!);
        public IEntitiesConfigurationBuilderGrouping Entities => _entities ??= new EntitiesConfigurationBuilderGrouping(configuration!);
        public IValueConverterFactoryConfigurationBuilder Conversions => _valueConverter ??= new ValueConverterFactoryConfigurationBuilder(configuration!);
        public ISqlStatementsConfigurationBuilderGrouping SqlStatements => _assembler ??= new SqlStatementsConfigurationBuilderGrouping(configuration!);
        public IQueryExecutionPipelineEventConfigurationBuilder Events => _event ??= new QueryExecutionPipelineEventConfigurationBuilder(configuration!);
        #endregion

        #region constructors
        protected SqlDatabaseRuntimeConfigurationBuilder()
        {

        }

        protected SqlDatabaseRuntimeConfigurationBuilder(SqlDatabaseRuntimeConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        #endregion
    }
}