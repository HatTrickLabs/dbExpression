﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class DateDiffFunctionExpression<TValue> : DateDiffFunctionExpression,
        IExpressionElement<TValue>
        where TValue : IComparable
    {
        #region constructors
        protected DateDiffFunctionExpression(DatePartsExpression datePart, IExpressionElement startDate, IExpressionElement endDate)
            : base(datePart, startDate, endDate, typeof(TValue))
        {

        }
        #endregion
    }
}
