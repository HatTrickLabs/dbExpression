using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class Int64IsNullFunctionExpression :
        IsNullFunctionExpression<long>,
        Int64Element,
        AnyInt64Element,
        IEquatable<Int64IsNullFunctionExpression>
    {
        #region constructors
        public Int64IsNullFunctionExpression(AnyInt64Element expression, Int64Element value) : base(expression, value)
        {

        }

        protected Int64IsNullFunctionExpression(IExpressionElement expression, IExpressionElement value, string alias) : base(expression, value, alias)
        {

        }
        #endregion

        #region as
        public Int64Element As(string alias)
            => new Int64IsNullFunctionExpression(base.Expression, base.Value, alias);
        #endregion

        #region equals
        public bool Equals(Int64IsNullFunctionExpression obj)
            => obj is Int64IsNullFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is Int64IsNullFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
