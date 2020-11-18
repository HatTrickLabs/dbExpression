using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableInt32MaximumFunctionExpression :
        NullableMaximumFunctionExpression<int,int?>,
        NullInt32Element,
        AnyInt32Element,
        IEquatable<NullableInt32MaximumFunctionExpression>
    {
        #region constructors
        public NullableInt32MaximumFunctionExpression(NullInt32Element expression, bool isDistinct) 
            : base(expression, isDistinct)
        {

        }
        protected NullableInt32MaximumFunctionExpression(IExpressionElement expression, bool isDistinct, string alias) 
            : base(expression, isDistinct, alias)
        {

        }
        #endregion

        #region as
        public NullInt32Element As(string alias)
            => new NullableInt32MaximumFunctionExpression(base.Expression, base.IsDistinct, alias);
        #endregion

        #region equals
        public bool Equals(NullableInt32MaximumFunctionExpression obj)
            => obj is NullableInt32MaximumFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableInt32MaximumFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
