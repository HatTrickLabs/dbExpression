﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class NullableMaximumFunctionExpression<TValue> : NullableMaximumFunctionExpression
        where TValue : IComparable
    {
        #region constructors
        protected NullableMaximumFunctionExpression(ExpressionContainer expression, bool isDistinct) : base(expression, isDistinct)
        {
        }
        #endregion
    }
}
