﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class OrderByExpression : DbExpression
    {
        #region interface
        public (Type,object) Expression { get; private set; }
        public OrderExpressionDirection Direction { get; private set; }
        #endregion

        #region constructors
        internal OrderByExpression(FieldExpression field, OrderExpressionDirection direction)
        {
            Expression = (typeof(FieldExpression),field);
            Direction = direction;
        }

        internal OrderByExpression(IDbExpression expression, OrderExpressionDirection direction)
        {
            Expression = (expression.GetType(), expression);
            Direction = direction;
        }
        #endregion

        #region to string
        public override string ToString() => $"{Expression.Item2} {Direction}";
        #endregion

        #region conditional & operator
        public static OrderByExpressionSet operator &(OrderByExpression a, OrderByExpression b) => new OrderByExpressionSet(a, b);
        #endregion

        #region implicit order by expression set operator
        public static implicit operator OrderByExpressionSet(OrderByExpression a) => new OrderByExpressionSet(a);
        #endregion
    }
    
}
