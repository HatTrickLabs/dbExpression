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

﻿using HatTrick.DbEx.Sql.Attribute;
using HatTrick.DbEx.Sql.Expression;
using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Attribute
{
    public static class ConditionalExpressionOperatorAttributeExtensions
    {
        public static string GetConditionalOperator(this ConditionalExpressionOperator value)
        {
            return value.GetStringFromEnum<ConditionalExpressionOperator, ExpressionOperatorAttribute>(a => a.Operator);
        }

        public static ConditionalExpressionOperator? GetConditionalOperator(this string value)
        {
            return value?.GetEnumFromString<ConditionalExpressionOperator, ExpressionOperatorAttribute>(a => a.Operator);
        }

        public static SortedDictionary<ConditionalExpressionOperator, string?> GetValuesAndConditionalOperators(this Type type, Func<string, string>? formatValue = null)
        {
            if (formatValue is null)
                return type.GetEnumAsSortedDictionary<ConditionalExpressionOperator>(op => GetConditionalOperator(op));
            return type.GetEnumAsSortedDictionary<ConditionalExpressionOperator>(op => { var s = GetConditionalOperator(op); return formatValue?.Invoke(s); });
        }
    }
}