using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableDateTimeOffsetExpressionMediator :
        NullableExpressionMediator<DateTimeOffset>,
        IEquatable<NullableDateTimeOffsetExpressionMediator>
    {
        #region constructors
        private NullableDateTimeOffsetExpressionMediator()
        {
        }

        public NullableDateTimeOffsetExpressionMediator(IDbExpression expression) : base(expression)
        {
        }
        #endregion

        #region as
        public new NullableDateTimeOffsetExpressionMediator As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(NullableDateTimeOffsetExpressionMediator obj)
            => obj is NullableDateTimeOffsetExpressionMediator && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableDateTimeOffsetExpressionMediator exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}