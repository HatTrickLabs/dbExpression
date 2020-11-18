using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class DateTimeOffsetDateAddFunctionExpression :
        DateAddFunctionExpression<DateTimeOffset>,
        DateTimeOffsetElement,
        AnyDateTimeOffsetElement,
        IEquatable<DateTimeOffsetDateAddFunctionExpression>
    {
        #region constructors
        public DateTimeOffsetDateAddFunctionExpression(DatePartsExpression datePart, Int32Element value, DateTimeOffsetElement expression)
            : base(datePart, value, expression)
        {

        }

        protected DateTimeOffsetDateAddFunctionExpression(DatePartsExpression datePart, IExpressionElement value, IExpressionElement expression, string alias)
            : base(datePart, value, expression, alias)
        {

        }
        #endregion

        #region as
        public DateTimeOffsetElement As(string alias)
            => new DateTimeOffsetDateAddFunctionExpression(base.DatePart, base.Value, base.Expression, alias);
        #endregion

        #region equals
        public bool Equals(DateTimeOffsetDateAddFunctionExpression obj)
            => obj is DateTimeOffsetDateAddFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is DateTimeOffsetDateAddFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
