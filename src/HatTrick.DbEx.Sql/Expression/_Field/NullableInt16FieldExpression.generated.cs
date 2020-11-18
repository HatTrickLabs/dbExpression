using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableInt16FieldExpression
    {
        #region in value set
        public override FilterExpression<bool> In(params short[] value) => value is object ? new FilterExpression<bool>(new Int16ExpressionMediator(this), new NullableInt16ExpressionMediator(new InExpression<short>(value)), FilterExpressionOperator.None) : null;
        public override FilterExpression<bool> In(IEnumerable<short> value) => value is object ? new FilterExpression<bool>(new Int16ExpressionMediator(this), new NullableInt16ExpressionMediator(new InExpression<short>(value)), FilterExpressionOperator.None) : null;
        public override FilterExpression<bool> In(params short?[] value) => value is object ? new FilterExpression<bool>(new NullableInt16ExpressionMediator(this), new NullableInt16ExpressionMediator(new InExpression<short?>(value)), FilterExpressionOperator.None) : null;
        public override FilterExpression<bool> In(IEnumerable<short?> value) => value is object ? new FilterExpression<bool>(new NullableInt16ExpressionMediator(this), new NullableInt16ExpressionMediator(new InExpression<short?>(value)), FilterExpressionOperator.None) : null;

        #endregion

        #region set
        public override AssignmentExpression Set(short value) => new AssignmentExpression(this, new Int16ExpressionMediator(new LiteralExpression<short>(value)));
        public virtual AssignmentExpression Set(Int16Element value) => new AssignmentExpression(this, value);
        public override AssignmentExpression Set(short? value) => new AssignmentExpression(this, new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(value)));
        public override AssignmentExpression Set(DBNull value) => new AssignmentExpression(this, new NullableInt16ExpressionMediator(new LiteralExpression<short?>(null)));
        public virtual AssignmentExpression Set(NullInt16Element value) => new AssignmentExpression(this, value);

        #endregion

        #region insert
        public override InsertExpression Insert(short value) => new InsertExpression(this, new Int16ExpressionMediator(new LiteralExpression<short>(value)));
        public override InsertExpression Insert(short? value) => new InsertExpression(this, new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(value)));

        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new NullableInt16ExpressionMediator(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new NullableInt16ExpressionMediator(this), OrderExpressionDirection.DESC);
        #endregion

        #region implicit operators
        public static implicit operator SelectExpression<short?>(NullableInt16FieldExpression a) => new SelectExpression<short?>(new NullableInt16ExpressionMediator(a));
        public static implicit operator NullableInt16ExpressionMediator(NullableInt16FieldExpression a) => new NullableInt16ExpressionMediator(a);
        public static implicit operator OrderByExpression(NullableInt16FieldExpression a) => new OrderByExpression(new NullableInt16ExpressionMediator(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(NullableInt16FieldExpression a) => new GroupByExpression(new NullableInt16ExpressionMediator(a));
        #endregion

        #region arithmetic operators
        #region data type
        #region byte
        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, byte b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, byte b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, byte b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, byte b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, byte b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(byte a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(byte a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(byte a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(byte a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(byte a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(a), new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(byte? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(byte? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(byte? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(byte? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(byte? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new NullableLiteralExpression<byte?>(a)), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region decimal
        public static NullableDecimalExpressionMediator operator +(NullableInt16FieldExpression a, decimal b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(NullableInt16FieldExpression a, decimal b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(NullableInt16FieldExpression a, decimal b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(NullableInt16FieldExpression a, decimal b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(NullableInt16FieldExpression a, decimal b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(decimal a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(decimal a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(decimal a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(decimal a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(decimal a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(NullableInt16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(NullableInt16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(NullableInt16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(NullableInt16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(NullableInt16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(decimal? a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(decimal? a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(decimal? a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(decimal? a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(decimal? a, NullableInt16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new NullableLiteralExpression<decimal?>(a)), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region DateTime
        public static NullableDateTimeExpressionMediator operator +(NullableInt16FieldExpression a, DateTime b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableInt16FieldExpression a, DateTime b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(DateTime a, NullableInt16FieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(DateTime a, NullableInt16FieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableInt16FieldExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new NullableLiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableInt16FieldExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new NullableLiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(DateTime? a, NullableInt16FieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new NullableLiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(DateTime? a, NullableInt16FieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new NullableLiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region DateTimeOffset
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableInt16FieldExpression a, DateTimeOffset b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableInt16FieldExpression a, DateTimeOffset b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset a, NullableInt16FieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset a, NullableInt16FieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableInt16FieldExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new NullableLiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableInt16FieldExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new NullableLiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset? a, NullableInt16FieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new NullableLiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset? a, NullableInt16FieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new NullableLiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region double
        public static NullableDoubleExpressionMediator operator +(NullableInt16FieldExpression a, double b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(NullableInt16FieldExpression a, double b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(NullableInt16FieldExpression a, double b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(NullableInt16FieldExpression a, double b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(NullableInt16FieldExpression a, double b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(double a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(double a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(double a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(double a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(double a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(NullableInt16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(NullableInt16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(NullableInt16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(NullableInt16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(NullableInt16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(double? a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(double? a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(double? a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(double? a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(double? a, NullableInt16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new NullableLiteralExpression<double?>(a)), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region float
        public static NullableSingleExpressionMediator operator +(NullableInt16FieldExpression a, float b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(NullableInt16FieldExpression a, float b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(NullableInt16FieldExpression a, float b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(NullableInt16FieldExpression a, float b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(NullableInt16FieldExpression a, float b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(float a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(float a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(float a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(float a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(float a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(NullableInt16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(NullableInt16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(NullableInt16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(NullableInt16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(NullableInt16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(a), new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(float? a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(float? a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(float? a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(float? a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(float? a, NullableInt16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new NullableLiteralExpression<float?>(a)), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region short
        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, short b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, short b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, short b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, short b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, short b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(short a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(short a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(short a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(short a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(short a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(short? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(short? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(short? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(short? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(short? a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region int
        public static NullableInt32ExpressionMediator operator +(NullableInt16FieldExpression a, int b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(NullableInt16FieldExpression a, int b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(NullableInt16FieldExpression a, int b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(NullableInt16FieldExpression a, int b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(NullableInt16FieldExpression a, int b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(int a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(int a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(int a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(int a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(int a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(NullableInt16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(NullableInt16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(NullableInt16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(NullableInt16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(NullableInt16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(a), new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(int? a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(int? a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(int? a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(int? a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(int? a, NullableInt16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new NullableLiteralExpression<int?>(a)), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region long
        public static NullableInt64ExpressionMediator operator +(NullableInt16FieldExpression a, long b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(NullableInt16FieldExpression a, long b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(NullableInt16FieldExpression a, long b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(NullableInt16FieldExpression a, long b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(NullableInt16FieldExpression a, long b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(long a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(long a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(long a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(long a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(long a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(NullableInt16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(NullableInt16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(NullableInt16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(NullableInt16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(NullableInt16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(a), new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(long? a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(long? a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(long? a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(long? a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(long? a, NullableInt16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new NullableLiteralExpression<long?>(a)), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region TimeSpan



        #endregion
        
        #endregion

        #region fields

        #region byte
        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, ByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, ByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, ByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, ByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, ByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableByteExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        

        #region decimal
        public static NullableDecimalExpressionMediator operator +(NullableInt16FieldExpression a, DecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(NullableInt16FieldExpression a, DecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(NullableInt16FieldExpression a, DecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(NullableInt16FieldExpression a, DecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(NullableInt16FieldExpression a, DecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(NullableInt16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(NullableInt16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(NullableInt16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(NullableInt16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(NullableInt16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDecimalExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        

        #region DateTime
        public static NullableDateTimeExpressionMediator operator +(NullableInt16FieldExpression a, DateTimeFieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableInt16FieldExpression a, DateTimeFieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableInt16FieldExpression a, NullableDateTimeFieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableInt16FieldExpression a, NullableDateTimeFieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        #endregion

        

        #region DateTimeOffset
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableInt16FieldExpression a, DateTimeOffsetFieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableInt16FieldExpression a, DateTimeOffsetFieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableInt16FieldExpression a, NullableDateTimeOffsetFieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableInt16FieldExpression a, NullableDateTimeOffsetFieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        #endregion

        

        #region double
        public static NullableDoubleExpressionMediator operator +(NullableInt16FieldExpression a, DoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(NullableInt16FieldExpression a, DoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(NullableInt16FieldExpression a, DoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(NullableInt16FieldExpression a, DoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(NullableInt16FieldExpression a, DoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(NullableInt16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(NullableInt16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(NullableInt16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(NullableInt16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(NullableInt16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableDoubleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        

        #region float
        public static NullableSingleExpressionMediator operator +(NullableInt16FieldExpression a, SingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(NullableInt16FieldExpression a, SingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(NullableInt16FieldExpression a, SingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(NullableInt16FieldExpression a, SingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(NullableInt16FieldExpression a, SingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(NullableInt16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(NullableInt16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(NullableInt16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(NullableInt16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(NullableInt16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableSingleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        

        #region short
        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(NullableInt16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(NullableInt16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(NullableInt16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(NullableInt16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(NullableInt16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        

        #region int
        public static NullableInt32ExpressionMediator operator +(NullableInt16FieldExpression a, Int32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(NullableInt16FieldExpression a, Int32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(NullableInt16FieldExpression a, Int32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(NullableInt16FieldExpression a, Int32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(NullableInt16FieldExpression a, Int32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(NullableInt16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(NullableInt16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(NullableInt16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(NullableInt16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(NullableInt16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt32ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        

        #region long
        public static NullableInt64ExpressionMediator operator +(NullableInt16FieldExpression a, Int64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(NullableInt16FieldExpression a, Int64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(NullableInt16FieldExpression a, Int64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(NullableInt16FieldExpression a, Int64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(NullableInt16FieldExpression a, Int64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(NullableInt16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(NullableInt16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(NullableInt16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(NullableInt16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(NullableInt16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(a), new NullableInt64ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        

        
        #endregion
        #endregion

        #region filter operators
        #region DBNull
        public static FilterExpression<bool?> operator ==(NullableInt16FieldExpression a, DBNull b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>()), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableInt16FieldExpression a, DBNull b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>()), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator ==(DBNull a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>()), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(DBNull a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>()), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.NotEqual);
        #endregion

        #region short
        public static FilterExpression<bool?> operator ==(NullableInt16FieldExpression a, short b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableInt16FieldExpression a, short b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableInt16FieldExpression a, short b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableInt16FieldExpression a, short b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableInt16FieldExpression a, short b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableInt16FieldExpression a, short b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(short a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new Int16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new Int16ExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(short a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new Int16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new Int16ExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(short a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new Int16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new Int16ExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(short a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new Int16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new Int16ExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(short a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new Int16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new Int16ExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(short a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new Int16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new Int16ExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableInt16FieldExpression a, short? b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableInt16FieldExpression a, short? b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableInt16FieldExpression a, short? b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableInt16FieldExpression a, short? b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableInt16FieldExpression a, short? b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableInt16FieldExpression a, short? b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(short? a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(short? a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(short? a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(short? a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(short? a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(short? a, NullableInt16FieldExpression b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(new NullableLiteralExpression<short?>(a)), new NullableInt16ExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        
        #region mediator
        public static FilterExpression<bool?> operator ==(NullableInt16FieldExpression a, Int16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableInt16FieldExpression a, Int16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableInt16FieldExpression a, Int16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableInt16FieldExpression a, Int16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableInt16FieldExpression a, Int16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableInt16FieldExpression a, Int16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableInt16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableInt16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableInt16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableInt16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableInt16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableInt16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpression<bool?>(new NullableInt16ExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
    }
}
