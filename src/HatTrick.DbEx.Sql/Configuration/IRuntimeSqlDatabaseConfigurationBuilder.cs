﻿using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.Sql.Configuration
{
    public interface IRuntimeSqlDatabaseConfigurationBuilder
    {
        /// <summary>
        /// Configure the factories used for assembly and execution of sql statements.
        /// </summary>
        ISqlStatementsConfigurationBuilderGrouping SqlStatements { get; }

        /// <summary>
        /// Configure the provider used for database schema metadata.  The provider is responsible for providing the properties of the database schema, column and table names, 
        /// column data types.
        /// generated model.
        /// </summary>
        ISqlDatabaseMetadataProviderConfigurationBuilder SchemaMetadata { get; }

        /// <summary>
        /// Configure the factory used for creation of <see cref="QueryExpression" />(s).  
        /// </summary>
        /// <remarks>All sql statements executed against a database start with an instance of a <see cref="QueryExpression" />.</remarks>
        IQueryExpressionFactoryConfigurationBuilder QueryExpressions { get; }

        /// <summary>
        /// Configure custom delegates to execute during the assembly of query expressions and execution of sql statements.  
        /// </summary>
        IExecutionPipelineEventConfigurationBuilder Events { get; }

        /// <summary>
        /// Configure the factory used to create a value converter used to convert data to and from the target database.  
        /// </summary>
        IValueConverterFactoryConfigurationBuilder Conversions { get; }

        /// <summary>
        /// Configure the factory used for the creation of entities prior to mapping from data returned from the database.  
        /// </summary>
        IEntitiesConfigurationBuilderGrouping Entities { get; }
    }
}
