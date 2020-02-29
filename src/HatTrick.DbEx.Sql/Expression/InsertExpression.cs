﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class InsertExpression :
        IDbExpression
    {
        #region internals
        public ExpressionContainerPair Expression { get; private set; }
        #endregion

        #region constructors
        public InsertExpression(FieldExpression field, object value, Type type)
        {
            Expression = new ExpressionContainerPair(new ExpressionContainer(field ?? throw new ArgumentNullException($"{nameof(field)} is required.")), new ExpressionContainer(value ?? DBNull.Value, value == null ? typeof(DBNull) : type));
        }
        #endregion

        #region logical & operator
        public static InsertExpressionSet operator &(InsertExpression a, InsertExpression b) => new InsertExpressionSet(a, b);
        #endregion

        #region implicit insert expression set operator
        public static implicit operator InsertExpressionSet(InsertExpression a) => new InsertExpressionSet(a);
        #endregion
    }    
}
