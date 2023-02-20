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
// The latest platformVersion of this file can be found at https://github.com/HatTrickLabs/db-ex
#endregion

using HatTrick.DbEx.MsSql.Assembler;
using HatTrick.DbEx.MsSql.Builder;
using HatTrick.DbEx.MsSql.Connection;
using HatTrick.DbEx.MsSql.Types;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Attribute;
using HatTrick.DbEx.Sql.Builder;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Connection;
using HatTrick.DbEx.Sql.Converter;
using HatTrick.DbEx.Sql.Executor;
using HatTrick.DbEx.Sql.Expression;
using HatTrick.DbEx.Sql.Mapper;
using HatTrick.DbEx.Sql.Pipeline;
using HatTrick.DbEx.Sql.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using MsSqlServices = HatTrick.DbEx.MsSql.Configuration.SqlDatabaseRuntimeServiceBuilderExtensions;

namespace HatTrick.DbEx.MsSql.Configuration
{
    public static partial class SqlDatabaseRuntimeServiceBuilderExtensions
    {
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        public static void AddDatabase<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));
#if NET7_0_OR_GREATER
            var platformVersion = TDatabase.PlatformVersion;
#else
            var platformVersion = typeof(TDatabase).GetCustomAttribute<PlatformVersionAttribute>()!.PlatformVersion!;
