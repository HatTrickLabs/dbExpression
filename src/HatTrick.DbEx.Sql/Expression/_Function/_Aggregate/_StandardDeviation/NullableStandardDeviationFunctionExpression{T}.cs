﻿using HatTrick.DbEx.Sql.Assembler;
using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class NullableStandardDeviationFunctionExpression<TValue> : NullableStandardDeviationFunctionExpression,
        IDbFunctionExpression,
        IAssemblyPart,
        IDbExpressionAliasProvider,
        ISupportedForFunctionExpression<CastFunctionExpression, float?>,
        ISupportedForFunctionExpression<CoalesceFunctionExpression, float?>,
        ISupportedForFunctionExpression<ConcatFunctionExpression, float?>,
        ISupportedForFunctionExpression<IsNullFunctionExpression, float?>,
        ISupportedForSelectFieldExpression<TValue>,
        IEquatable<NullableStandardDeviationFunctionExpression<TValue>>
    {
        #region constructors
        internal NullableStandardDeviationFunctionExpression()
        {
        }

        public NullableStandardDeviationFunctionExpression((Type, object) expression, bool isDistinct) : base(expression, isDistinct)
        {
        }

        #endregion

        #region as
        public new NullableStandardDeviationFunctionExpression<TValue> As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(NullableStandardDeviationFunctionExpression<TValue> obj)
            => obj is NullableStandardDeviationFunctionExpression<TValue> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableStandardDeviationFunctionExpression<TValue> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        //MILESTONE: Function Arithmetic
        //public static implicit operator NullableExpressionMediator<TValue>(NullableStandardDeviationFunctionExpression<TValue> stdev) => new NullableExpressionMediator<TValue>((stdev.GetType(), stdev));
        public static implicit operator OrderByExpression(NullableStandardDeviationFunctionExpression<TValue> stdev) => new OrderByExpression((stdev.GetType(), stdev), OrderExpressionDirection.ASC);
        #endregion

        #region filter operators
        #region TValue
        #region float
        public static FilterExpression<float> operator ==(NullableStandardDeviationFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(NullableStandardDeviationFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(NullableStandardDeviationFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(NullableStandardDeviationFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(NullableStandardDeviationFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(NullableStandardDeviationFunctionExpression<TValue> a, float b) => new FilterExpression<float>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float> operator ==(float a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(float a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(float a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(float a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(float a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(float a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableStandardDeviationFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableStandardDeviationFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableStandardDeviationFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableStandardDeviationFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableStandardDeviationFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableStandardDeviationFunctionExpression<TValue> a, float? b) => new FilterExpression<float?>(a, new LiteralExpression<float?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(float? a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(float? a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(float? a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(float? a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(float? a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(float? a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(new LiteralExpression<float?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        #region float
        public static FilterExpression<float> operator ==(NullableStandardDeviationFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(NullableStandardDeviationFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(NullableStandardDeviationFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(NullableStandardDeviationFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(NullableStandardDeviationFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(NullableStandardDeviationFunctionExpression<TValue> a, ExpressionMediator<float> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float> operator ==(ExpressionMediator<float> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float> operator !=(ExpressionMediator<float> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float> operator <(ExpressionMediator<float> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float> operator <=(ExpressionMediator<float> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float> operator >(ExpressionMediator<float> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float> operator >=(ExpressionMediator<float> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableStandardDeviationFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableStandardDeviationFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableStandardDeviationFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableStandardDeviationFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableStandardDeviationFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableStandardDeviationFunctionExpression<TValue> a, NullableExpressionMediator<float?> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<float?> operator ==(NullableExpressionMediator<float?> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<float?> operator !=(NullableExpressionMediator<float?> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<float?> operator <(NullableExpressionMediator<float?> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<float?> operator <=(NullableExpressionMediator<float?> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<float?> operator >(NullableExpressionMediator<float?> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<float?> operator >=(NullableExpressionMediator<float?> a, NullableStandardDeviationFunctionExpression<TValue> b) => new FilterExpression<float?>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
        #endregion
    }
}
