﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class ByteFloorFunctionExpression : 
        FloorFunctionExpression<byte>,
        ByteElement,
        AnyByteElement,
        IEquatable<ByteFloorFunctionExpression>
    {
        #region constructors
        public ByteFloorFunctionExpression(ByteElement expression) : base(expression)
        { 
        
        }

        protected ByteFloorFunctionExpression(IExpressionElement expression, string alias) : base(expression, alias)
        {

        }
        #endregion

        #region as
        public ByteElement As(string alias)
            => new ByteFloorFunctionExpression(base.Expression, alias);
        #endregion

        #region equals
        public bool Equals(ByteFloorFunctionExpression obj)
            => obj is ByteFloorFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is ByteFloorFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
