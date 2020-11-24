﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class AverageFunctionExpression<TValue> : AverageFunctionExpression,
        IExpressionElement<TValue>
        where TValue : IComparable
    {
        #region constructors
        protected AverageFunctionExpression(IExpressionElement expression) : base(expression, typeof(TValue))
        {

        }
        #endregion
    }
}
