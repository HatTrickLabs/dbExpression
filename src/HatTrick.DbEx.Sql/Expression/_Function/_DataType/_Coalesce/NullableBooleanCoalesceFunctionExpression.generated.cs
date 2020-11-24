using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableBooleanCoalesceFunctionExpression
    {
        #region implicit operators
        public static implicit operator NullableBooleanExpressionMediator(NullableBooleanCoalesceFunctionExpression a) => new NullableBooleanExpressionMediator(a);
        public static implicit operator OrderByExpression(NullableBooleanCoalesceFunctionExpression a) => new OrderByExpression(new BooleanExpressionMediator(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(NullableBooleanCoalesceFunctionExpression a) => new GroupByExpression(new BooleanExpressionMediator(a));
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new BooleanExpressionMediator(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new BooleanExpressionMediator(this), OrderExpressionDirection.DESC);
        #endregion

        #region arithmetic operators
        #region TValue
        #region bool



        
        #endregion
        
        #region byte



        
        #endregion
        
        #region decimal



        
        #endregion
        
        #region DateTime



        
        #endregion
        
        #region DateTimeOffset



        
        #endregion
        
        #region double



        
        #endregion
        
        #region float



        
        #endregion
        
        #region Guid



        
        #endregion
        
        #region short



        
        #endregion
        
        #region int



        
        #endregion
        
        #region long



        
        #endregion
        
        #region string
        
        #endregion
        
        #region TimeSpan



        
        #endregion
        
        #endregion

        #region mediator
        #region bool

        #endregion
        
        #region byte

        #endregion
        
        #region decimal

        #endregion
        
        #region DateTime

        #endregion
        
        #region DateTimeOffset

        #endregion
        
        #region double

        #endregion
        
        #region float

        #endregion
        
        #region Guid

        #endregion
        
        #region short

        #endregion
        
        #region int

        #endregion
        
        #region long

        #endregion
        
        #region TimeSpan

        #endregion
        
        #endregion
        #endregion

        #region filter operators
        #region TValue
        #region bool
        public static FilterExpressionSet operator ==(NullableBooleanCoalesceFunctionExpression a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanCoalesceFunctionExpression a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableBooleanCoalesceFunctionExpression a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(NullableBooleanCoalesceFunctionExpression a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(NullableBooleanCoalesceFunctionExpression a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(NullableBooleanCoalesceFunctionExpression a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(bool a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(bool a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(bool a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(bool a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(bool a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(bool a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(NullableBooleanCoalesceFunctionExpression a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanCoalesceFunctionExpression a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableBooleanCoalesceFunctionExpression a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(NullableBooleanCoalesceFunctionExpression a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(NullableBooleanCoalesceFunctionExpression a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(NullableBooleanCoalesceFunctionExpression a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(bool? a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(bool? a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(bool? a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(bool? a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(bool? a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(bool? a, NullableBooleanCoalesceFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion

        #region mediator
        public static FilterExpressionSet operator ==(NullableBooleanCoalesceFunctionExpression a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanCoalesceFunctionExpression a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableBooleanCoalesceFunctionExpression a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(NullableBooleanCoalesceFunctionExpression a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(NullableBooleanCoalesceFunctionExpression a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(NullableBooleanCoalesceFunctionExpression a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(NullableBooleanCoalesceFunctionExpression a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanCoalesceFunctionExpression a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableBooleanCoalesceFunctionExpression a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(NullableBooleanCoalesceFunctionExpression a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(NullableBooleanCoalesceFunctionExpression a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(NullableBooleanCoalesceFunctionExpression a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion
    }
}
