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

﻿using HatTrick.DbEx.MsSql.Microsoft.Extensions.DependencyInjection.Builder;
using HatTrick.DbEx.Sql.Configuration;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDbExpression(this IServiceCollection services, params Action<IDbExpressionConfigurationBuilder>[] databases)
        {
            foreach (var database in databases)
                database.Invoke(new ServiceCollectionRuntimeSqlDatabaseConfigurationBuilder(services, new RuntimeSqlDatabaseConfiguration()));
        }
    }
}