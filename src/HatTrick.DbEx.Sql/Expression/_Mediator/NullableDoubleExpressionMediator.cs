using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableDoubleExpressionMediator :
        NullableExpressionMediator<double,double?>,
        NullDoubleElement,
        AnyDoubleElement,
        IEquatable<NullableDoubleExpressionMediator>
    {
        #region constructors
        private NullableDoubleExpressionMediator()
        {
        }

        public NullableDoubleExpressionMediator(IExpressionElement expression) : base(expression, typeof(double?))
        {
        }

        protected NullableDoubleExpressionMediator(IExpressionElement expression, string alias) : base(expression, typeof(double?), alias)
        {
        }
        #endregion

        #region as
        public NullDoubleElement As(string alias)
            => new NullableDoubleExpressionMediator(base.Expression, alias);
        #endregion

        #region equals
        public bool Equals(NullableDoubleExpressionMediator obj)
            => obj is NullableDoubleExpressionMediator && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableDoubleExpressionMediator exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
