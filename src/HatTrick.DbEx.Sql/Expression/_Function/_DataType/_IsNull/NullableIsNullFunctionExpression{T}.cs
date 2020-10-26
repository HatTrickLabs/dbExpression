﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class NullableIsNullFunctionExpression<TValue> : NullableIsNullFunctionExpression
         where TValue : IComparable
    {
        #region constructors
        protected NullableIsNullFunctionExpression(ExpressionMediator<TValue> expression, ExpressionMediator<TValue> value) : base(expression, value)
        {
        }
        #endregion
    }
}
