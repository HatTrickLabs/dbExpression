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

﻿using HatTrick.DbEx.MsSql.Assembler;
using HatTrick.DbEx.MsSql.Connection;
using HatTrick.DbEx.MsSql.Expression.DependencyInjection.Internal;
using HatTrick.DbEx.MsSql.Microsoft.Extensions.DependencyInjection.Builder;
using HatTrick.DbEx.MsSql.Types;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Connection;
using HatTrick.DbEx.Sql.Converter;
using HatTrick.DbEx.Sql.Executor;
using HatTrick.DbEx.Sql.Expression;
using HatTrick.DbEx.Sql.Mapper;
using HatTrick.DbEx.Sql.Pipeline;
using HatTrick.DbEx.Sql.Types;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Data;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DbExpressionConfigurationBuilderExtensions
    {
        #region 2005
        /// <summary>
        /// Configures dbExpression to use a SqlServer 2005 database.  Use this method when using dependency injection to support configuration of dbExpression with services from the <see cref="IServiceCollection" />.
        /// </summary>
        /// <typeparam name="T">The (code-generated) database you want to configure for use.</typeparam>
        /// <param name="builder">The <see cref="IDbExpressionConfigurationBuilder" />, the fluent entry point for configuring the runtime environment for <typeparam name="T">. </param>
        /// <param name="configureRuntime">
        ///     <para>A delegate to configure the <see cref="RuntimeSqlDatabaseConfiguration" /> for query operations using a <see cref="IRuntimeSqlDatabaseConfigurationBuilder"/>.  The delegate provides a <see cref="IServiceProvider"/> to resolve any required services for configuration.</para>
        /// </param>        
        /// <param name="configurationLifetime">
        ///     <para>The lifetime of the configuration in the container.  <see cref="RuntimeSqlDatabaseConfiguration"/> is used to provide the settings and behavior of queries executed against the SqlServer database.</para>
        ///     <para>It is preferable to configure per request, per custom lifetime scope, etc. operations within a specific factory and use a service lifetime of singleton.
        ///         While creating a configuration object per query operation, or some other scope is not inherently expensive, it is more performant to use a service lifetime of singleton.
        ///     </para>
        /// </param>
        public static void AddMsSql2005Database<T>(this IDbExpressionConfigurationBuilder builder, Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configureRuntime, ServiceLifetime configurationLifetime = ServiceLifetime.Singleton)
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var services = builder as ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder ?? throw new DbExpressionConfigurationException($"Expected {nameof(builder)} to be of type {typeof(ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder)}, but actual type is {builder.GetType()}");
            services.Services.TryAddSingleton<HatTrick.DbEx.MsSql.Assembler.v2005.MsSqlStatementAssemblerFactory>();
            services.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory>(sp => sp.GetRequiredService<HatTrick.DbEx.MsSql.Assembler.v2005.MsSqlStatementAssemblerFactory>()));

            services.AddMsSql<T>(
                (serviceProvider, configBuilder) =>
                {
                    configBuilder.SqlStatements.Assembly.StatementAssembler.Use(serviceProvider.GetRequiredService<HatTrick.DbEx.MsSql.Assembler.v2005.MsSqlStatementAssemblerFactory>());
                    configBuilder.SqlStatements.Assembly.ElementAppender.Use<MsSqlExpressionElementAppenderFactory>(f => f.RegisterElementAppender<TrimFunctionExpression, HatTrick.DbEx.MsSql.Assembler.v2005.TrimFunctionExpressionAppender>());
                    configureRuntime.Invoke(serviceProvider, configBuilder);
                },
                configurationLifetime
            );
        }
        #endregion

        #region 2008
        /// <summary>
        /// Configures dbExpression to use a SqlServer 2008 database.  Use this method when using dependency injection to support configuration of dbExpression with services from the <see cref="IServiceCollection" />.
        /// </summary>
        /// <typeparam name="T">The (code-generated) database you want to configure for use.</typeparam>
        /// <param name="builder">The <see cref="IDbExpressionConfigurationBuilder" />, the fluent entry point for configuring the runtime environment for <typeparam name="T">. </param>
        /// <param name="configureRuntime">
        ///     <para>A delegate to configure the <see cref="RuntimeSqlDatabaseConfiguration" /> for query operations using a <see cref="IRuntimeSqlDatabaseConfigurationBuilder"/>.  The delegate provides a <see cref="IServiceProvider"/> to resolve any required services for configuration.</para>
        /// </param>        
        /// <param name="configurationLifetime">
        ///     <para>The lifetime of the configuration in the container.  <see cref="RuntimeSqlDatabaseConfiguration"/> is used to provide the settings and behavior of queries executed against the SqlServer database.</para>
        ///     <para>It is preferable to configure per request, per custom lifetime scope, etc. operations within a specific factory and use a service lifetime of singleton.
        ///         While creating a configuration object per query operation, or some other scope is not inherently expensive, it is more performant to use a service lifetime of singleton.
        ///     </para>
        /// </param>
        public static void AddMsSql2008Database<T>(this IDbExpressionConfigurationBuilder builder, Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configureRuntime, ServiceLifetime configurationLifetime = ServiceLifetime.Singleton)
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var services = builder as ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder ?? throw new DbExpressionConfigurationException($"Expected {nameof(builder)} to be of type {typeof(ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder)}, but actual type is {builder.GetType()}");
            services.Services.TryAddSingleton<HatTrick.DbEx.MsSql.Assembler.v2008.MsSqlStatementAssemblerFactory>();
            services.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory>(sp => sp.GetRequiredService<HatTrick.DbEx.MsSql.Assembler.v2008.MsSqlStatementAssemblerFactory>()));

            services.AddMsSql<T>(
                (serviceProvider, configBuilder) =>
                {
                    configBuilder.SqlStatements.Assembly.StatementAssembler.Use(serviceProvider.GetRequiredService<HatTrick.DbEx.MsSql.Assembler.v2008.MsSqlStatementAssemblerFactory>());
                    configBuilder.SqlStatements.Assembly.ElementAppender.Use<MsSqlExpressionElementAppenderFactory>(f => f.RegisterElementAppender<TrimFunctionExpression, HatTrick.DbEx.MsSql.Assembler.v2008.TrimFunctionExpressionAppender>());
                    configureRuntime.Invoke(serviceProvider, configBuilder);
                },
                configurationLifetime
            );
        }
        #endregion

        #region 2012
        /// <summary>
        /// Configures dbExpression to use a SqlServer 2012 database.  Use this method when using dependency injection to support configuration of dbExpression with services from the <see cref="IServiceCollection" />.
        /// </summary>
        /// <typeparam name="T">The (code-generated) database you want to configure for use.</typeparam>
        /// <param name="builder">The <see cref="IDbExpressionConfigurationBuilder" />, the fluent entry point for configuring the runtime environment for <typeparam name="T">. </param>
        /// <param name="configureRuntime">
        ///     <para>A delegate to configure the <see cref="RuntimeSqlDatabaseConfiguration" /> for query operations using a <see cref="IRuntimeSqlDatabaseConfigurationBuilder"/>.  The delegate provides a <see cref="IServiceProvider"/> to resolve any required services for configuration.</para>
        /// </param>        
        /// <param name="configurationLifetime">
        ///     <para>The lifetime of the configuration in the container.  <see cref="RuntimeSqlDatabaseConfiguration"/> is used to provide the settings and behavior of queries executed against the SqlServer database.</para>
        ///     <para>It is preferable to configure per request, per custom lifetime scope, etc. operations within a specific factory and use a service lifetime of singleton.
        ///         While creating a configuration object per query operation, or some other scope is not inherently expensive, it is more performant to use a service lifetime of singleton.
        ///     </para>
        /// </param>
        public static void AddMsSql2012Database<T>(this IDbExpressionConfigurationBuilder builder, Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configureRuntime, ServiceLifetime configurationLifetime = ServiceLifetime.Singleton)
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var services = builder as ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder ?? throw new DbExpressionConfigurationException($"Expected {nameof(builder)} to be of type {typeof(ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder)}, but actual type is {builder.GetType()}");
            services.Services.TryAddSingleton<MsSqlStatementAssemblerFactory>();
            services.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory>(sp => sp.GetRequiredService<MsSqlStatementAssemblerFactory>()));

            services.AddMsSql<T>(
                (serviceProvider, configBuilder) =>
                {
                    configBuilder.SqlStatements.Assembly.StatementAssembler.Use(serviceProvider.GetRequiredService<MsSqlStatementAssemblerFactory>());
                    configBuilder.SqlStatements.Assembly.ElementAppender.Use<MsSqlExpressionElementAppenderFactory>(f => f.RegisterElementAppender<TrimFunctionExpression, HatTrick.DbEx.MsSql.Assembler.v2012.TrimFunctionExpressionAppender>());
                    configureRuntime.Invoke(serviceProvider, configBuilder);
                },
                configurationLifetime
            );
        }
        #endregion

        #region 2014
        /// <summary>
        /// Configures dbExpression to use a SqlServer 2014 database.  Use this method when using dependency injection to support configuration of dbExpression with services from the <see cref="IServiceCollection" />.
        /// </summary>
        /// <typeparam name="T">The (code-generated) database you want to configure for use.</typeparam>
        /// <param name="builder">The <see cref="IDbExpressionConfigurationBuilder" />, the fluent entry point for configuring the runtime environment for <typeparam name="T">. </param>
        /// <param name="configureRuntime">
        ///     <para>A delegate to configure the <see cref="RuntimeSqlDatabaseConfiguration" /> for query operations using a <see cref="IRuntimeSqlDatabaseConfigurationBuilder"/>.  The delegate provides a <see cref="IServiceProvider"/> to resolve any required services for configuration.</para>
        /// </param>        
        /// <param name="configurationLifetime">
        ///     <para>The lifetime of the configuration in the container.  <see cref="RuntimeSqlDatabaseConfiguration"/> is used to provide the settings and behavior of queries executed against the SqlServer database.</para>
        ///     <para>It is preferable to configure per request, per custom lifetime scope, etc. operations within a specific factory and use a service lifetime of singleton.
        ///         While creating a configuration object per query operation, or some other scope is not inherently expensive, it is more performant to use a service lifetime of singleton.
        ///     </para>
        /// </param>
        public static void AddMsSql2014Database<T>(this IDbExpressionConfigurationBuilder builder, Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configureRuntime, ServiceLifetime configurationLifetime = ServiceLifetime.Singleton)
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var services = builder as ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder ?? throw new DbExpressionConfigurationException($"Expected {nameof(builder)} to be of type {typeof(ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder)}, but actual type is {builder.GetType()}");
            services.Services.TryAddSingleton<MsSqlStatementAssemblerFactory>();
            services.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory>(sp => sp.GetRequiredService<MsSqlStatementAssemblerFactory>()));

            services.AddMsSql<T>(
                (serviceProvider, configBuilder) =>
                {
                    configBuilder.SqlStatements.Assembly.StatementAssembler.Use(serviceProvider.GetRequiredService<MsSqlStatementAssemblerFactory>());
                    configBuilder.SqlStatements.Assembly.ElementAppender.Use<MsSqlExpressionElementAppenderFactory>(f => f.RegisterElementAppender<TrimFunctionExpression, HatTrick.DbEx.MsSql.Assembler.v2014.TrimFunctionExpressionAppender>());
                    configureRuntime.Invoke(serviceProvider, configBuilder);
                },
                configurationLifetime
            );
        }
        #endregion

        #region 2016
        /// <summary>
        /// Configures dbExpression to use a SqlServer 2016 database.  Use this method when using dependency injection to support configuration of dbExpression with services from the <see cref="IServiceCollection" />.
        /// </summary>
        /// <typeparam name="T">The (code-generated) database you want to configure for use.</typeparam>
        /// <param name="builder">The <see cref="IDbExpressionConfigurationBuilder" />, the fluent entry point for configuring the runtime environment for <typeparam name="T">. </param>
        /// <param name="configureRuntime">
        ///     <para>A delegate to configure the <see cref="RuntimeSqlDatabaseConfiguration" /> for query operations using a <see cref="IRuntimeSqlDatabaseConfigurationBuilder"/>.  The delegate provides a <see cref="IServiceProvider"/> to resolve any required services for configuration.</para>
        /// </param>        
        /// <param name="configurationLifetime">
        ///     <para>The lifetime of the configuration in the container.  <see cref="RuntimeSqlDatabaseConfiguration"/> is used to provide the settings and behavior of queries executed against the SqlServer database.</para>
        ///     <para>It is preferable to configure per request, per custom lifetime scope, etc. operations within a specific factory and use a service lifetime of singleton.
        ///         While creating a configuration object per query operation, or some other scope is not inherently expensive, it is more performant to use a service lifetime of singleton.
        ///     </para>
        /// </param>
        public static void AddMsSql2016Database<T>(this IDbExpressionConfigurationBuilder builder, Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configureRuntime, ServiceLifetime configurationLifetime = ServiceLifetime.Singleton)
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var services = builder as ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder ?? throw new DbExpressionConfigurationException($"Expected {nameof(builder)} to be of type {typeof(ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder)}, but actual type is {builder.GetType()}");
            services.Services.TryAddSingleton<MsSqlStatementAssemblerFactory>();
            services.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory>(sp => sp.GetRequiredService<MsSqlStatementAssemblerFactory>()));

            services.AddMsSql<T>(
                (serviceProvider, configBuilder) =>
                {
                    configBuilder.SqlStatements.Assembly.StatementAssembler.Use(serviceProvider.GetRequiredService<MsSqlStatementAssemblerFactory>());
                    configBuilder.SqlStatements.Assembly.ElementAppender.Use<MsSqlExpressionElementAppenderFactory>(f => f.RegisterElementAppender<TrimFunctionExpression, HatTrick.DbEx.MsSql.Assembler.v2016.TrimFunctionExpressionAppender>());
                    configureRuntime.Invoke(serviceProvider, configBuilder);
                },
                configurationLifetime
            );
        }
        #endregion

        #region 2017
        /// <summary>
        /// Configures dbExpression to use a SqlServer 2017 database.  Use this method when using dependency injection to support configuration of dbExpression with services from the <see cref="IServiceCollection" />.
        /// </summary>
        /// <typeparam name="T">The (code-generated) database you want to configure for use.</typeparam>
        /// <param name="builder">The <see cref="IDbExpressionConfigurationBuilder" />, the fluent entry point for configuring the runtime environment for <typeparam name="T">. </param>
        /// <param name="configureRuntime">
        ///     <para>A delegate to configure the <see cref="RuntimeSqlDatabaseConfiguration" /> for query operations using a <see cref="IRuntimeSqlDatabaseConfigurationBuilder"/>.  The delegate provides a <see cref="IServiceProvider"/> to resolve any required services for configuration.</para>
        /// </param>        
        /// <param name="configurationLifetime">
        ///     <para>The lifetime of the configuration in the container.  <see cref="RuntimeSqlDatabaseConfiguration"/> is used to provide the settings and behavior of queries executed against the SqlServer database.</para>
        ///     <para>It is preferable to configure per request, per custom lifetime scope, etc. operations within a specific factory and use a service lifetime of singleton.
        ///         While creating a configuration object per query operation, or some other scope is not inherently expensive, it is more performant to use a service lifetime of singleton.
        ///     </para>
        /// </param>
        public static void AddMsSql2017Database<T>(this IDbExpressionConfigurationBuilder builder, Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configureRuntime, ServiceLifetime configurationLifetime = ServiceLifetime.Singleton)
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var services = builder as ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder ?? throw new DbExpressionConfigurationException($"Expected {nameof(builder)} to be of type {typeof(ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder)}, but actual type is {builder.GetType()}");
            services.Services.TryAddSingleton<MsSqlStatementAssemblerFactory>();
            services.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory>(sp => sp.GetRequiredService<MsSqlStatementAssemblerFactory>()));

            services.AddMsSql<T>(
                (serviceProvider, configBuilder) =>
                {
                    configBuilder.SqlStatements.Assembly.StatementAssembler.Use(serviceProvider.GetRequiredService<MsSqlStatementAssemblerFactory>());
                    configureRuntime.Invoke(serviceProvider, configBuilder);
                },
                configurationLifetime
            );
        }
        #endregion

        #region 2019
        /// <summary>
        /// Configures dbExpression to use a SqlServer 2019 database.  Use this method when using dependency injection to support configuration of dbExpression with services from the <see cref="IServiceCollection" />.
        /// </summary>
        /// <typeparam name="T">The (code-generated) database you want to configure for use.</typeparam>
        /// <param name="builder">The <see cref="IDbExpressionConfigurationBuilder" />, the fluent entry point for configuring the runtime environment for <typeparam name="T">. </param>
        /// <param name="configureRuntime">
        ///     <para>A delegate to configure the <see cref="RuntimeSqlDatabaseConfiguration" /> for query operations using a <see cref="IRuntimeSqlDatabaseConfigurationBuilder"/>.  The delegate provides a <see cref="IServiceProvider"/> to resolve any required services for configuration.</para>
        /// </param>        
        /// <param name="configurationLifetime">
        ///     <para>The lifetime of the configuration in the container.  <see cref="RuntimeSqlDatabaseConfiguration"/> is used to provide the settings and behavior of queries executed against the SqlServer database.</para>
        ///     <para>It is preferable to configure per request, per custom lifetime scope, etc. operations within a specific factory and use a service lifetime of singleton.
        ///         While creating a configuration object per query operation, or some other scope is not inherently expensive, it is more performant to use a service lifetime of singleton.
        ///     </para>
        /// </param>
        public static void AddMsSql2019Database<T>(this IDbExpressionConfigurationBuilder builder, Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configureRuntime, ServiceLifetime configurationLifetime = ServiceLifetime.Singleton)
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var services = builder as ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder ?? throw new DbExpressionConfigurationException($"Expected {nameof(builder)} to be of type {typeof(ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder)}, but actual type is {builder.GetType()}");
            services.Services.TryAddSingleton<MsSqlStatementAssemblerFactory>();
            services.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory>(sp => sp.GetRequiredService<MsSqlStatementAssemblerFactory>()));

            services.AddMsSql<T>(
                (serviceProvider, configBuilder) =>
                {
                    configBuilder.SqlStatements.Assembly.StatementAssembler.Use(serviceProvider.GetRequiredService<MsSqlStatementAssemblerFactory>());
                    configureRuntime.Invoke(serviceProvider, configBuilder);
                },
                configurationLifetime
            );
        }
        #endregion

        private static void AddMsSql<T>(
            this ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder builder,
            Action<IServiceProvider, IRuntimeSqlDatabaseConfigurationBuilder> configuration,
            ServiceLifetime configurationLifetime = ServiceLifetime.Singleton
        )
            where T : class, IRuntimeEnvironmentSqlDatabase, new()
        {
            if (configuration is null)
                throw new ArgumentNullException(nameof(configuration));

            builder.Environment = new T();

            //sql
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IQueryExpressionFactory, QueryExpressionFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IEntityFactory, EntityFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IMapperFactory, MapperFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IValueConverterFactory, ValueConverterFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementBuilderFactory, SqlStatementBuilderFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementAssemblerFactory, SqlStatementAssemblerFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IAppenderFactory, AppenderFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<ISqlStatementExecutorFactory, SqlStatementExecutorFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IExecutionPipelineFactory, ExecutionPipelineFactory>());

            //mssql
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IDbTypeMapFactory<SqlDbType>, MsSqlTypeMapFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<IExpressionElementAppenderFactory, MsSqlExpressionElementAppenderFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<ISqlParameterBuilderFactory, MsSqlParameterBuilderFactory>());
            builder.Services.TryAdd(ServiceDescriptor.Singleton<ISqlConnectionFactory, MsSqlConnectionFactory>());

            builder.Services.TryAdd(
                new ServiceDescriptor(
                    typeof(RuntimeSqlDatabaseConfigurationFor<T>),
                    serviceProvider =>
                    {
                        var configBuilder = new RuntimeSqlDatabaseConfigurationBuilder(new RuntimeSqlDatabaseConfiguration());
                        builder.SchemaMetadata.Use(builder.Environment.Metadata);

                        builder.QueryExpressions.Use(serviceProvider.GetService<IQueryExpressionFactory>());

                        builder.Entities
                            .Creation.Use(serviceProvider.GetService<IEntityFactory>())
                            .Mapping.Use(serviceProvider.GetService<IMapperFactory>());

                        builder.Conversions.Use(serviceProvider.GetService<IValueConverterFactory>());

                        builder.SqlStatements
                            .Assembly
                                .StatementBuilder.Use(serviceProvider.GetService<ISqlStatementBuilderFactory>())
                                .StatementAppender.Use(serviceProvider.GetService<IAppenderFactory>())
                                .ElementAppender.Use(serviceProvider.GetService<IExpressionElementAppenderFactory>())
                                .ParameterBuilder.Use(serviceProvider.GetService<ISqlParameterBuilderFactory>())
                            .Execution
                                .Executor.Use(serviceProvider.GetService<ISqlStatementExecutorFactory>())
                                .Connection.Use(serviceProvider.GetService<ISqlConnectionFactory>())
                                .Pipeline.Use(serviceProvider.GetService<IExecutionPipelineFactory>());

                        configuration?.Invoke(serviceProvider, builder);

                        var config = (builder as IRuntimeSqlDatabaseConfigurationProvider).Configuration;
                        config.Validate();

                        return new RuntimeSqlDatabaseConfigurationFor<T>(
                            builder.Environment as T,
                            config
                        );
                    },
                    configurationLifetime
                )
            );

            builder.Services.AddSingleton(serviceProvider =>
            {
                return new RuntimeSqlDatabaseConfigurationDependencyInjectionShim(
                    builder.Environment.Database,
                    () => serviceProvider.GetRequiredService<RuntimeSqlDatabaseConfigurationFor<T>>().Configuration
                );
            });
        }
    }
}
