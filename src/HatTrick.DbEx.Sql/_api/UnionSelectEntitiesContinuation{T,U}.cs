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

using HatTrick.DbEx.Sql.Builder;

namespace HatTrick.DbEx.Sql
{
#pragma warning disable IDE1006 // Naming Styles
    public interface UnionSelectEntitiesContinuation<TDatabase, TEntity> :
#pragma warning restore IDE1006 // Naming Styles
        IExpressionBuilder<TDatabase>
        where TDatabase : class, ISqlDatabaseRuntime
        where TEntity : class, IDbEntity, new()
    {
        /// <summary>
        /// Continue a sql SELECT query expression for a list of entities.
        /// <para>
        /// <see href="https://dbexpression.com/docs/core-concepts/basics/select-statement">read the docs on SELECT</see>
        /// </para>
        /// </summary>
        /// <returns><see cref="SelectEntities{TDatabase, TEntity}"/>, a fluent builder for constructing a sql SELECT query expression for a <typeparamref name="TEntity"/> entity.</returns>
        /// <typeparam name="TEntity">The entity type to select.</typeparam>
        SelectEntities<TDatabase, TEntity> SelectOne();

        /// <summary>
        /// Continue a sql SELECT query expression for a list of entities.
        /// <para>
        /// <see href="https://dbexpression.com/docs/core-concepts/basics/select-statement">read the docs on SELECT</see>
        /// </para>
        /// </summary>
        /// <returns><see cref="SelectEntities{TDatabase, TEntity}"/>, a fluent builder for constructing a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        /// <typeparam name="TEntity">The entity type to select.</typeparam>
        SelectEntities<TDatabase, TEntity> SelectMany();
    }
}
