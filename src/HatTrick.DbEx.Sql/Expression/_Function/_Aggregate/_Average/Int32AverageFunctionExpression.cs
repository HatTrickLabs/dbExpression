using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class Int32AverageFunctionExpression :
        AverageFunctionExpression<int>,
        Int32Element,
        AnyInt32Element,
        IEquatable<Int32AverageFunctionExpression>
    {
        #region constructors
        public Int32AverageFunctionExpression(ByteElement expression, bool isDistinct) : base(expression, isDistinct)
        {

        }

        public Int32AverageFunctionExpression(Int16Element expression, bool isDistinct) : base(expression, isDistinct)
        {

        }

        public Int32AverageFunctionExpression(Int32Element expression, bool isDistinct) : base(expression, isDistinct)
        {

        }

        protected Int32AverageFunctionExpression(IExpressionElement expression, bool isDistinct, string alias) : base(expression, isDistinct, alias)
        {

        }
        #endregion

        #region as
        public Int32Element As(string alias)
            => new Int32AverageFunctionExpression(base.Expression, base.IsDistinct, alias);
        #endregion

        #region equals
        public bool Equals(Int32AverageFunctionExpression obj)
            => obj is Int32AverageFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is Int32AverageFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
