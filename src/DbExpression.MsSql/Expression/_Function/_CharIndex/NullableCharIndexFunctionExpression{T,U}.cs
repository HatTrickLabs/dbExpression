#region license
// Copyright (c) dbExpression.  All rights reserved.
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
// The latest version of this file can be found at https://github.com/dbexpression-team/dbexpression
#endregion

﻿using System;
using System.Collections.Generic;
using DbExpression.Sql;
using DbExpression.Sql.Expression;

namespace DbExpression.MsSql.Expression
{
    public abstract class NullableCharIndexFunctionExpression<TValue, TNullableValue> : CharIndexFunctionExpression,
        IExpressionElement<TValue, TNullableValue>,
        AnyElement<TNullableValue>
        where TValue : IComparable
    {
        #region constructors
        protected NullableCharIndexFunctionExpression(IExpressionElement pattern, IExpressionElement expression) : base(pattern, expression, typeof(TNullableValue))
        {

        }

        protected NullableCharIndexFunctionExpression(IExpressionElement pattern, IExpressionElement expression, IExpressionElement startSearchPosition) : base(pattern, expression, startSearchPosition, typeof(TNullableValue))
        {

        }
        #endregion

        #region in
        public FilterExpression In(params TNullableValue[] values)
           => new FilterExpression<bool>(this, new InExpression<TNullableValue>(this, values), FilterExpressionOperator.None);

        public FilterExpression In(IEnumerable<TNullableValue> values)
            => new FilterExpression<bool>(this, new InExpression<TNullableValue>(this, values), FilterExpressionOperator.None);
        #endregion

        #region as
        public AliasedElement<TNullableValue> As(string alias)
            => new SelectExpression<TNullableValue>(this, alias);
        #endregion
    }
}