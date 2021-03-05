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

﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class ExpressionMediator : 
        AnyElement,
        IFilterExpressionElement,
        AnyOrderByClause,
        AnyGroupByClause,
        IExpressionTypeProvider,
        IEquatable<ExpressionMediator>
    {
        #region internals
        private Type declaredType;
        #endregion

        #region interface
        public IExpressionElement Expression { get; set; }
        Type IExpressionTypeProvider.DeclaredType => declaredType;
        #endregion

        #region constructors
        protected ExpressionMediator()
        {
        }

        protected ExpressionMediator(IExpressionElement expression, Type declaredType) : this(expression, declaredType, null)
        {

        }

        protected ExpressionMediator(IExpressionElement expression, Type declaredType, string alias)
        {
            Expression = expression ?? throw new ArgumentNullException(nameof(expression));
            this.declaredType = declaredType ?? throw new ArgumentNullException(nameof(declaredType));
        }
        #endregion

        #region order
        public virtual OrderByExpression Asc => new OrderByExpression(this, OrderExpressionDirection.ASC);
        public virtual OrderByExpression Desc => new OrderByExpression(this, OrderExpressionDirection.DESC);
        #endregion

        #region tostring
        public override string ToString() => Expression?.ToString();
        #endregion

        #region equals
        public bool Equals(ExpressionMediator obj)
        {
            if (obj is null) return false;

            if (Expression is null && obj.Expression is object) return false;
            if (Expression is object && obj.Expression is null) return false;
            if (!Expression.Equals(obj.Expression)) return false;

            if (declaredType != obj.declaredType) return false;

            return true;
        }

        public override bool Equals(object obj)
            => obj is ExpressionMediator exp && Equals(exp);

        public override int GetHashCode()
        {
            unchecked
            {
                const int @base = (int)2166136261;
                const int multiplier = 16777619;

                int hash = @base;
                hash = (hash * multiplier) ^ (Expression is object ? Expression.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (declaredType is object ? declaredType.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion

        #region implicit operators
        public static implicit operator OrderByExpression(ExpressionMediator a) => new OrderByExpression(a, OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(ExpressionMediator a) => new GroupByExpression(a);
        #endregion
    }
}
