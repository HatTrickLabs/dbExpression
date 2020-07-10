﻿using HatTrick.DbEx.MsSql.Assembler;
using HatTrick.DbEx.MsSql.Connection;
using HatTrick.DbEx.MsSql.Executor;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Mapper;
using HatTrick.DbEx.Sql.Pipeline;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HatTrick.DbEx.MsSql.Configuration
{
    public static class DbExpressionConfigurationExtensions
    {
        private static DatabaseConfigurationBuilder CreateDatabaseConfigurationBuilder(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey)
        {
            if (connectionStringFactory == null)
                throw new DbExpressionConfigurationException($"{nameof(connectionStringFactory)} cannot be null");

            var connectionString = connectionStringFactory();
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new DbExpressionConfigurationException($"The connection string settings factory did not provide a value for a connection string");

            SqlConnectionStringBuilder connBuilder;
            try
            {
                connBuilder = new SqlConnectionStringBuilder(connectionString);
            }
            catch (FormatException e)
            {
                throw new DbExpressionConfigurationException($"The connection string is not in a valid format", e);
            }
            catch (ArgumentException e)
            {
                throw new DbExpressionConfigurationException($"The connection string appears to have an issue", e);
            }

            var database = new DatabaseConfiguration(metaProvider);
            database.Metadata.Name = metadataKey ?? connBuilder.InitialCatalog;            
            builder.AddDatabase(database.Metadata.Name, database);

            database.ExecutionPipelineFactory = new ExecutionPipelineFactory(database);

            return new DatabaseConfigurationBuilder(database);
        }

        //TO_DISCUSS: Should metadata include server info so we can infer compatibility version, or specifically specify based on method name (i.e. AddMsSql2014Database)
        #pragma warning disable IDE0060
        private static void ConfigureMsSqlCommon(this DbExpressionConfigurationBuilder builder, DatabaseConfigurationBuilder config, Func<string> connectionStringFactory)
        {
            config.UseAppenderFactory<AppenderFactory>();
            config.UseEntityFactory<EntityFactory>();
            config.UseMapperFactory<MapperFactory>();

            //configure sql statement executor factory
            var executor = new MsSqlExecutorFactory();
            executor.RegisterDefaultExecutors();
            config.UseExecutorFactory(executor);

            //configure the parameter builder factory
            config.UseParameterBuilderFactory<MsSqlParameterBuilderFactory>();

            //configure the connection factory
            config.UseConnectionFactory(new MsSqlConnectionFactory(connectionStringFactory));

            //use identity insert strategy for MsSql
            config.UseIdentityInsertStrategy();
        }

        #region 2005
        public static void AddMsSql2005Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2005(new T(), () => connectionString, null, configure);

        public static void AddMsSql2005Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, string metadataKey, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2005(new T(), () => connectionString, metadataKey, configure);

        public static void AddMsSql2005Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2005(databaseMetadataProvider, () => connectionString, metadataKey, configure);

        public static void AddMsSql2005Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2005(databaseMetadataProvider, connectionStringFactory, metadataKey, configure);

        public static void AddMsSql2005Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2005(databaseMetadataProvider, () => connectionString, null, configure);

        public static void AddMsSql2005Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2005(databaseMetadataProvider, connectionStringFactory, null, configure);

        private static void ConfigureMsSql2005(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
        {
            var config = builder.CreateDatabaseConfigurationBuilder(metaProvider, connectionStringFactory, metadataKey);
            builder.ConfigureMsSqlCommon(config, connectionStringFactory);

            //configure sql statement builder factory
            var factory = new Assembler.v2005.MsSqlStatementBuilderFactory();
            factory.RegisterDefaultStatementAssemblers();
            factory.RegisterDefaultPartAppenders();
            config.UseStatementBuilderFactory(factory);

            configure?.Invoke(config);
        }
        #endregion

        #region 2008
        public static void AddMsSql2008Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2008(new T(), () => connectionString, null, configure);

        public static void AddMsSql2008Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, string metadataKey, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2008(new T(), () => connectionString, metadataKey, configure);

        public static void AddMsSql2008Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2008(databaseMetadataProvider, () => connectionString, metadataKey, configure);

        public static void AddMsSql2008Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2008(databaseMetadataProvider, connectionStringFactory, metadataKey, configure);

        public static void AddMsSql2008Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2008(databaseMetadataProvider, () => connectionString, null, configure);

        public static void AddMsSql2008Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2008(databaseMetadataProvider, connectionStringFactory, null, configure);

        private static void ConfigureMsSql2008(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
        {
            var config = builder.CreateDatabaseConfigurationBuilder(metaProvider, connectionStringFactory, metadataKey);
            builder.ConfigureMsSqlCommon(config, connectionStringFactory);

            //configure sql statement builder factory
            var factory = new Assembler.v2008.MsSqlStatementBuilderFactory();
            factory.RegisterDefaultStatementAssemblers();
            factory.RegisterDefaultPartAppenders();
            config.UseStatementBuilderFactory(factory);

            configure?.Invoke(config);
        }
        #endregion

        #region 2012
        public static void AddMsSql2012Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2012(new T(), () => connectionString, null, configure);

        public static void AddMsSql2012Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, string metadataKey, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2012(new T(), () => connectionString, metadataKey, configure);

        public static void AddMsSql2012Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2012(databaseMetadataProvider, () => connectionString, metadataKey, configure);

        public static void AddMsSql2012Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2012(databaseMetadataProvider, connectionStringFactory, metadataKey, configure);

        public static void AddMsSql2012Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2012(databaseMetadataProvider, () => connectionString, null, configure);

        public static void AddMsSql2012Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2012(databaseMetadataProvider, connectionStringFactory, null, configure);

        private static void ConfigureMsSql2012(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
        {
            var config = builder.CreateDatabaseConfigurationBuilder(metaProvider, connectionStringFactory, metadataKey);
            builder.ConfigureMsSqlCommon(config, connectionStringFactory);

            //configure sql statement builder factory
            var factory = new Assembler.v2012.MsSqlStatementBuilderFactory();
            factory.RegisterDefaultStatementAssemblers();
            factory.RegisterDefaultPartAppenders();
            config.UseStatementBuilderFactory(factory);

            configure?.Invoke(config);
        }
        #endregion

        #region 2014
        public static void AddMsSql2014Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2014(new T(), () => connectionString, null, configure);

        public static void AddMsSql2014Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, string metadataKey, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2014(new T(), () => connectionString, metadataKey, configure);

        public static void AddMsSql2014Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2014(databaseMetadataProvider, () => connectionString, metadataKey, configure);

        public static void AddMsSql2014Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2014(databaseMetadataProvider, connectionStringFactory, metadataKey, configure);

        public static void AddMsSql2014Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2014(databaseMetadataProvider, () => connectionString, null, configure);

        public static void AddMsSql2014Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2014(databaseMetadataProvider, connectionStringFactory, null, configure);

        private static void ConfigureMsSql2014(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
        {
            var config = builder.CreateDatabaseConfigurationBuilder(metaProvider, connectionStringFactory, metadataKey);
            builder.ConfigureMsSqlCommon(config, connectionStringFactory);

            //configure sql statement builder factory
            var factory = new Assembler.v2014.MsSqlStatementBuilderFactory();
            factory.RegisterDefaultStatementAssemblers();
            factory.RegisterDefaultPartAppenders();
            config.UseStatementBuilderFactory(factory);

            configure?.Invoke(config);
        }
        #endregion

        #region 2016
        public static void AddMsSql2016Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2016(new T(), () => connectionString, null, configure);

        public static void AddMsSql2016Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, string metadataKey, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2016(new T(), () => connectionString, metadataKey, configure);

        public static void AddMsSql2016Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2016(databaseMetadataProvider, () => connectionString, metadataKey, configure);

        public static void AddMsSql2016Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2016(databaseMetadataProvider, connectionStringFactory, metadataKey, configure);

        public static void AddMsSql2016Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2016(databaseMetadataProvider, () => connectionString, null, configure);

        public static void AddMsSql2016Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2016(databaseMetadataProvider, connectionStringFactory, null, configure);

        private static void ConfigureMsSql2016(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
        {
            var config = builder.CreateDatabaseConfigurationBuilder(metaProvider, connectionStringFactory, metadataKey);
            builder.ConfigureMsSqlCommon(config, connectionStringFactory);

            //configure sql statement builder factory
            var factory = new Assembler.v2016.MsSqlStatementBuilderFactory();
            factory.RegisterDefaultStatementAssemblers();
            factory.RegisterDefaultPartAppenders();
            config.UseStatementBuilderFactory(factory);

            configure?.Invoke(config);
        }
        #endregion

        #region 2017
        public static void AddMsSql2017Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2017(new T(), () => connectionString, null, configure);

        public static void AddMsSql2017Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, string metadataKey, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2017(new T(), () => connectionString, metadataKey, configure);

        public static void AddMsSql2017Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2017(databaseMetadataProvider, () => connectionString, metadataKey, configure);

        public static void AddMsSql2017Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2017(databaseMetadataProvider, connectionStringFactory, metadataKey, configure);

        public static void AddMsSql2017Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2017(databaseMetadataProvider, () => connectionString, null, configure);

        public static void AddMsSql2017Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2017(databaseMetadataProvider, connectionStringFactory, null, configure);

        private static void ConfigureMsSql2017(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
        {
            var config = builder.CreateDatabaseConfigurationBuilder(metaProvider, connectionStringFactory, metadataKey);
            builder.ConfigureMsSqlCommon(config, connectionStringFactory);

            //configure sql statement builder factory
            var factory = new Assembler.v2017.MsSqlStatementBuilderFactory();
            factory.RegisterDefaultStatementAssemblers();
            factory.RegisterDefaultPartAppenders();
            config.UseStatementBuilderFactory(factory);

            configure?.Invoke(config);
        }
        #endregion

        #region 2019
        public static void AddMsSql2019Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2019(new T(), () => connectionString, null, configure);

        public static void AddMsSql2019Database<T>(this DbExpressionConfigurationBuilder builder, string connectionString, string metadataKey, Action<DatabaseConfigurationBuilder> configure = null)
            where T : class, IDatabaseMetadataProvider, new()
            => builder.ConfigureMsSql2019(new T(), () => connectionString, metadataKey, configure);

        public static void AddMsSql2019Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2019(databaseMetadataProvider, () => connectionString, metadataKey, configure);

        public static void AddMsSql2019Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2019(databaseMetadataProvider, connectionStringFactory, metadataKey, configure);

        public static void AddMsSql2019Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, string connectionString, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2019(databaseMetadataProvider, () => connectionString, null, configure);

        public static void AddMsSql2019Database(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider databaseMetadataProvider, Func<string> connectionStringFactory, Action<DatabaseConfigurationBuilder> configure = null)
            => builder.ConfigureMsSql2019(databaseMetadataProvider, connectionStringFactory, null, configure);

        private static void ConfigureMsSql2019(this DbExpressionConfigurationBuilder builder, IDatabaseMetadataProvider metaProvider, Func<string> connectionStringFactory, string metadataKey = null, Action<DatabaseConfigurationBuilder> configure = null)
        {
            var config = builder.CreateDatabaseConfigurationBuilder(metaProvider, connectionStringFactory, metadataKey);
            builder.ConfigureMsSqlCommon(config, connectionStringFactory);

            //configure sql statement builder factory
            var factory = new Assembler.v2019.MsSqlStatementBuilderFactory();
            factory.RegisterDefaultStatementAssemblers();
            factory.RegisterDefaultPartAppenders();
            config.UseStatementBuilderFactory(factory);

            configure?.Invoke(config);
        }
        #endregion
    }
}