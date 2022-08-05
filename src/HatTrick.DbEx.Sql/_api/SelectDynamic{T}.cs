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

using System.Dynamic;

namespace HatTrick.DbEx.Sql
{
#pragma warning disable IDE1006 // Naming Styles
    public interface SelectDynamic<TDatabase>
#pragma warning restore IDE1006 // Naming Styles
        where TDatabase : class, ISqlDatabaseRuntime
    {
        /// <summary>
        /// Construct the FROM clause of a sql SELECT query expression for a single <typeparamref name="dynamic"/> value.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/from-transact-sql">Microsoft docs on FROM</see>
        /// </para>
        /// </summary>
        /// <returns><see cref="SelectDynamicContinuation{TDatabase}"/>, a fluent continuation for the construction of a sql SELECT query expression for a single <typeparamref name="dynamic"/> value.</returns>
        SelectDynamicContinuation<TDatabase> From<TEntity>(Table<TEntity> entity)
            where TEntity : class, IDbEntity;

        /// <summary>
        /// Construct the FROM clause of a sql SELECT query expression for a list of <typeparamref name="dynamic"/> values.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/from-transact-sql">Microsoft docs on FROM</see>
        /// </para>
        /// </summary>
        /// <returns><see cref="WithAlias{SelectDynamicContinuation{TDatabase}}"/>, a fluent continuation for providing an alias for the subquery.</returns>
        WithAlias<SelectDynamicContinuation<TDatabase>> From(AnySelectSubquery query);
    }
}