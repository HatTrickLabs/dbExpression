﻿using HatTrick.DbEx.Sql.Assembler;
using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class DateAddFunctionExpression<TValue> : DateAddFunctionExpression,
        ISupportedForSelectFieldExpression<TValue>,
        ISupportedForFunctionExpression<CastFunctionExpression, TValue>,
        ISupportedForFunctionExpression<CoalesceFunctionExpression, TValue>,
        ISupportedForFunctionExpression<CountFunctionExpression, TValue>,
        ISupportedForFunctionExpression<IsNullFunctionExpression, TValue>,
        ISupportedForFunctionExpression<MaximumFunctionExpression, TValue>,
        ISupportedForFunctionExpression<MinimumFunctionExpression, TValue>,
        ISupportedForFunctionExpression<IDbDateFunctionExpression<DateTime>, TValue>,
        ISupportedForFunctionExpression<IDbDateFunctionExpression<DateTimeOffset>, TValue>,
        IEquatable<DateAddFunctionExpression<TValue>>
    {
        #region constructors
        internal DateAddFunctionExpression()
        {
        }

        public DateAddFunctionExpression((Type, object) datePart, (Type, object) value, (Type, object) expression) 
            : base(datePart, value, expression)
        {
        }
        #endregion

        #region as
        public new DateAddFunctionExpression<TValue> As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(DateAddFunctionExpression<TValue> obj)
            => obj is DateAddFunctionExpression<TValue> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is DateAddFunctionExpression<TValue> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        //MILESTONE: Function Arithmetic
        //public static implicit operator ExpressionMediator<TValue>(DateAddFunctionExpression<TValue> dateAdd) => new ExpressionMediator<TValue>((dateAdd.GetType(), dateAdd));
        public static implicit operator OrderByExpression(DateAddFunctionExpression<TValue> dateAdd) => new OrderByExpression((dateAdd.GetType(), dateAdd), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(DateAddFunctionExpression<TValue> dateAdd) => new GroupByExpression((dateAdd.GetType(), dateAdd));
        #endregion

        #region filter operators
        #region TValue
        #region DateTime
        public static FilterExpression<DateTime> operator ==(DateAddFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(DateAddFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(DateAddFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(DateAddFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(DateAddFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(DateAddFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime> operator ==(DateTime a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(DateTime a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(DateTime a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(DateTime a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(DateTime a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(DateTime a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(DateAddFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(DateAddFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(DateAddFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(DateAddFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(DateAddFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(DateAddFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(DateTime? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(DateTime? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(DateTime? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(DateTime? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(DateTime? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(DateTime? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTimeOffset
        public static FilterExpression<DateTimeOffset> operator ==(DateAddFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(DateAddFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(DateAddFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(DateAddFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(DateAddFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(DateAddFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator ==(DateTimeOffset a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(DateTimeOffset a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(DateTimeOffset a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(DateTimeOffset a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(DateTimeOffset a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(DateTimeOffset a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(DateAddFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(DateAddFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(DateAddFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(DateAddFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(DateAddFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(DateAddFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(DateTimeOffset? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(DateTimeOffset? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(DateTimeOffset? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(DateTimeOffset? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(DateTimeOffset? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(DateTimeOffset? a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        #region DateTime
        public static FilterExpression<DateTime> operator ==(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime> operator ==(ExpressionMediator<DateTime> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(ExpressionMediator<DateTime> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(ExpressionMediator<DateTime> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(ExpressionMediator<DateTime> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(ExpressionMediator<DateTime> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(ExpressionMediator<DateTime> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(NullableExpressionMediator<DateTime?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(NullableExpressionMediator<DateTime?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(NullableExpressionMediator<DateTime?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(NullableExpressionMediator<DateTime?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(NullableExpressionMediator<DateTime?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(NullableExpressionMediator<DateTime?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTimeOffset
        public static FilterExpression<DateTimeOffset> operator ==(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(DateAddFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator ==(ExpressionMediator<DateTimeOffset> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(ExpressionMediator<DateTimeOffset> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(ExpressionMediator<DateTimeOffset> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(ExpressionMediator<DateTimeOffset> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(ExpressionMediator<DateTimeOffset> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(ExpressionMediator<DateTimeOffset> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(DateAddFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(NullableExpressionMediator<DateTimeOffset?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(NullableExpressionMediator<DateTimeOffset?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(NullableExpressionMediator<DateTimeOffset?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(NullableExpressionMediator<DateTimeOffset?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(NullableExpressionMediator<DateTimeOffset?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(NullableExpressionMediator<DateTimeOffset?> a, DateAddFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
        #endregion
    }
}
