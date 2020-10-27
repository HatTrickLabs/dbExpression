using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class TimeSpanIsNullFunctionExpression :
        IsNullFunctionExpression<TimeSpan>,
        IEquatable<TimeSpanIsNullFunctionExpression>
    {
        #region constructors
        public TimeSpanIsNullFunctionExpression(ExpressionMediator<TimeSpan> expression, ExpressionMediator<TimeSpan> value) : base(expression, value)
        {
        }
        #endregion

        #region as
        public new TimeSpanIsNullFunctionExpression As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(TimeSpanIsNullFunctionExpression obj)
            => obj is TimeSpanIsNullFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is TimeSpanIsNullFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}