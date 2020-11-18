using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableInt32IsNullFunctionExpression :
        NullableIsNullFunctionExpression<int,int?>,
        NullInt32Element,
        AnyInt32Element,
        IEquatable<NullableInt32IsNullFunctionExpression>
    {
        #region constructors
        public NullableInt32IsNullFunctionExpression(AnyInt32Element expression, NullInt32Element value)
            : base(expression, value)
        {

        }

        protected NullableInt32IsNullFunctionExpression(IExpressionElement expression, IExpressionElement value, string alias)
            : base(expression, value, alias)
        {

        }
        #endregion

        #region as
        public NullInt32Element As(string alias)
            => new NullableInt32IsNullFunctionExpression(base.Expression, base.Value, alias);
        #endregion

        #region equals
        public bool Equals(NullableInt32IsNullFunctionExpression obj)
            => obj is NullableInt32IsNullFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableInt32IsNullFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
