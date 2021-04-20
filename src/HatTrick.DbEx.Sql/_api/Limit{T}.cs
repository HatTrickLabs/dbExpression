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

namespace HatTrick.DbEx.Sql
{
#pragma warning disable IDE1006 // Naming Styles
    public interface Limit<TCaller>
#pragma warning restore IDE1006 // Naming Styles
    {
        /// <summary>
        /// Specify the maximum number of records to return for a SELECT query expression.
        /// </summary>
        /// <remarks>If a Offset operation was specified for the SELECT query expression, the <paramref name="value"/> does not begin until ignoring the offset number of records specified.</remarks>
        /// <param name="value">The maximum number of records to return.</param>
        /// <returns><see cref="{TCaller}"/>, a fluent continuation for the construction of a sql SELECT query expression.</returns>
        TCaller Limit(int value);

        /// <summary>
        /// Construct the HAVING clause of a sql SELECT query expression.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/select-having-transact-sql">Microsoft docs on HAVING</see>
        /// </para>
        /// </summary>
        /// <param name="having">A list of expressions of type <see cref="AnyHavingClause"/> specifying conditions on the grouping or aggregation of selected results.</param>
        /// <returns><see cref="{TCaller}"/>, a fluent continuation for the construction of a sql SELECT query expression.</returns>
        TCaller Having(AnyHavingClause having);
    }
}