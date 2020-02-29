﻿namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class NullableDateAddFunctionExpression : DateAddFunctionExpression
    {
        #region constructors
        protected NullableDateAddFunctionExpression(ExpressionContainer datePart, ExpressionContainer value, ExpressionContainer expression) : base(datePart, value, expression)
        {
        }
        #endregion
    }
}
