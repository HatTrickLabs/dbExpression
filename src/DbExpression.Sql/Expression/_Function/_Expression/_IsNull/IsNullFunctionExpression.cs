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

namespace DbExpression.Sql.Expression
{
    public abstract class IsNullFunctionExpression : ExpressionFunctionExpression,
        IExpressionListProvider<IExpressionElement>,
        IEquatable<IsNullFunctionExpression>
    {
        #region internals
        private readonly IExpressionElement checkExpression;
        private readonly IExpressionElement replacementValue;
        #endregion

        #region interface
        IEnumerable<IExpressionElement> IExpressionListProvider<IExpressionElement>.Expressions => new List<IExpressionElement>() { checkExpression, replacementValue };
        #endregion

        #region constructors
        protected IsNullFunctionExpression(IExpressionElement expression, Type declaredType, IExpressionElement value) : base(declaredType)
        {
            checkExpression = expression ?? throw new ArgumentNullException(nameof(expression));
            replacementValue = value ?? throw new ArgumentNullException(nameof(value));
        }
        #endregion

        #region to string
        public override string? ToString() => $"ISNULL({checkExpression}, {replacementValue})";
        #endregion

        #region equals
        public bool Equals(IsNullFunctionExpression? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            if (checkExpression is null && obj.checkExpression is not null) return false;
            if (checkExpression is not null && obj.checkExpression is null) return false;
            if (checkExpression is not null && !checkExpression.Equals(obj.checkExpression)) return false;

            if (replacementValue is null && obj.replacementValue is not null) return false;
            if (replacementValue is not null && obj.replacementValue is null) return false;
            if (replacementValue is not null && !replacementValue.Equals(obj.replacementValue)) return false;

            return true;
        }

        public override bool Equals(object? obj)
         => obj is IsNullFunctionExpression exp && Equals(exp);

        public override int GetHashCode()
        {
            unchecked
            {
                const int multiplier = 16777619;

                int hash = base.GetHashCode();
                hash = (hash * multiplier) ^ (checkExpression is not null ? checkExpression.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (replacementValue is not null ? replacementValue.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion
    }
}
