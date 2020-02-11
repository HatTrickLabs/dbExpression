﻿using HatTrick.DbEx.Sql.Assembler;
using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class MinimumFunctionExpression<TValue> : MinimumFunctionExpression,
        IDbFunctionExpression,
        IAssemblyPart,
        IDbExpressionAliasProvider,
        ISupportedForFunctionExpression<CastFunctionExpression, TValue>,
        ISupportedForFunctionExpression<CoalesceFunctionExpression, TValue>,
        ISupportedForFunctionExpression<ConcatFunctionExpression, TValue>,
        ISupportedForFunctionExpression<IsNullFunctionExpression, TValue>,
        ISupportedForSelectFieldExpression<TValue>,
        IEquatable<MinimumFunctionExpression<TValue>>
    {
        #region constructors
        internal MinimumFunctionExpression()
        {
        }

        public MinimumFunctionExpression((Type, object) expression, bool isDistinct) : base(expression, isDistinct)
        {
        }
        #endregion

        #region as
        public new MinimumFunctionExpression<TValue> As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(MinimumFunctionExpression<TValue> obj)
            => obj is MinimumFunctionExpression<TValue> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is MinimumFunctionExpression<TValue> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        //MILESTONE: Function Arithmetic
        //public static implicit operator ExpressionMediator<TValue>(MinimumFunctionExpression<TValue> minimum) => new ExpressionMediator<TValue>((minimum.GetType(), minimum));
        public static implicit operator OrderByExpression(MinimumFunctionExpression<TValue> minimum) => new OrderByExpression((minimum.GetType(), minimum), OrderExpressionDirection.ASC);
        #endregion

        #region filter operators
        #region TValue
        #region byte
        public static FilterExpression<byte> operator ==(MinimumFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(MinimumFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(MinimumFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(MinimumFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(MinimumFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(MinimumFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(MinimumFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(MinimumFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(MinimumFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(MinimumFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(MinimumFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(MinimumFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte> operator ==(byte a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(byte a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(byte a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(byte a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(byte a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(byte a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(byte? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(byte? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(byte? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(byte? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(byte? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(byte? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTime
        public static FilterExpression<DateTime> operator ==(MinimumFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(MinimumFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(MinimumFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(MinimumFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(MinimumFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(MinimumFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(MinimumFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(MinimumFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(MinimumFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(MinimumFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(MinimumFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(MinimumFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime> operator ==(DateTime a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(DateTime a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(DateTime a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(DateTime a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(DateTime a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(DateTime a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(DateTime? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(DateTime? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(DateTime? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(DateTime? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(DateTime? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(DateTime? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTimeOffset
        public static FilterExpression<DateTimeOffset> operator ==(MinimumFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(MinimumFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(MinimumFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(MinimumFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(MinimumFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(MinimumFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(MinimumFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(MinimumFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(MinimumFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(MinimumFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(MinimumFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(MinimumFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator ==(DateTimeOffset a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(DateTimeOffset a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(DateTimeOffset a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(DateTimeOffset a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(DateTimeOffset a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(DateTimeOffset a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(DateTimeOffset? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(DateTimeOffset? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(DateTimeOffset? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(DateTimeOffset? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(DateTimeOffset? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(DateTimeOffset? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region decimal
        public static FilterExpression<decimal> operator ==(MinimumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(MinimumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(MinimumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(MinimumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(MinimumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(MinimumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(MinimumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(MinimumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(MinimumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(MinimumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(MinimumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(MinimumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal> operator ==(decimal a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(decimal a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(decimal a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(decimal a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(decimal a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(decimal a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(decimal? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(decimal? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(decimal? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(decimal? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(decimal? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(decimal? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region double
        public static FilterExpression<double> operator ==(MinimumFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(MinimumFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(MinimumFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(MinimumFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(MinimumFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(MinimumFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(MinimumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(MinimumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(MinimumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(MinimumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(MinimumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(MinimumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double> operator ==(double a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(double a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(double a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(double a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(double a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(double a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(double? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(double? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(double? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(double? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(double? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(double? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region float
        public static FilterExpression<float> operator ==(MinimumFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(MinimumFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(MinimumFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(MinimumFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(MinimumFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(MinimumFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(MinimumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(MinimumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(MinimumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(MinimumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(MinimumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(MinimumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float> operator ==(float a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(float a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(float a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(float a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(float a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(float a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(float? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(float? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(float? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(float? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(float? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(float? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region Guid
        public static FilterExpression<Guid> operator ==(MinimumFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(MinimumFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(MinimumFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(MinimumFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(MinimumFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(MinimumFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(MinimumFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(MinimumFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(MinimumFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(MinimumFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(MinimumFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(MinimumFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid> operator ==(Guid a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(Guid a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(Guid a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(Guid a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(Guid a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(Guid a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(Guid? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(Guid? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(Guid? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(Guid? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(Guid? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(Guid? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region int
        public static FilterExpression<int> operator ==(MinimumFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(MinimumFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(MinimumFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(MinimumFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(MinimumFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(MinimumFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(MinimumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(MinimumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(MinimumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(MinimumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(MinimumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(MinimumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(int a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(int a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(int a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(int a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(int a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(int a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(int? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(int? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(int? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(int? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(int? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(int? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region long
        public static FilterExpression<long> operator ==(MinimumFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(MinimumFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(MinimumFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(MinimumFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(MinimumFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(MinimumFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(MinimumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(MinimumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(MinimumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(MinimumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(MinimumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(MinimumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long> operator ==(long a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(long a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(long a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(long a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(long a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(long a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(long? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(long? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(long? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(long? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(long? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(long? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region short
        public static FilterExpression<short> operator ==(MinimumFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(MinimumFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(MinimumFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(MinimumFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(MinimumFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(MinimumFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(MinimumFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(MinimumFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(MinimumFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(MinimumFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(MinimumFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(MinimumFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short> operator ==(short a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(short a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(short a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(short a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(short a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(short a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(short? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(short? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(short? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(short? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(short? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(short? a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region string
        public static FilterExpression<string> operator ==(MinimumFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(MinimumFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(MinimumFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(MinimumFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(MinimumFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(MinimumFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<string> operator ==(string a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(string a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(string a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(string a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(string a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(string a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        #region byte
        public static FilterExpression<byte> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte> operator ==(ExpressionMediator<byte> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(ExpressionMediator<byte> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(ExpressionMediator<byte> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(ExpressionMediator<byte> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(ExpressionMediator<byte> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(ExpressionMediator<byte> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(NullableExpressionMediator<byte?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(NullableExpressionMediator<byte?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(NullableExpressionMediator<byte?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(NullableExpressionMediator<byte?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(NullableExpressionMediator<byte?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(NullableExpressionMediator<byte?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTime
        public static FilterExpression<DateTime> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime> operator ==(ExpressionMediator<DateTime> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(ExpressionMediator<DateTime> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(ExpressionMediator<DateTime> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(ExpressionMediator<DateTime> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(ExpressionMediator<DateTime> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(ExpressionMediator<DateTime> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(NullableExpressionMediator<DateTime?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(NullableExpressionMediator<DateTime?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(NullableExpressionMediator<DateTime?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(NullableExpressionMediator<DateTime?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(NullableExpressionMediator<DateTime?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(NullableExpressionMediator<DateTime?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTimeOffset
        public static FilterExpression<DateTimeOffset> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator ==(ExpressionMediator<DateTimeOffset> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(ExpressionMediator<DateTimeOffset> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(ExpressionMediator<DateTimeOffset> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(ExpressionMediator<DateTimeOffset> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(ExpressionMediator<DateTimeOffset> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(ExpressionMediator<DateTimeOffset> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(NullableExpressionMediator<DateTimeOffset?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(NullableExpressionMediator<DateTimeOffset?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(NullableExpressionMediator<DateTimeOffset?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(NullableExpressionMediator<DateTimeOffset?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(NullableExpressionMediator<DateTimeOffset?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(NullableExpressionMediator<DateTimeOffset?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region decimal
        public static FilterExpression<decimal> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal> operator ==(ExpressionMediator<decimal> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(ExpressionMediator<decimal> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(ExpressionMediator<decimal> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(ExpressionMediator<decimal> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(ExpressionMediator<decimal> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(ExpressionMediator<decimal> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(NullableExpressionMediator<decimal?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableExpressionMediator<decimal?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableExpressionMediator<decimal?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableExpressionMediator<decimal?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableExpressionMediator<decimal?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableExpressionMediator<decimal?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region double
        public static FilterExpression<double> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double> operator ==(ExpressionMediator<double> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(ExpressionMediator<double> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(ExpressionMediator<double> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(ExpressionMediator<double> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(ExpressionMediator<double> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(ExpressionMediator<double> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(NullableExpressionMediator<double?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableExpressionMediator<double?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableExpressionMediator<double?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableExpressionMediator<double?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableExpressionMediator<double?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableExpressionMediator<double?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region float
        public static FilterExpression<float> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float> operator ==(ExpressionMediator<float> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(ExpressionMediator<float> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(ExpressionMediator<float> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(ExpressionMediator<float> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(ExpressionMediator<float> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(ExpressionMediator<float> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableExpressionMediator<float?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableExpressionMediator<float?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableExpressionMediator<float?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableExpressionMediator<float?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableExpressionMediator<float?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableExpressionMediator<float?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region Guid
        public static FilterExpression<Guid> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid> operator ==(ExpressionMediator<Guid> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(ExpressionMediator<Guid> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(ExpressionMediator<Guid> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(ExpressionMediator<Guid> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(ExpressionMediator<Guid> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(ExpressionMediator<Guid> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(NullableExpressionMediator<Guid?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(NullableExpressionMediator<Guid?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(NullableExpressionMediator<Guid?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(NullableExpressionMediator<Guid?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(NullableExpressionMediator<Guid?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(NullableExpressionMediator<Guid?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region int
        public static FilterExpression<int> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(ExpressionMediator<int> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(ExpressionMediator<int> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(ExpressionMediator<int> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(ExpressionMediator<int> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(ExpressionMediator<int> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(ExpressionMediator<int> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableExpressionMediator<int?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableExpressionMediator<int?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableExpressionMediator<int?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableExpressionMediator<int?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableExpressionMediator<int?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableExpressionMediator<int?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region long
        public static FilterExpression<long> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long> operator ==(ExpressionMediator<long> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(ExpressionMediator<long> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(ExpressionMediator<long> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(ExpressionMediator<long> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(ExpressionMediator<long> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(ExpressionMediator<long> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(NullableExpressionMediator<long?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableExpressionMediator<long?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableExpressionMediator<long?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableExpressionMediator<long?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableExpressionMediator<long?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableExpressionMediator<long?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region short
        public static FilterExpression<short> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short> operator ==(ExpressionMediator<short> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(ExpressionMediator<short> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(ExpressionMediator<short> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(ExpressionMediator<short> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(ExpressionMediator<short> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(ExpressionMediator<short> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(MinimumFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(NullableExpressionMediator<short?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(NullableExpressionMediator<short?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(NullableExpressionMediator<short?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(NullableExpressionMediator<short?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(NullableExpressionMediator<short?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(NullableExpressionMediator<short?> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region string
        public static FilterExpression<string> operator ==(MinimumFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(MinimumFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(MinimumFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(MinimumFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(MinimumFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(MinimumFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<string> operator ==(ExpressionMediator<string> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(ExpressionMediator<string> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(ExpressionMediator<string> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(ExpressionMediator<string> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(ExpressionMediator<string> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(ExpressionMediator<string> a, MinimumFunctionExpression<TValue> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
        #endregion
    }
}
