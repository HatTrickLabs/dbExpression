﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class ExpressionMediator<TValue> : ExpressionMediator
    {
        #region constructors
        protected ExpressionMediator()
        {
        }

        public ExpressionMediator(IExpression expression) : base(expression)
        {
        }
        #endregion
    }
}
