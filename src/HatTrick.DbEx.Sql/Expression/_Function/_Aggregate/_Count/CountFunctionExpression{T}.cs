﻿using HatTrick.DbEx.Sql.Assembler;
using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class CountFunctionExpression<TValue> : CountFunctionExpression,
        IDbFunctionExpression,
        IAssemblyPart,
        IDbExpressionAliasProvider,
        IEquatable<CountFunctionExpression<TValue>>
        where TValue : IComparable
    {
        #region constructors
        public CountFunctionExpression()
            : this(false)
        {
        }

        public CountFunctionExpression(bool isDistinct)
            : base((typeof(LiteralExpression<string>), new LiteralExpression<string>("*")), isDistinct)
        {
        }

        public CountFunctionExpression((Type, object) expression, bool isDistinct) : base(expression, isDistinct)
        {
        }
        #endregion

        #region as
        public new CountFunctionExpression<TValue> As(string alias)
        {
            base.As(alias);
            return this;
        }
        #endregion

        #region equals
        public bool Equals(CountFunctionExpression<TValue> obj)
        {
            if (base.Equals(obj)) return false;

            if (this.Alias != obj.Alias) return false;

            return true;
        }

        public override bool Equals(object obj)
         => obj is CastFunctionExpression<TValue> exp ? base.Equals(exp) : false;

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        //MILESTONE: Function Arithmetic
        //public static implicit operator ExpressionMediator<TValue>(CountFunctionExpression<TValue> count) => new ExpressionMediator<TValue>((count.GetType(), count));
        public static implicit operator OrderByExpression(CountFunctionExpression<TValue> count) => new OrderByExpression((count.GetType(), count), OrderExpressionDirection.ASC);
        #endregion

        #region filter operators
        #region TValue
        #region int
        public static FilterExpression<int> operator ==(CountFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(CountFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(CountFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(CountFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(CountFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(CountFunctionExpression<TValue> a, int b) => new FilterExpression<int>(a, new LiteralExpression<int>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(CountFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(CountFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(CountFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(CountFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(CountFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(CountFunctionExpression<TValue> a, int? b) => new FilterExpression<int?>(a, new LiteralExpression<int?>(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(int a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(int a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(int a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(int a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(int a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(int a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(new LiteralExpression<int>(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int?> operator ==(int? a, CountFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.Equal);

        public static FilterExpression<int?> operator !=(int? a, CountFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int?> operator <(int? a, CountFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int?> operator <=(int? a, CountFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int?> operator >(int? a, CountFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int?> operator >=(int? a, CountFunctionExpression<TValue> b) => new FilterExpression<int?>(new LiteralExpression<int?>(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        #region int
        public static FilterExpression<int> operator ==(CountFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(CountFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(CountFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(CountFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(CountFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(CountFunctionExpression<TValue> a, ExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(ExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(ExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(ExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(ExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(ExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(ExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(CountFunctionExpression<TValue> a, NullableExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(CountFunctionExpression<TValue> a, NullableExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(CountFunctionExpression<TValue> a, NullableExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(CountFunctionExpression<TValue> a, NullableExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(CountFunctionExpression<TValue> a, NullableExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(CountFunctionExpression<TValue> a, NullableExpressionMediator<int> b) => new FilterExpression<int>(a, b.Expression, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<int> operator ==(NullableExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.Equal);

        public static FilterExpression<int> operator !=(NullableExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.NotEqual);

        public static FilterExpression<int> operator <(NullableExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.LessThan);

        public static FilterExpression<int> operator <=(NullableExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.LessThanOrEqual);

        public static FilterExpression<int> operator >(NullableExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.GreaterThan);

        public static FilterExpression<int> operator >=(NullableExpressionMediator<int> a, CountFunctionExpression<TValue> b) => new FilterExpression<int>(a.Expression, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
        #endregion
    }
}
