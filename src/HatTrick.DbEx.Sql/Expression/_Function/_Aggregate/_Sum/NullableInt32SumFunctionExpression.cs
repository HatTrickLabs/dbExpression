using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableInt32SumFunctionExpression :
        NullableSumFunctionExpression<int,int?>,
        NullInt32Element,
        AnyInt32Element,
        IEquatable<NullableInt32SumFunctionExpression>
    {
        #region constructors
        public NullableInt32SumFunctionExpression(NullByteElement expression, bool isDistinct) : base(expression, typeof(byte?), isDistinct)
        {

        }

        public NullableInt32SumFunctionExpression(NullInt16Element expression, bool isDistinct) : base(expression, typeof(byte?), isDistinct)
        {

        }

        public NullableInt32SumFunctionExpression(NullInt32Element expression, bool isDistinct) : base(expression, typeof(byte?), isDistinct)
        {

        }

        protected NullableInt32SumFunctionExpression(IExpressionElement expression, bool isDistinct, string alias) : base(expression, typeof(byte?), isDistinct, alias)
        {

        }
        #endregion

        #region as
        public NullInt32Element As(string alias)
            => new NullableInt32SumFunctionExpression(base.Expression, base.IsDistinct, alias);
        #endregion

        #region equals
        public bool Equals(NullableInt32SumFunctionExpression obj)
            => obj is NullableInt32SumFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableInt32SumFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