#endif

            builder.AddDatabase(configureRuntime, platformVersion!);
        }

        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <param name="platformVersionOverride">Provide a supported platform platformVersion (i.e. "2008", "2019", etc.) if your runtime should use a different Microsoft SQL Server platformVersion 
        /// than the platformVersion used in code scaffolding.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        internal static void AddDatabase<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime, string platformVersionOverride)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            switch (platformVersionOverride)
            {
                case "2005": builder.AddMsSql2005Database<TDatabase>(configureRuntime); break;
                case "2008": builder.AddMsSql2008Database<TDatabase>(configureRuntime); break;
                case "2012": builder.AddMsSql2012Database<TDatabase>(configureRuntime); break;
                case "2014": builder.AddMsSql2014Database<TDatabase>(configureRuntime); break;
                case "2016": builder.AddMsSql2016Database<TDatabase>(configureRuntime); break;
                case "2017": builder.AddMsSql2017Database<TDatabase>(configureRuntime); break;
                case "2019": builder.AddMsSql2019Database<TDatabase>(configureRuntime); break;
                case "2022": builder.AddMsSql2022Database<TDatabase>(configureRuntime); break;
                default: throw new NotImplementedException($"MsSql platformVersion {platformVersionOverride} has not been implemented.  Ensure you have provided a supported platformVersion in the Platform property of your scaffolding configuration (see https://dbexpression.com/mssql/platformVersions).");
            };
        }

        #region 2005
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2005 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2005Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2005.MsSqlFunctionExpressionBuilder>(b =>
            {
                configureRuntime.Invoke(b);
                b.SqlStatements.Assembly.ElementAppender.ForElementTypes(x => x
                    .ForElementType<InsertQueryExpression>().Use<HatTrick.DbEx.MsSql.Assembler.v2005.MsSqlInsertQueryExpressionAppender>()
                    .ForElementType<SelectQueryExpression>().Use<HatTrick.DbEx.MsSql.Assembler.v2005.MsSqlSelectQueryExpressionAppender>()
                );
            });
        }
        #endregion

        #region 2008
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2008 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2008Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2008.MsSqlFunctionExpressionBuilder>(b =>
            {
                configureRuntime.Invoke(b);
                b.SqlStatements.Assembly.ElementAppender.ForElementTypes(x => x
                    .ForElementType<SelectQueryExpression>().Use<HatTrick.DbEx.MsSql.Assembler.v2008.MsSqlSelectQueryExpressionAppender>()
                );
            });
        }
        #endregion

        #region 2012
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2012 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2012Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2012.MsSqlFunctionExpressionBuilder>(configureRuntime);
        }
        #endregion

        #region 2014
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2014 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2014Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2014.MsSqlFunctionExpressionBuilder>(configureRuntime);
        }
        #endregion

        #region 2016
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2016 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2016Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2016.MsSqlFunctionExpressionBuilder>(configureRuntime);
        }
        #endregion

        #region 2017
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2017 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2017Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2017.MsSqlFunctionExpressionBuilder>(configureRuntime);
        }
        #endregion

        #region 2019
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2019 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2019Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2019.MsSqlFunctionExpressionBuilder>(configureRuntime);
        }
        #endregion

        #region 2022
        /// <summary>
        /// Configures <typeparamref name="TDatabase"/> as a Microsoft Sql Server 2022 database for runtime use with dbExpression.
        /// </summary>
        /// <param name="builder">A <see cref="ISqlDatabaseRuntimeServicesBuilder" />, the fluent entry point for configuring the runtime environment for a database.</param>
        /// <param name="configureRuntime">A delegate to provide additional configuration of the runtime environment for the <typeparam name="TDatabase">database</typeparam>.</param>        
        /// <typeparam name="TDatabase">The database to configure.</typeparam>
        private static void AddMsSql2022Database<TDatabase>(this ISqlDatabaseRuntimeServicesBuilder builder, Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbRegistrar = builder as ISqlDatabaseRuntimeServicesRegistrar
                ?? throw new DbExpressionConfigurationException(ExceptionMessages.RegistrationBuilderType(builder.GetType(), typeof(ISqlDatabaseRuntimeServicesRegistrar)));

            dbRegistrar.Register<TDatabase>().AddMsSqlCommon<TDatabase, Builder.v2022.MsSqlFunctionExpressionBuilder>(configureRuntime);
        }
        #endregion

        #region common
        private static void AddMsSqlCommon<TDatabase,TFunctionBuilder>(
            this SqlDatabaseRuntimeRegistrar registrar,
            Action<ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>> configureRuntime
        )
            where TDatabase : class, ISqlDatabaseRuntime
            where TFunctionBuilder : class
        {
            if (registrar is null)
                throw new ArgumentNullException(nameof(registrar));

            if (configureRuntime is null)
                throw new ArgumentNullException(nameof(configureRuntime));

            var dbServices = new TinyIoCServiceCollection<TDatabase>();
            var builder = new MsSqlSqlDatabaseRuntimeConfigurationBuilder<TDatabase>(dbServices);
            var dbServicesBuilder = builder as ISqlDatabaseRuntimeConfigurationBuilder<TDatabase>;

            try
            {
                configureRuntime.Invoke(dbServicesBuilder);
            }
            catch (Exception e)
            {
                throw new DbExpressionConfigurationException(ExceptionMessages.ServiceRegistration(typeof(TDatabase), typeof(ISqlDatabaseRuntime)), e);
            }            

            //begin registrations using builder
            dbServicesBuilder.QueryExpressions.UseDefaultQueryExpressionFactoryWithDefaults();

            dbServicesBuilder.Entities
                .UseDefaultEntityFactoryWithDiscovery()
                .UseDefaultMapperFactoryWithDiscovery();

            dbServicesBuilder.Conversions.UseDefaultValueConverterFactoryWithDiscoveryWithDefaults();

            dbServicesBuilder.SqlStatements
                .UseDefaultExpressionElementAppenderFactoryWithDefaults()
                .UseDelegateQueryExecutionPipelineFactoryWithDefaults()
                .Assembly
                    .StatementBuilder.Use<SqlStatementBuilder>()
                    .StatementAppender.Use<Appender>()
                .ParameterBuilder.Use<MsSqlParameterBuilder>()
                .QueryExecution
                    .Connection.Use<MsSqlConnectionFactory>();
            //end registrations using builder


            builder.Build();

            //begin direct registrations in database service collection

            //use a singleton statement executor, config builder registers transient
            dbServices.TryAddSingleton<TFunctionBuilder>();
            dbServices.TryAddSingleton<ISqlStatementExecutor, SqlStatementExecutor>();
            dbServices.TryAddSingleton<SqlStatementAssemblyOptions>();
            dbServices.TryAddSingleton<LoggingOptions>();
            dbServices.TryAddSingleton<IDbTypeMapFactory<SqlDbType>, MsSqlTypeMapFactory>();
            dbServices.TryAddSingleton<IMsSqlQueryExpressionBuilderFactory<TDatabase>, MsSqlQueryExpressionBuilderFactory<TDatabase>>();
            dbServices.TryAddTransient<AssemblyContext>(sp => sp.GetRequiredService<SqlStatementAssemblyOptions>().ToAssemblyContext());
            dbServices.TryAddSingleton<PipelineEventSubscriptions>();
            dbServices.TryAddSingleton<IExpandoObjectMapper, ExpandoObjectMapper>();
            dbServices.TryAddSingleton<ISqlDatabaseMetadataProvider>(sp => sp.GetRequiredService<TDatabase>().MetadataProvider);

            //begin direct registrations in root service collection
            registrar.Services.TryAddSingleton<ILoggerFactory, NullLoggerFactory>();
            registrar.Services.TryAddSingleton(typeof(ILogger<>), typeof(NullLogger<>));
            registrar.Services.AddSingleton<TDatabase>(sp =>
                {
                    try
                    {
                        var logger = sp.GetService<ILogger<TDatabase>>();

                        var db = (TDatabase)Activator.CreateInstance(
                            typeof(TDatabase),
                            sp.GetServiceProviderFor<TDatabase>().GetRequiredService<IMsSqlQueryExpressionBuilderFactory<TDatabase>>(),
                            sp.GetServiceProviderFor<TDatabase>().GetRequiredService<IDbConnectionFactory>(),
                            sp.GetServiceProviderFor<TDatabase>().GetRequiredService<TFunctionBuilder>()
                        )!;

                        if (typeof(SqlDatabaseRuntimeServiceBuilderExtensions).Assembly.TryGetPackageVersionFromInformationalVersionAttribute(out string? thisPackageVersion))
                            db.ValidateRuntimeCompatibility(thisPackageVersion!);

                        if (logger is not null)
                            logger.LogInformation("{database} is ready for use with dbExpression.", typeof(TDatabase).Name);

                        return db;
                    }
                    catch (Exception e)
                    {
                        Exception? ex = null;
                        try
                        {
                            ex = FindDbExpressionException(e);
                        }
                        catch { }
                        if (ex is not null)
                            throw ex;

                        //There are defaults for all configuration except connection strings.  Likely with this exception there is no connection string factory.
                        //As this is in startup, and an exception will be thrown either way, try and resolve a connection string to see if a better error message
                        //can be returned/thrown.
                        if (sp.GetServiceProviderFor<TDatabase>().GetService(typeof(IConnectionStringFactory)) is null)
                            throw new DbExpressionConfigurationException(ExceptionMessages.ServiceResolution<TDatabase>(), e);

                        throw new DbExpressionConfigurationException(ExceptionMessages.ServiceResolution<TDatabase>(), e);
                    }
                }
            );
            registrar.Services.AddSingleton<IServiceProvider<TDatabase>>(sp => dbServices.BuildServiceProvider(sp));
        }

        public static IServiceProvider GetServiceProviderFor<TDatabase>(this IServiceProvider sp)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            return sp.GetService<IServiceProvider<TDatabase>>()!;
        }

        private static void UseDefaultQueryExpressionFactoryWithDefaults<TDatabase>(this IQueryExpressionFactoryConfigurationBuilder<TDatabase> builder)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            builder.Use(sp => new DefaultQueryExpressionFactoryWithDiscovery(
                    t =>
                    {
                        if (sp.IsRegisteredIn<TDatabase>(t))
                            return sp.GetService(t) as QueryExpression; //null returns are managed by the factory
                        return null;
                    }
                ),
                x => x.WithDefaults()
            );
        }

        private static IEntitiesConfigurationBuilderGrouping<TDatabase> UseDefaultEntityFactoryWithDiscovery<TDatabase>(this IEntitiesConfigurationBuilderGrouping<TDatabase> builder)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            builder.Creation.Use(sp => new DefaultEntityFactoryWithFallbackConstruction(
                    t =>
                    {
                        if (sp.IsRegisteredIn<TDatabase>(t))
                            return sp.GetService(t) as IDbEntity; //null returns are managed by the factory
                        return null;
                    }
                ) 
            );
            return builder;
        }

        private static IEntitiesConfigurationBuilderGrouping<TDatabase> UseDefaultMapperFactoryWithDiscovery<TDatabase>(this IEntitiesConfigurationBuilderGrouping<TDatabase> builder)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            builder.Mapping.Use(
                sp => new DefaultMapperFactoryWithDiscovery(
                    sp.GetRequiredService<ILogger<DefaultMapperFactoryWithDiscovery>>(),
                    t =>
                    {
                        if (sp.IsRegisteredIn<TDatabase>(t))
                            return sp.GetService(t) as IEntityMapper; //null returns are managed by the factory
                        return null;
                    },
                    () => sp.GetService<IExpandoObjectMapper>() 
                        ?? throw new DbExpressionConfigurationException(ExceptionMessages.ServiceResolution(typeof(IExpandoObjectMapper)))

                )
            );
            return builder;
        }

        private static void UseDefaultValueConverterFactoryWithDiscoveryWithDefaults<TDatabase>(this IValueConverterFactoryConfigurationBuilder<TDatabase> builder)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            builder.Use(sp => new DefaultValueConverterFactoryWithDiscovery(
                    sp.GetRequiredService<ILogger<DefaultValueConverterFactoryWithDiscovery>>(),
                    t =>
                    {
                        if (sp.IsRegisteredIn<TDatabase>(t))
                            return sp.GetService(t) as IValueConverter; //null returns are managed by the factory
                        return null;
                    }
                ),
                x => x.WithDefaults()
            );
        }

        private static ISqlStatementsConfigurationBuilderGrouping<TDatabase> UseDefaultExpressionElementAppenderFactoryWithDefaults<TDatabase>(this ISqlStatementsConfigurationBuilderGrouping<TDatabase> builder)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            builder.Assembly.ElementAppender.Use(sp => new DefaultExpressionElementAppenderFactoryWithDiscovery(
                    t =>
                    {
                        if (sp.IsRegisteredIn<TDatabase>(t))
                            return sp.GetService(t) as IExpressionElementAppender; //null returns are managed by the factory
                        return null;
                    }
                ),
                x => WithDefaults(x)
            );
            return builder;
        }

        private static ISqlStatementsConfigurationBuilderGrouping<TDatabase> UseDelegateQueryExecutionPipelineFactoryWithDefaults<TDatabase>(this ISqlStatementsConfigurationBuilderGrouping<TDatabase> builder)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            builder.Assembly.QueryExecution.Pipeline.Use(sp => new DefaultQueryExpressionExecutionPipelineFactory(
                t => sp.GetService(t) as IQueryExpressionExecutionPipeline
                        ?? throw new DbExpressionConfigurationException(ExceptionMessages.ServiceResolution(t))
                ),
                x => x.WithDefaults()
            );
            return builder;
        }

        private static DbExpressionException? FindDbExpressionException(Exception e)
        { 
            if (e is DbExpressionException ex)
                return ex;

            if (e.InnerException is not null)
                return FindDbExpressionException(e.InnerException);

            return null;
        }
        #endregion
    }
}
