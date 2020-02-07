﻿using HatTrick.DbEx.Sql.Assembler;
using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class NullableSumFunctionExpression<TValue> : NullableSumFunctionExpression,
        IDbFunctionExpression,
        IAssemblyPart,
        IDbExpressionAliasProvider,
        ISupportedForFunctionExpression<CastFunctionExpression, TValue>,
        ISupportedForFunctionExpression<CoalesceFunctionExpression, TValue>,
        ISupportedForFunctionExpression<ConcatFunctionExpression, TValue>,
        ISupportedForFunctionExpression<IsNullFunctionExpression, TValue>,
        ISupportedForSelectFieldExpression<TValue>,
        IEquatable<NullableSumFunctionExpression<TValue>>
    {
        #region constructors
        internal NullableSumFunctionExpression()
        {
        }

        public NullableSumFunctionExpression((Type, object) expression, bool isDistinct) : base(expression, isDistinct)
        {
        }

        #endregion

        #region as
        public new NullableSumFunctionExpression<TValue> As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(NullableSumFunctionExpression<TValue> obj)
            => obj is NullableSumFunctionExpression<TValue> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableSumFunctionExpression<TValue> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        //MILESTONE: Function Arithmetic
        //public static implicit operator NullableExpressionMediator<TValue>(NullableSumFunctionExpression<TValue> sum) => new NullableExpressionMediator<TValue>((sum.GetType(), sum));
        public static implicit operator OrderByExpression(NullableSumFunctionExpression<TValue> sum) => new OrderByExpression((sum.GetType(), sum), OrderExpressionDirection.ASC);
        #endregion

        #region filter operators
        #region TValue
        #region byte
        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, byte b) => new FilterExpression<int?>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, byte b) => new FilterExpression<int?>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, byte b) => new FilterExpression<int?>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, byte b) => new FilterExpression<int?>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, byte b) => new FilterExpression<int?>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, byte b) => new FilterExpression<int?>(a, new LiteralExpression<byte>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(byte a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(byte a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(byte a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(byte a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(byte a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(byte a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, byte? b) => new FilterExpression<int?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, byte? b) => new FilterExpression<int?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, byte? b) => new FilterExpression<int?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, byte? b) => new FilterExpression<int?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, byte? b) => new FilterExpression<int?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, byte? b) => new FilterExpression<int?>(a, new LiteralExpression<byte?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(byte? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(byte? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(byte? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(byte? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(byte? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(byte? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<byte?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region decimal
        public static FilterExpression<decimal?> operator ==(NullableSumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableSumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableSumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableSumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableSumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableSumFunctionExpression<TValue> a, decimal b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(decimal a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(decimal a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(decimal a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(decimal a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(decimal a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(decimal a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(NullableSumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableSumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableSumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableSumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableSumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableSumFunctionExpression<TValue> a, decimal? b) => new FilterExpression<decimal?>(a, new LiteralExpression<decimal?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(decimal? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(decimal? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(decimal? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(decimal? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(decimal? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(decimal? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(new LiteralExpression<decimal?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        #endregion

        #region double
        public static FilterExpression<double?> operator ==(NullableSumFunctionExpression<TValue> a, double b) => new FilterExpression<double?>(a, new LiteralExpression<double>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableSumFunctionExpression<TValue> a, double b) => new FilterExpression<double?>(a, new LiteralExpression<double>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableSumFunctionExpression<TValue> a, double b) => new FilterExpression<double?>(a, new LiteralExpression<double>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableSumFunctionExpression<TValue> a, double b) => new FilterExpression<double?>(a, new LiteralExpression<double>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableSumFunctionExpression<TValue> a, double b) => new FilterExpression<double?>(a, new LiteralExpression<double>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableSumFunctionExpression<TValue> a, double b) => new FilterExpression<double?>(a, new LiteralExpression<double>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(double a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(double a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(double a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(double a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(double a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(double a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(NullableSumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableSumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableSumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableSumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableSumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableSumFunctionExpression<TValue> a, double? b) => new FilterExpression<double?>(a, new LiteralExpression<double?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(double? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(double? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(double? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(double? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(double? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(double? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(new LiteralExpression<double?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        #endregion

        #region float
        public static FilterExpression<float?> operator ==(NullableSumFunctionExpression<TValue> a, float b) => new FilterExpression<float?>(a, new LiteralExpression<float>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableSumFunctionExpression<TValue> a, float b) => new FilterExpression<float?>(a, new LiteralExpression<float>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableSumFunctionExpression<TValue> a, float b) => new FilterExpression<float?>(a, new LiteralExpression<float>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableSumFunctionExpression<TValue> a, float b) => new FilterExpression<float?>(a, new LiteralExpression<float>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableSumFunctionExpression<TValue> a, float b) => new FilterExpression<float?>(a, new LiteralExpression<float>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableSumFunctionExpression<TValue> a, float b) => new FilterExpression<float?>(a, new LiteralExpression<float>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(float a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(float a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(float a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(float a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(float a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(float a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableSumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableSumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableSumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableSumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableSumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableSumFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(float? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(float? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(float? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(float? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(float? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(float? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        #endregion

        #region int
        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, int b) => new FilterExpression<int?>(a, new LiteralExpression<int>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, int b) => new FilterExpression<int?>(a, new LiteralExpression<int>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, int b) => new FilterExpression<int?>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, int b) => new FilterExpression<int?>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, int b) => new FilterExpression<int?>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, int b) => new FilterExpression<int?>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(int a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(int a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(int a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(int a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(int a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(int a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(int? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(int? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(int? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(int? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(int? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(int? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        #endregion

        #region long
        public static FilterExpression<long?> operator ==(NullableSumFunctionExpression<TValue> a, long b) => new FilterExpression<long?>(a, new LiteralExpression<long>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableSumFunctionExpression<TValue> a, long b) => new FilterExpression<long?>(a, new LiteralExpression<long>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableSumFunctionExpression<TValue> a, long b) => new FilterExpression<long?>(a, new LiteralExpression<long>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableSumFunctionExpression<TValue> a, long b) => new FilterExpression<long?>(a, new LiteralExpression<long>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableSumFunctionExpression<TValue> a, long b) => new FilterExpression<long?>(a, new LiteralExpression<long>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableSumFunctionExpression<TValue> a, long b) => new FilterExpression<long?>(a, new LiteralExpression<long>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(long a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(long a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(long a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(long a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(long a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(long a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(NullableSumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableSumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableSumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableSumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableSumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableSumFunctionExpression<TValue> a, long? b) => new FilterExpression<long?>(a, new LiteralExpression<long?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(long? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(long? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(long? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(long? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(long? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(long? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(new LiteralExpression<long?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        #endregion

        #region short
        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, short b) => new FilterExpression<int?>(a, new LiteralExpression<short>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, short b) => new FilterExpression<int?>(a, new LiteralExpression<short>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, short b) => new FilterExpression<int?>(a, new LiteralExpression<short>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, short b) => new FilterExpression<int?>(a, new LiteralExpression<short>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, short b) => new FilterExpression<int?>(a, new LiteralExpression<short>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, short b) => new FilterExpression<int?>(a, new LiteralExpression<short>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(short a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(short a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(short a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(short a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(short a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(short a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, short? b) => new FilterExpression<int?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, short? b) => new FilterExpression<int?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, short? b) => new FilterExpression<int?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, short? b) => new FilterExpression<int?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, short? b) => new FilterExpression<int?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, short? b) => new FilterExpression<int?>(a, new LiteralExpression<short?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(short? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(short? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(short? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(short? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(short? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(short? a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<short?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        #endregion
        #endregion

        #region mediator
        #region byte
        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(ExpressionMediator<byte> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(ExpressionMediator<byte> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(ExpressionMediator<byte> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(ExpressionMediator<byte> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(ExpressionMediator<byte> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(ExpressionMediator<byte> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<byte?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(ExpressionMediator<byte?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(ExpressionMediator<byte?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(ExpressionMediator<byte?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(ExpressionMediator<byte?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(ExpressionMediator<byte?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(ExpressionMediator<byte?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region decimal
        public static FilterExpression<decimal?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(ExpressionMediator<decimal> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(ExpressionMediator<decimal> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(ExpressionMediator<decimal> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(ExpressionMediator<decimal> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(ExpressionMediator<decimal> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(ExpressionMediator<decimal> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<decimal?> b) => new FilterExpression<decimal?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<decimal?> operator ==(ExpressionMediator<decimal?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<decimal?> operator !=(ExpressionMediator<decimal?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<decimal?> operator <(ExpressionMediator<decimal?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<decimal?> operator <=(ExpressionMediator<decimal?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<decimal?> operator >(ExpressionMediator<decimal?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<decimal?> operator >=(ExpressionMediator<decimal?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<decimal?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region double
        public static FilterExpression<double?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(ExpressionMediator<double> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(ExpressionMediator<double> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(ExpressionMediator<double> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(ExpressionMediator<double> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(ExpressionMediator<double> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(ExpressionMediator<double> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<double?> b) => new FilterExpression<double?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<double?> operator ==(ExpressionMediator<double?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<double?> operator !=(ExpressionMediator<double?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<double?> operator <(ExpressionMediator<double?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<double?> operator <=(ExpressionMediator<double?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<double?> operator >(ExpressionMediator<double?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<double?> operator >=(ExpressionMediator<double?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<double?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region float
        public static FilterExpression<float?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(ExpressionMediator<float> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(ExpressionMediator<float> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(ExpressionMediator<float> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(ExpressionMediator<float> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(ExpressionMediator<float> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(ExpressionMediator<float> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(ExpressionMediator<float?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(ExpressionMediator<float?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(ExpressionMediator<float?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(ExpressionMediator<float?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(ExpressionMediator<float?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(ExpressionMediator<float?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<float?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region int
        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(ExpressionMediator<int> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(ExpressionMediator<int> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(ExpressionMediator<int> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(ExpressionMediator<int> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(ExpressionMediator<int> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(ExpressionMediator<int> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<int?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(ExpressionMediator<int?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(ExpressionMediator<int?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(ExpressionMediator<int?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(ExpressionMediator<int?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(ExpressionMediator<int?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(ExpressionMediator<int?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region long
        public static FilterExpression<long?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(ExpressionMediator<long> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(ExpressionMediator<long> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(ExpressionMediator<long> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(ExpressionMediator<long> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(ExpressionMediator<long> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(ExpressionMediator<long> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<long?> b) => new FilterExpression<long?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<long?> operator ==(ExpressionMediator<long?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<long?> operator !=(ExpressionMediator<long?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<long?> operator <(ExpressionMediator<long?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<long?> operator <=(ExpressionMediator<long?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<long?> operator >(ExpressionMediator<long?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<long?> operator >=(ExpressionMediator<long?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<long?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion

        #region short
        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(ExpressionMediator<short> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(ExpressionMediator<short> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(ExpressionMediator<short> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(ExpressionMediator<short> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(ExpressionMediator<short> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(ExpressionMediator<short> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(NullableSumFunctionExpression<TValue> a, ExpressionMediator<short?> b) => new FilterExpression<int?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(ExpressionMediator<short?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(ExpressionMediator<short?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(ExpressionMediator<short?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(ExpressionMediator<short?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(ExpressionMediator<short?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(ExpressionMediator<short?> a, NullableSumFunctionExpression<TValue> b) => new FilterExpression<int?>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
        #endregion
    }
}
