using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class ByteExpressionMediator :
        ExpressionMediator<byte>,
        IEquatable<ByteExpressionMediator>
    {
        #region constructors
        private ByteExpressionMediator()
        {
        }

        public ByteExpressionMediator(IExpression expression) : base(expression)
        {
        }
        #endregion

        #region as
        public new ByteExpressionMediator As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(ByteExpressionMediator obj)
            => obj is ByteExpressionMediator && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is ByteExpressionMediator exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
