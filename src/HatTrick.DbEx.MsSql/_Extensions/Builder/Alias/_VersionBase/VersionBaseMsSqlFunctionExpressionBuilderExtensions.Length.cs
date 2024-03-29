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

using HatTrick.DbEx.MsSql.Builder;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Expression;
using System;

namespace HatTrick.DbEx.MsSql.Builder.Alias
{
    public static partial class VersionBaseMsSqlFunctionExpressionBuilderExtensions
    {
        /// <summary>
        /// Construct an expression for the LEN transact sql function.
        /// <para><see href="https://dbexpression.com/rtd/reference/mssql/functions/string/len">read the docs on LEN</see></para>
        /// </summary>
        /// <param name="element">An alias of an expression for determining the number of characters, excluding trailing spaces.</param>
        /// <returns><see cref="Int64LengthFunctionExpression"/> for use with any operation accepting a <see cref="AnyElement{Int64}"/>.</returns>
        public static NullableInt64LengthFunctionExpression Len(this VersionBaseMsSqlFunctionExpressionBuilder _, (string TableName, string FieldName) element)
            => new(new AliasExpression<string?>(element));        
    }
}