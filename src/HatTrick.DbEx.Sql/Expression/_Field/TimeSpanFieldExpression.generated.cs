using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class TimeSpanFieldExpression
    {
        #region in value set
        public override FilterExpressionSet In(params TimeSpan[] value) => value is object ? new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(this), new TimeSpanExpressionMediator(new InExpression<TimeSpan>(value)), FilterExpressionOperator.None)) : null;
        public override FilterExpressionSet In(IEnumerable<TimeSpan> value) => value is object ? new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(this), new TimeSpanExpressionMediator(new InExpression<TimeSpan>(value)), FilterExpressionOperator.None)) : null;
        #endregion

        #region set
        public override AssignmentExpression Set(TimeSpan value) => new AssignmentExpression(this, new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(value)));
        public virtual AssignmentExpression Set(TimeSpanElement value) => new AssignmentExpression(this, value);
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new TimeSpanExpressionMediator(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new TimeSpanExpressionMediator(this), OrderExpressionDirection.DESC);
        #endregion

        #region implicit operators
        public static implicit operator SelectExpression<TimeSpan>(TimeSpanFieldExpression a) => new SelectExpression<TimeSpan>(new TimeSpanExpressionMediator(a));
        public static implicit operator TimeSpanExpressionMediator(TimeSpanFieldExpression a) => new TimeSpanExpressionMediator(a);
        public static implicit operator OrderByExpression(TimeSpanFieldExpression a) => new OrderByExpression(new TimeSpanExpressionMediator(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(TimeSpanFieldExpression a) => new GroupByExpression(new TimeSpanExpressionMediator(a));
        #endregion

        #region arithmetic operators
        #region data type
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

        #region fields
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
        #endregion

        #region filter operators
        #region DBNull
        public static FilterExpressionSet operator ==(TimeSpanFieldExpression a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new NullableLiteralExpression<TimeSpan?>()), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TimeSpanFieldExpression a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new NullableLiteralExpression<TimeSpan?>()), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator ==(DBNull a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new NullableLiteralExpression<TimeSpan?>()), new TimeSpanExpressionMediator(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(DBNull a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new NullableLiteralExpression<TimeSpan?>()), new TimeSpanExpressionMediator(b), FilterExpressionOperator.NotEqual));
        #endregion

        #region TimeSpan
        public static FilterExpressionSet operator ==(TimeSpanFieldExpression a, TimeSpan b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(b)), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TimeSpanFieldExpression a, TimeSpan b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(b)), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(TimeSpanFieldExpression a, TimeSpan b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(b)), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(TimeSpanFieldExpression a, TimeSpan b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(b)), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(TimeSpanFieldExpression a, TimeSpan b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(b)), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(TimeSpanFieldExpression a, TimeSpan b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(b)), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(TimeSpan a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TimeSpan a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(TimeSpan a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(TimeSpan a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(TimeSpan a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(TimeSpan a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(new LiteralExpression<TimeSpan>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(TimeSpanFieldExpression a, TimeSpan? b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(b)), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TimeSpanFieldExpression a, TimeSpan? b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(b)), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(TimeSpanFieldExpression a, TimeSpan? b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(b)), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(TimeSpanFieldExpression a, TimeSpan? b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(b)), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(TimeSpanFieldExpression a, TimeSpan? b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(b)), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(TimeSpanFieldExpression a, TimeSpan? b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(b)), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(TimeSpan? a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TimeSpan? a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(TimeSpan? a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(TimeSpan? a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(TimeSpan? a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(TimeSpan? a, TimeSpanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new NullableTimeSpanExpressionMediator(new LiteralExpression<TimeSpan?>(a)), new TimeSpanExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        
        #region mediator
        public static FilterExpressionSet operator ==(TimeSpanFieldExpression a, TimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TimeSpanFieldExpression a, TimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(TimeSpanFieldExpression a, TimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(TimeSpanFieldExpression a, TimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(TimeSpanFieldExpression a, TimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(TimeSpanFieldExpression a, TimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(TimeSpanFieldExpression a, NullableTimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TimeSpanFieldExpression a, NullableTimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(TimeSpanFieldExpression a, NullableTimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator <=(TimeSpanFieldExpression a, NullableTimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >(TimeSpanFieldExpression a, NullableTimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator >=(TimeSpanFieldExpression a, NullableTimeSpanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new TimeSpanExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion
    }
}
