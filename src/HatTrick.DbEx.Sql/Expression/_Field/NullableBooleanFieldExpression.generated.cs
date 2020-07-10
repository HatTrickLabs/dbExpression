using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableBooleanFieldExpression
    {
        #region in value set
        public override FilterExpression In(params bool[] value) => value != null ? new FilterExpression<bool>(new NullableBooleanExpressionMediator(this), new BooleanExpressionMediator(new LiteralExpression<bool[]>(value)), FilterExpressionOperator.In) : null;
        #endregion

        #region isnull
        public override FilterExpression<bool> IsNull() => new FilterExpression<bool>(new NullableBooleanExpressionMediator(this), new NullableBooleanExpressionMediator(new LiteralExpression<bool>(DBNull.Value)), FilterExpressionOperator.Equal);
        public override FilterExpression<bool> IsNotNull() => new FilterExpression<bool>(new NullableBooleanExpressionMediator(this), new NullableBooleanExpressionMediator(new LiteralExpression<bool>(DBNull.Value)), FilterExpressionOperator.NotEqual);
        #endregion

        #region set
        public override AssignmentExpression Set(bool value) => new AssignmentExpression(new NullableBooleanExpressionMediator(this), new BooleanExpressionMediator(new LiteralExpression<bool>(value)));
        public override AssignmentExpression Set(ExpressionMediator<bool> value) => new AssignmentExpression(new NullableBooleanExpressionMediator(this), value);
        public override AssignmentExpression Set(bool? value) => new AssignmentExpression(new NullableBooleanExpressionMediator(this), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(value)));
        public override AssignmentExpression Set(NullableExpressionMediator<bool> value) => new AssignmentExpression(new NullableBooleanExpressionMediator(this), value);
        #endregion

        #region insert
        public override InsertExpression Insert(bool value) => new InsertExpression(this, new BooleanExpressionMediator(new LiteralExpression<bool>(value)));
        public override InsertExpression Insert(bool? value) => new InsertExpression(this, new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(value)));
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new NullableBooleanExpressionMediator(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new NullableBooleanExpressionMediator(this), OrderExpressionDirection.DESC);
        #endregion

        #region implicit operators
        public static implicit operator SelectExpression<bool?>(NullableBooleanFieldExpression a) => new SelectExpression<bool?>(new NullableBooleanExpressionMediator(a));
        public static implicit operator NullableBooleanExpressionMediator(NullableBooleanFieldExpression a) => new NullableBooleanExpressionMediator(a);
        public static implicit operator OrderByExpression(NullableBooleanFieldExpression a) => new OrderByExpression(new NullableBooleanExpressionMediator(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(NullableBooleanFieldExpression a) => new GroupByExpression(new NullableBooleanExpressionMediator(a));
        #endregion

        #region arithmetic operators
        #region TValue
        #endregion

        #region mediator
        #endregion
        #endregion

        #region filter operators
        #region DBNull
        public static FilterExpression<bool?> operator ==(NullableBooleanFieldExpression a, DBNull b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableBooleanFieldExpression a, DBNull b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator ==(DBNull a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(DBNull a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.NotEqual);
        #endregion

        #region bool
        public static FilterExpression<bool?> operator ==(NullableBooleanFieldExpression a, bool b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableBooleanFieldExpression a, bool b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableBooleanFieldExpression a, bool b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableBooleanFieldExpression a, bool b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableBooleanFieldExpression a, bool b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableBooleanFieldExpression a, bool b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new BooleanExpressionMediator(new LiteralExpression<bool>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(bool a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool?>(a)), new BooleanExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(bool a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool?>(a)), new BooleanExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(bool a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool?>(a)), new BooleanExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(bool a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool?>(a)), new BooleanExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(bool a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool?>(a)), new BooleanExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(bool a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new BooleanExpressionMediator(new LiteralExpression<bool?>(a)), new BooleanExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableBooleanFieldExpression a, bool? b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableBooleanFieldExpression a, bool? b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableBooleanFieldExpression a, bool? b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableBooleanFieldExpression a, bool? b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableBooleanFieldExpression a, bool? b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableBooleanFieldExpression a, bool? b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(bool? a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(bool? a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(bool? a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(bool? a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(bool? a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(bool? a, NullableBooleanFieldExpression b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(new LiteralExpression<bool?>(a)), new NullableBooleanExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        
        #region mediator
        public static FilterExpression<bool?> operator ==(NullableBooleanFieldExpression a, BooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableBooleanFieldExpression a, BooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableBooleanFieldExpression a, BooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableBooleanFieldExpression a, BooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableBooleanFieldExpression a, BooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableBooleanFieldExpression a, BooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableBooleanFieldExpression a, NullableBooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableBooleanFieldExpression a, NullableBooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableBooleanFieldExpression a, NullableBooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableBooleanFieldExpression a, NullableBooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableBooleanFieldExpression a, NullableBooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableBooleanFieldExpression a, NullableBooleanExpressionMediator b) => new FilterExpression<bool?>(new NullableBooleanExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
    }
}