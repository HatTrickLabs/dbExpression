using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableDateTimeDateAddFunctionExpression :
        NullableDateAddFunctionExpression<DateTime>,
        IEquatable<NullableDateTimeDateAddFunctionExpression>
    {
        #region constructors
        public NullableDateTimeDateAddFunctionExpression(DatePartsExpression datePart, NullableExpressionMediator<int> value, NullableExpressionMediator<DateTime> expression) : base(datePart, value, expression)
        {
        }

        public NullableDateTimeDateAddFunctionExpression(DatePartsExpression datePart, ExpressionMediator<int> value, ExpressionMediator<DateTime> expression) : base(datePart, value, expression)
        {
        }
        #endregion

        #region as
        public new NullableDateTimeDateAddFunctionExpression As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(NullableDateTimeDateAddFunctionExpression obj)
            => obj is NullableDateTimeDateAddFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableDateTimeDateAddFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}