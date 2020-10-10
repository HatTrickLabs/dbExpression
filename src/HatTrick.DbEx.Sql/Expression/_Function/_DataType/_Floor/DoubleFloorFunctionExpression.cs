﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class DoubleFloorFunctionExpression :
        FloorFunctionExpression<double>,
        IEquatable<DoubleFloorFunctionExpression>
    {
        #region constructors
        public DoubleFloorFunctionExpression(ExpressionMediator<double> expression) : base(expression)
        {

        }
        #endregion

        #region as
        public new DoubleFloorFunctionExpression As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(DoubleFloorFunctionExpression obj)
            => obj is DoubleFloorFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is DoubleFloorFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}