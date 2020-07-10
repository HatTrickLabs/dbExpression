﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class NullablePopulationStandardDeviationFunctionExpression<TValue> : NullablePopulationStandardDeviationFunctionExpression
         where TValue : IComparable
    {
        #region constructors
        protected NullablePopulationStandardDeviationFunctionExpression(ExpressionMediator expression, bool isDistinct) : base(expression, isDistinct)
        {
        }
        #endregion
    }
}