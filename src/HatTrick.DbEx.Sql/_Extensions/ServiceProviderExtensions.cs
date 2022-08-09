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

using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Connection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HatTrick.DbEx.Sql
{
    public static class ServiceProviderExtensions
    {
        public static void UseStaticRuntimeFor<TDatabase>(this IServiceProvider provider)
            where TDatabase : class, ISqlDatabaseRuntime
        {
            var databases = provider.GetRequiredService<RegisteredSqlDatabaseRuntimeTypes>();
            var database = databases.SingleOrDefault(x => x == typeof(TDatabase));
            if (database is null)
                throw new DbExpressionConfigurationException($"The database {typeof(TDatabase)} has not been added to services, ensure the database has been added to the service collection via {nameof(ServiceCollectionExtensions.AddDbExpression)}.");

            provider.InitializeStaticRuntime(database);
        }

        internal static void InitializeStaticRuntimes(this IServiceProvider provider)
        {
            var databases = provider.GetRequiredService<RegisteredSqlDatabaseRuntimeTypes>();
            foreach (var database in databases)
            {
                provider.InitializeStaticRuntime(database);
            }
        }

        private static void InitializeStaticRuntime(this IServiceProvider provider, Type database)
        {
            var factoryType = typeof(SingletonSqlDatabaseRuntimeFactory<>).MakeGenericType(new[] { database });
            var factory = provider.GetService(factoryType) as SingletonSqlDatabaseRuntimeFactory;

            ISqlDatabaseRuntime? runtime = factory!.GetInstance();
            if (runtime is not null)
            {
                try
                {
                    runtime.InitializeStaticRuntime();
                    return;
                }
                catch (Exception e)
                {
                    throw new DbExpressionException($"The database {database} could not be initialized, see inner exception for details.", e);
                }
            }

            //There are defaults for all configuration except connection strings.  Likely with this exception there is no connection string factory.
            //As this is in startup, and an exception will be thrown either way, try and resolve a connection string to see if a better error message
            //can be returned/thrown.
            var connectionStringFactoryType = typeof(IConnectionStringFactory<>).MakeGenericType(database);
            if (provider.GetService(connectionStringFactoryType) is null)
            throw new DbExpressionConfigurationException($"Initialization of runtime database {database} failed.  " +
                $"A connection string factory has not been properly registered.  Please ensure a connection string, or a delegate providing a connection string, has been provided in configuration.");

            throw new DbExpressionConfigurationException($"Initialization of runtime database {database} failed as one or more dependencies could not be resolved.");
        }
    }
}
