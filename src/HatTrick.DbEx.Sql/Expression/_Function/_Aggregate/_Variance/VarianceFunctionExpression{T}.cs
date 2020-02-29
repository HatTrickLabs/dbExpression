﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class VarianceFunctionExpression<TValue> : VarianceFunctionExpression
        where TValue : IComparable
    {
        #region constructors
        protected VarianceFunctionExpression(ExpressionContainer expression, bool isDistinct) : base(expression, isDistinct)
        {
        }
        #endregion
    }
}
