﻿using HatTrick.DbEx.Sql.Assembler;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HatTrick.DbEx.Sql.Expression
{
    public class NullableCoalesceFunctionExpression<TValue> : NullableCoalesceFunctionExpression,
        IDbFunctionExpression,
        IAssemblyPart,
        ISupportedForFunctionExpression<AverageFunctionExpression, TValue>,
        ISupportedForFunctionExpression<NullableCastFunctionExpression, TValue>,
        ISupportedForFunctionExpression<CastFunctionExpression, TValue>,
        ISupportedForFunctionExpression<IsNullFunctionExpression, TValue>,
        ISupportedForFunctionExpression<MaximumFunctionExpression, TValue>,
        ISupportedForFunctionExpression<MinimumFunctionExpression, TValue>,
        ISupportedForFunctionExpression<PopulationVarianceFunctionExpression, TValue>,
        ISupportedForFunctionExpression<PopulationStandardDeviationFunctionExpression, TValue>,
        ISupportedForFunctionExpression<StandardDeviationFunctionExpression, TValue>,
        ISupportedForFunctionExpression<SumFunctionExpression, TValue>,
        ISupportedForFunctionExpression<VarianceFunctionExpression, TValue>,
        ISupportedForFunctionExpression<IDbNullableDateFunctionExpression<TValue>, TValue>,
        ISupportedForSelectFieldExpression<TValue>,
        IEquatable<NullableCoalesceFunctionExpression<TValue>>
    {
        #region constructors
        internal NullableCoalesceFunctionExpression()
        {
        }

        public NullableCoalesceFunctionExpression(params (Type, object)[] expressions)
            : base(expressions)
        {
        }
        #endregion

        #region as
        public new NullableCoalesceFunctionExpression<TValue> As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(NullableCoalesceFunctionExpression<TValue> obj)
            => base.Equals(obj);

        public override bool Equals(object obj)
         => obj is NullableCoalesceFunctionExpression<TValue> exp ? base.Equals(exp) : false;

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        //MILESTONE: Function Arithmetic
        //public static implicit operator ExpressionMediator<TValue>(NullableCoalesceFunctionExpression<TValue> coalesce) => new ExpressionMediator<TValue>((coalesce.GetType(), coalesce));
        public static implicit operator OrderByExpression(NullableCoalesceFunctionExpression<TValue> coalesce) => new OrderByExpression((coalesce.GetType(), coalesce), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(NullableCoalesceFunctionExpression<TValue> coalesce) => new GroupByExpression((coalesce.GetType(), coalesce));
        #endregion

        #region filter operators
        #region TValue
        #region bool
        public static FilterExpression<bool> operator ==(NullableCoalesceFunctionExpression<TValue> a, bool b) => new FilterExpression<bool>(a, new LiteralExpression<bool>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<bool> operator !=(NullableCoalesceFunctionExpression<TValue> a, bool b) => new FilterExpression<bool>(a, new LiteralExpression<bool>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<bool> operator ==(bool a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<bool>(new LiteralExpression<bool>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<bool> operator !=(bool a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<bool>(new LiteralExpression<bool>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<bool?> operator ==(NullableCoalesceFunctionExpression<TValue> a, bool? b) => new FilterExpression<bool?>(a, new LiteralExpression<bool?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<bool?> operator !=(NullableCoalesceFunctionExpression<TValue> a, bool? b) => new FilterExpression<bool?>(a, new LiteralExpression<bool?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<bool?> operator ==(bool? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<bool?>(new LiteralExpression<bool?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<bool?> operator !=(bool? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<bool?>(new LiteralExpression<bool?>(a), b, FilterExpressionOperator.NotEqual);

        #endregion

        #region byte
        public static FilterExpression<byte> operator ==(NullableCoalesceFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(NullableCoalesceFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(NullableCoalesceFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(NullableCoalesceFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(NullableCoalesceFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(NullableCoalesceFunctionExpression<TValue> a, byte b) => new FilterExpression<byte>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte> operator ==(byte a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(byte a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(byte a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(byte a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(byte a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(byte a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(NullableCoalesceFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(NullableCoalesceFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(NullableCoalesceFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(NullableCoalesceFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(NullableCoalesceFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(NullableCoalesceFunctionExpression<TValue> a, byte? b) => new FilterExpression<byte?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(byte? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(byte? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(byte? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(byte? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(byte? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(byte? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTime
        public static FilterExpression<DateTime> operator ==(NullableCoalesceFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(NullableCoalesceFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(NullableCoalesceFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(NullableCoalesceFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(NullableCoalesceFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(NullableCoalesceFunctionExpression<TValue> a, DateTime b) => new FilterExpression<DateTime>(a, new LiteralExpression<DateTime>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime> operator ==(DateTime a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(DateTime a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(DateTime a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(DateTime a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(DateTime a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(DateTime a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(new LiteralExpression<DateTime>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(NullableCoalesceFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(NullableCoalesceFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(NullableCoalesceFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(NullableCoalesceFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(NullableCoalesceFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(NullableCoalesceFunctionExpression<TValue> a, DateTime? b) => new FilterExpression<DateTime?>(a, new LiteralExpression<DateTime?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(DateTime? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(DateTime? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(DateTime? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(DateTime? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(DateTime? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(DateTime? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(new LiteralExpression<DateTime?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTimeOffset
        public static FilterExpression<DateTimeOffset> operator ==(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset b) => new FilterExpression<DateTimeOffset>(a, new LiteralExpression<DateTimeOffset>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator ==(DateTimeOffset a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(DateTimeOffset a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(DateTimeOffset a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(DateTimeOffset a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(DateTimeOffset a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(DateTimeOffset a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(new LiteralExpression<DateTimeOffset>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(NullableCoalesceFunctionExpression<TValue> a, DateTimeOffset? b) => new FilterExpression<DateTimeOffset?>(a, new LiteralExpression<DateTimeOffset?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(DateTimeOffset? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(DateTimeOffset? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(DateTimeOffset? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(DateTimeOffset? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(DateTimeOffset? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(DateTimeOffset? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(new LiteralExpression<DateTimeOffset?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region decimal
        public static FilterExpression<decimal> operator ==(NullableCoalesceFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(NullableCoalesceFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(NullableCoalesceFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(NullableCoalesceFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(NullableCoalesceFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(NullableCoalesceFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal> operator ==(decimal a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(decimal a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(decimal a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(decimal a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(decimal a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(decimal a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(NullableCoalesceFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableCoalesceFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableCoalesceFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableCoalesceFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableCoalesceFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableCoalesceFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(decimal? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(decimal? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(decimal? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(decimal? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(decimal? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(decimal? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region double
        public static FilterExpression<double> operator ==(NullableCoalesceFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(NullableCoalesceFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(NullableCoalesceFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(NullableCoalesceFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(NullableCoalesceFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(NullableCoalesceFunctionExpression<TValue> a, double b) => new FilterExpression<double>(a, new LiteralExpression<double>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double> operator ==(double a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(double a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(double a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(double a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(double a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(double a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(new LiteralExpression<double>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(NullableCoalesceFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableCoalesceFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableCoalesceFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableCoalesceFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableCoalesceFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableCoalesceFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(double? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(double? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(double? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(double? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(double? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(double? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region float
        public static FilterExpression<float> operator ==(NullableCoalesceFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(NullableCoalesceFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(NullableCoalesceFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(NullableCoalesceFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(NullableCoalesceFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(NullableCoalesceFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float> operator ==(float a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(float a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(float a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(float a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(float a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(float a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableCoalesceFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableCoalesceFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableCoalesceFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableCoalesceFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableCoalesceFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableCoalesceFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(float? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(float? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(float? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(float? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(float? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(float? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region Guid
        public static FilterExpression<Guid> operator ==(NullableCoalesceFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(NullableCoalesceFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(NullableCoalesceFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(NullableCoalesceFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(NullableCoalesceFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(NullableCoalesceFunctionExpression<TValue> a, Guid b) => new FilterExpression<Guid>(a, new LiteralExpression<Guid>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid> operator ==(Guid a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(Guid a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(Guid a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(Guid a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(Guid a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(Guid a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(new LiteralExpression<Guid>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(NullableCoalesceFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(NullableCoalesceFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(NullableCoalesceFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(NullableCoalesceFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(NullableCoalesceFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(NullableCoalesceFunctionExpression<TValue> a, Guid? b) => new FilterExpression<Guid?>(a, new LiteralExpression<Guid?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(Guid? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(Guid? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(Guid? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(Guid? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(Guid? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(Guid? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(new LiteralExpression<Guid?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region int
        public static FilterExpression<int> operator ==(NullableCoalesceFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(NullableCoalesceFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(NullableCoalesceFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(NullableCoalesceFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(NullableCoalesceFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(NullableCoalesceFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(int a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(int a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(int a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(int a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(int a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(int a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableCoalesceFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableCoalesceFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableCoalesceFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableCoalesceFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableCoalesceFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableCoalesceFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(int? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(int? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(int? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(int? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(int? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(int? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region long
        public static FilterExpression<long> operator ==(NullableCoalesceFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(NullableCoalesceFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(NullableCoalesceFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(NullableCoalesceFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(NullableCoalesceFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(NullableCoalesceFunctionExpression<TValue> a, long b) => new FilterExpression<long>(a, new LiteralExpression<long>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long> operator ==(long a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(long a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(long a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(long a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(long a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(long a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(new LiteralExpression<long>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(NullableCoalesceFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableCoalesceFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableCoalesceFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableCoalesceFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableCoalesceFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableCoalesceFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(long? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(long? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(long? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(long? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(long? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(long? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region short
        public static FilterExpression<short> operator ==(NullableCoalesceFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(NullableCoalesceFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(NullableCoalesceFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(NullableCoalesceFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(NullableCoalesceFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(NullableCoalesceFunctionExpression<TValue> a, short b) => new FilterExpression<short>(a, new LiteralExpression<short>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short> operator ==(short a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(short a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(short a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(short a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(short a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(short a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(new LiteralExpression<short>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(NullableCoalesceFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(NullableCoalesceFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(NullableCoalesceFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(NullableCoalesceFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(NullableCoalesceFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(NullableCoalesceFunctionExpression<TValue> a, short? b) => new FilterExpression<short?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(short? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(short? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(short? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(short? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(short? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(short? a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region string
        public static FilterExpression<string> operator ==(NullableCoalesceFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(NullableCoalesceFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(NullableCoalesceFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(NullableCoalesceFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(NullableCoalesceFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(NullableCoalesceFunctionExpression<TValue> a, string b) => new FilterExpression<string>(a, new LiteralExpression<string>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<string> operator ==(string a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(string a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(string a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(string a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(string a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(string a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(new LiteralExpression<string>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        #region bool
        public static FilterExpression<bool> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<bool> b) => new FilterExpression<bool>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<bool> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<bool> b) => new FilterExpression<bool>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<bool> operator ==(ExpressionMediator<bool> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<bool>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<bool> operator !=(ExpressionMediator<bool> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<bool>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<bool?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<bool?> b) => new FilterExpression<bool?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<bool?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<bool?> b) => new FilterExpression<bool?>(a, b.Expression, FilterExpressionOperator.NotEqual);
        #endregion

        #region byte
        public static FilterExpression<byte> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<byte>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte> operator ==(ExpressionMediator<byte> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<byte> operator !=(ExpressionMediator<byte> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte> operator <(ExpressionMediator<byte> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte> operator <=(ExpressionMediator<byte> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte> operator >(ExpressionMediator<byte> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte> operator >=(ExpressionMediator<byte> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<byte?> b) => new FilterExpression<byte?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<byte?> operator ==(NullableExpressionMediator<byte?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<byte?> operator !=(NullableExpressionMediator<byte?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<byte?> operator <(NullableExpressionMediator<byte?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<byte?> operator <=(NullableExpressionMediator<byte?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<byte?> operator >(NullableExpressionMediator<byte?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<byte?> operator >=(NullableExpressionMediator<byte?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<byte?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTime
        public static FilterExpression<DateTime> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTime> b) => new FilterExpression<DateTime>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime> operator ==(ExpressionMediator<DateTime> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime> operator !=(ExpressionMediator<DateTime> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime> operator <(ExpressionMediator<DateTime> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime> operator <=(ExpressionMediator<DateTime> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime> operator >(ExpressionMediator<DateTime> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime> operator >=(ExpressionMediator<DateTime> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTime?> b) => new FilterExpression<DateTime?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTime?> operator ==(NullableExpressionMediator<DateTime?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTime?> operator !=(NullableExpressionMediator<DateTime?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTime?> operator <(NullableExpressionMediator<DateTime?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTime?> operator <=(NullableExpressionMediator<DateTime?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTime?> operator >(NullableExpressionMediator<DateTime?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTime?> operator >=(NullableExpressionMediator<DateTime?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTime?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region DateTimeOffset
        public static FilterExpression<DateTimeOffset> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<DateTimeOffset> b) => new FilterExpression<DateTimeOffset>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator ==(ExpressionMediator<DateTimeOffset> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset> operator !=(ExpressionMediator<DateTimeOffset> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset> operator <(ExpressionMediator<DateTimeOffset> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset> operator <=(ExpressionMediator<DateTimeOffset> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset> operator >(ExpressionMediator<DateTimeOffset> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset> operator >=(ExpressionMediator<DateTimeOffset> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<DateTimeOffset?> b) => new FilterExpression<DateTimeOffset?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator ==(NullableExpressionMediator<DateTimeOffset?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<DateTimeOffset?> operator !=(NullableExpressionMediator<DateTimeOffset?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<DateTimeOffset?> operator <(NullableExpressionMediator<DateTimeOffset?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<DateTimeOffset?> operator <=(NullableExpressionMediator<DateTimeOffset?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<DateTimeOffset?> operator >(NullableExpressionMediator<DateTimeOffset?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<DateTimeOffset?> operator >=(NullableExpressionMediator<DateTimeOffset?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<DateTimeOffset?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region decimal
        public static FilterExpression<decimal> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal> operator ==(ExpressionMediator<decimal> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal> operator !=(ExpressionMediator<decimal> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal> operator <(ExpressionMediator<decimal> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal> operator <=(ExpressionMediator<decimal> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal> operator >(ExpressionMediator<decimal> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal> operator >=(ExpressionMediator<decimal> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(NullableExpressionMediator<decimal?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableExpressionMediator<decimal?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableExpressionMediator<decimal?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableExpressionMediator<decimal?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableExpressionMediator<decimal?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableExpressionMediator<decimal?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region double
        public static FilterExpression<double> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double> operator ==(ExpressionMediator<double> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<double> operator !=(ExpressionMediator<double> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double> operator <(ExpressionMediator<double> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double> operator <=(ExpressionMediator<double> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double> operator >(ExpressionMediator<double> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double> operator >=(ExpressionMediator<double> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(NullableExpressionMediator<double?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableExpressionMediator<double?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableExpressionMediator<double?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableExpressionMediator<double?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableExpressionMediator<double?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableExpressionMediator<double?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region float
        public static FilterExpression<float> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float> operator ==(ExpressionMediator<float> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(ExpressionMediator<float> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(ExpressionMediator<float> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(ExpressionMediator<float> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(ExpressionMediator<float> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(ExpressionMediator<float> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableExpressionMediator<float?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableExpressionMediator<float?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableExpressionMediator<float?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableExpressionMediator<float?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableExpressionMediator<float?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableExpressionMediator<float?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region Guid
        public static FilterExpression<Guid> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<Guid> b) => new FilterExpression<Guid>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid> operator ==(ExpressionMediator<Guid> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid> operator !=(ExpressionMediator<Guid> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid> operator <(ExpressionMediator<Guid> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid> operator <=(ExpressionMediator<Guid> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid> operator >(ExpressionMediator<Guid> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid> operator >=(ExpressionMediator<Guid> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<Guid?> b) => new FilterExpression<Guid?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<Guid?> operator ==(NullableExpressionMediator<Guid?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<Guid?> operator !=(NullableExpressionMediator<Guid?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<Guid?> operator <(NullableExpressionMediator<Guid?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<Guid?> operator <=(NullableExpressionMediator<Guid?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<Guid?> operator >(NullableExpressionMediator<Guid?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<Guid?> operator >=(NullableExpressionMediator<Guid?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<Guid?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region int
        public static FilterExpression<int> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(ExpressionMediator<int> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(ExpressionMediator<int> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(ExpressionMediator<int> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(ExpressionMediator<int> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(ExpressionMediator<int> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(ExpressionMediator<int> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableExpressionMediator<int?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableExpressionMediator<int?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableExpressionMediator<int?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableExpressionMediator<int?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableExpressionMediator<int?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableExpressionMediator<int?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region long
        public static FilterExpression<long> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long> operator ==(ExpressionMediator<long> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<long> operator !=(ExpressionMediator<long> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long> operator <(ExpressionMediator<long> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long> operator <=(ExpressionMediator<long> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long> operator >(ExpressionMediator<long> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long> operator >=(ExpressionMediator<long> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(NullableExpressionMediator<long?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableExpressionMediator<long?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableExpressionMediator<long?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableExpressionMediator<long?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableExpressionMediator<long?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableExpressionMediator<long?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region short
        public static FilterExpression<short> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<short>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short> operator ==(ExpressionMediator<short> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<short> operator !=(ExpressionMediator<short> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short> operator <(ExpressionMediator<short> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<short> operator <=(ExpressionMediator<short> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short> operator >(ExpressionMediator<short> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short> operator >=(ExpressionMediator<short> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(NullableCoalesceFunctionExpression<TValue> a, NullableExpressionMediator<short?> b) => new FilterExpression<short?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<short?> operator ==(NullableExpressionMediator<short?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<short?> operator !=(NullableExpressionMediator<short?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<short?> operator <(NullableExpressionMediator<short?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<short?> operator <=(NullableExpressionMediator<short?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<short?> operator >(NullableExpressionMediator<short?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<short?> operator >=(NullableExpressionMediator<short?> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<short?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region string
        public static FilterExpression<string> operator ==(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(NullableCoalesceFunctionExpression<TValue> a, ExpressionMediator<string> b) => new FilterExpression<string>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<string> operator ==(ExpressionMediator<string> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<string> operator !=(ExpressionMediator<string> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<string> operator <(ExpressionMediator<string> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<string> operator <=(ExpressionMediator<string> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<string> operator >(ExpressionMediator<string> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<string> operator >=(ExpressionMediator<string> a, NullableCoalesceFunctionExpression<TValue> b) => new FilterExpression<string>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
        #endregion
    }
}
