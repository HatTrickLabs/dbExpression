﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class ConversionFunctionExpression : FunctionExpression
    {
        #region constructors
        protected ConversionFunctionExpression()
        { 
        
        }

        protected ConversionFunctionExpression(ExpressionMediator expression) : base(expression)
        {
        }
        #endregion
    }
}