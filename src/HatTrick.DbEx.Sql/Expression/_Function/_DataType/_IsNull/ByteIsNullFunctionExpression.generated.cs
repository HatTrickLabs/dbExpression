
using System;


namespace HatTrick.DbEx.Sql.Expression
{
    public partial class ByteIsNullFunctionExpression
    {
        #region implicit operators
        public static implicit operator SelectExpression<byte>(ByteIsNullFunctionExpression a) => new SelectExpression<byte>(new ByteExpressionMediator(a));
        public static implicit operator ByteExpressionMediator(ByteIsNullFunctionExpression a) => new ByteExpressionMediator(a);
        public static implicit operator OrderByExpression(ByteIsNullFunctionExpression a) => new OrderByExpression(new ByteExpressionMediator(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(ByteIsNullFunctionExpression a) => new GroupByExpression(new ByteExpressionMediator(a));
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new ByteExpressionMediator(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new ByteExpressionMediator(this), OrderExpressionDirection.DESC);
        #endregion

        #region arithmetic operators
        #region TValue
        #region bool



        #endregion

        #region byte
        public static ByteExpressionMediator operator +(ByteIsNullFunctionExpression a, byte b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Add));
        public static ByteExpressionMediator operator -(ByteIsNullFunctionExpression a, byte b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Subtract));
        public static ByteExpressionMediator operator *(ByteIsNullFunctionExpression a, byte b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Multiply));
        public static ByteExpressionMediator operator /(ByteIsNullFunctionExpression a, byte b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Divide));
        public static ByteExpressionMediator operator %(ByteIsNullFunctionExpression a, byte b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Modulo));

        public static ByteExpressionMediator operator +(byte a, ByteIsNullFunctionExpression b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static ByteExpressionMediator operator -(byte a, ByteIsNullFunctionExpression b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static ByteExpressionMediator operator *(byte a, ByteIsNullFunctionExpression b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static ByteExpressionMediator operator /(byte a, ByteIsNullFunctionExpression b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static ByteExpressionMediator operator %(byte a, ByteIsNullFunctionExpression b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableByteExpressionMediator operator +(ByteIsNullFunctionExpression a, byte? b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableByteExpressionMediator operator -(ByteIsNullFunctionExpression a, byte? b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableByteExpressionMediator operator *(ByteIsNullFunctionExpression a, byte? b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableByteExpressionMediator operator /(ByteIsNullFunctionExpression a, byte? b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableByteExpressionMediator operator %(ByteIsNullFunctionExpression a, byte? b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableByteExpressionMediator operator +(byte? a, ByteIsNullFunctionExpression b) => new NullableByteExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableByteExpressionMediator operator -(byte? a, ByteIsNullFunctionExpression b) => new NullableByteExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableByteExpressionMediator operator *(byte? a, ByteIsNullFunctionExpression b) => new NullableByteExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableByteExpressionMediator operator /(byte? a, ByteIsNullFunctionExpression b) => new NullableByteExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableByteExpressionMediator operator %(byte? a, ByteIsNullFunctionExpression b) => new NullableByteExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region decimal
        public static DecimalExpressionMediator operator +(ByteIsNullFunctionExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Add));
        public static DecimalExpressionMediator operator -(ByteIsNullFunctionExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Subtract));
        public static DecimalExpressionMediator operator *(ByteIsNullFunctionExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Multiply));
        public static DecimalExpressionMediator operator /(ByteIsNullFunctionExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Divide));
        public static DecimalExpressionMediator operator %(ByteIsNullFunctionExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Modulo));

        public static DecimalExpressionMediator operator +(decimal a, ByteIsNullFunctionExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static DecimalExpressionMediator operator -(decimal a, ByteIsNullFunctionExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static DecimalExpressionMediator operator *(decimal a, ByteIsNullFunctionExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static DecimalExpressionMediator operator /(decimal a, ByteIsNullFunctionExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static DecimalExpressionMediator operator %(decimal a, ByteIsNullFunctionExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(ByteIsNullFunctionExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(ByteIsNullFunctionExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(ByteIsNullFunctionExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(ByteIsNullFunctionExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(ByteIsNullFunctionExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(decimal? a, ByteIsNullFunctionExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(decimal? a, ByteIsNullFunctionExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(decimal? a, ByteIsNullFunctionExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(decimal? a, ByteIsNullFunctionExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(decimal? a, ByteIsNullFunctionExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new DecimalExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region DateTime
        public static DateTimeExpressionMediator operator +(ByteIsNullFunctionExpression a, DateTime b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Add));
        public static DateTimeExpressionMediator operator -(ByteIsNullFunctionExpression a, DateTime b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Subtract));
        public static DateTimeExpressionMediator operator *(ByteIsNullFunctionExpression a, DateTime b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Multiply));
        public static DateTimeExpressionMediator operator /(ByteIsNullFunctionExpression a, DateTime b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Divide));
        public static DateTimeExpressionMediator operator %(ByteIsNullFunctionExpression a, DateTime b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Modulo));

        public static DateTimeExpressionMediator operator +(DateTime a, ByteIsNullFunctionExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static DateTimeExpressionMediator operator -(DateTime a, ByteIsNullFunctionExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static DateTimeExpressionMediator operator *(DateTime a, ByteIsNullFunctionExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static DateTimeExpressionMediator operator /(DateTime a, ByteIsNullFunctionExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static DateTimeExpressionMediator operator %(DateTime a, ByteIsNullFunctionExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDateTimeExpressionMediator operator +(ByteIsNullFunctionExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(ByteIsNullFunctionExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDateTimeExpressionMediator operator *(ByteIsNullFunctionExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDateTimeExpressionMediator operator /(ByteIsNullFunctionExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDateTimeExpressionMediator operator %(ByteIsNullFunctionExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDateTimeExpressionMediator operator +(DateTime? a, ByteIsNullFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(DateTime? a, ByteIsNullFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDateTimeExpressionMediator operator *(DateTime? a, ByteIsNullFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDateTimeExpressionMediator operator /(DateTime? a, ByteIsNullFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDateTimeExpressionMediator operator %(DateTime? a, ByteIsNullFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new DateTimeExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region DateTimeOffset
        public static DateTimeOffsetExpressionMediator operator +(ByteIsNullFunctionExpression a, DateTimeOffset b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Add));
        public static DateTimeOffsetExpressionMediator operator -(ByteIsNullFunctionExpression a, DateTimeOffset b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Subtract));
        public static DateTimeOffsetExpressionMediator operator *(ByteIsNullFunctionExpression a, DateTimeOffset b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Multiply));
        public static DateTimeOffsetExpressionMediator operator /(ByteIsNullFunctionExpression a, DateTimeOffset b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Divide));
        public static DateTimeOffsetExpressionMediator operator %(ByteIsNullFunctionExpression a, DateTimeOffset b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Modulo));

        public static DateTimeOffsetExpressionMediator operator +(DateTimeOffset a, ByteIsNullFunctionExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static DateTimeOffsetExpressionMediator operator -(DateTimeOffset a, ByteIsNullFunctionExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static DateTimeOffsetExpressionMediator operator *(DateTimeOffset a, ByteIsNullFunctionExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static DateTimeOffsetExpressionMediator operator /(DateTimeOffset a, ByteIsNullFunctionExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static DateTimeOffsetExpressionMediator operator %(DateTimeOffset a, ByteIsNullFunctionExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDateTimeOffsetExpressionMediator operator +(ByteIsNullFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(ByteIsNullFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDateTimeOffsetExpressionMediator operator *(ByteIsNullFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDateTimeOffsetExpressionMediator operator /(ByteIsNullFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDateTimeOffsetExpressionMediator operator %(ByteIsNullFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset? a, ByteIsNullFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset? a, ByteIsNullFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDateTimeOffsetExpressionMediator operator *(DateTimeOffset? a, ByteIsNullFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDateTimeOffsetExpressionMediator operator /(DateTimeOffset? a, ByteIsNullFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDateTimeOffsetExpressionMediator operator %(DateTimeOffset? a, ByteIsNullFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new DateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region double
        public static DoubleExpressionMediator operator +(ByteIsNullFunctionExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Add));
        public static DoubleExpressionMediator operator -(ByteIsNullFunctionExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Subtract));
        public static DoubleExpressionMediator operator *(ByteIsNullFunctionExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Multiply));
        public static DoubleExpressionMediator operator /(ByteIsNullFunctionExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Divide));
        public static DoubleExpressionMediator operator %(ByteIsNullFunctionExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Modulo));

        public static DoubleExpressionMediator operator +(double a, ByteIsNullFunctionExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static DoubleExpressionMediator operator -(double a, ByteIsNullFunctionExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static DoubleExpressionMediator operator *(double a, ByteIsNullFunctionExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static DoubleExpressionMediator operator /(double a, ByteIsNullFunctionExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static DoubleExpressionMediator operator %(double a, ByteIsNullFunctionExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(ByteIsNullFunctionExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(ByteIsNullFunctionExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(ByteIsNullFunctionExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(ByteIsNullFunctionExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(ByteIsNullFunctionExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(double? a, ByteIsNullFunctionExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(double? a, ByteIsNullFunctionExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(double? a, ByteIsNullFunctionExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(double? a, ByteIsNullFunctionExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(double? a, ByteIsNullFunctionExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new DoubleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region float
        public static SingleExpressionMediator operator +(ByteIsNullFunctionExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Add));
        public static SingleExpressionMediator operator -(ByteIsNullFunctionExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Subtract));
        public static SingleExpressionMediator operator *(ByteIsNullFunctionExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Multiply));
        public static SingleExpressionMediator operator /(ByteIsNullFunctionExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Divide));
        public static SingleExpressionMediator operator %(ByteIsNullFunctionExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Modulo));

        public static SingleExpressionMediator operator +(float a, ByteIsNullFunctionExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static SingleExpressionMediator operator -(float a, ByteIsNullFunctionExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static SingleExpressionMediator operator *(float a, ByteIsNullFunctionExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static SingleExpressionMediator operator /(float a, ByteIsNullFunctionExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static SingleExpressionMediator operator %(float a, ByteIsNullFunctionExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(ByteIsNullFunctionExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(ByteIsNullFunctionExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(ByteIsNullFunctionExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(ByteIsNullFunctionExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(ByteIsNullFunctionExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(float? a, ByteIsNullFunctionExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(float? a, ByteIsNullFunctionExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(float? a, ByteIsNullFunctionExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(float? a, ByteIsNullFunctionExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(float? a, ByteIsNullFunctionExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new SingleExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region Guid



        #endregion

        #region short
        public static Int16ExpressionMediator operator +(ByteIsNullFunctionExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(ByteIsNullFunctionExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(ByteIsNullFunctionExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(ByteIsNullFunctionExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(ByteIsNullFunctionExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Modulo));

        public static Int16ExpressionMediator operator +(short a, ByteIsNullFunctionExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(short a, ByteIsNullFunctionExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(short a, ByteIsNullFunctionExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(short a, ByteIsNullFunctionExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(short a, ByteIsNullFunctionExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(ByteIsNullFunctionExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(ByteIsNullFunctionExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(ByteIsNullFunctionExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(ByteIsNullFunctionExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(ByteIsNullFunctionExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(short? a, ByteIsNullFunctionExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(short? a, ByteIsNullFunctionExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(short? a, ByteIsNullFunctionExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(short? a, ByteIsNullFunctionExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(short? a, ByteIsNullFunctionExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new Int16ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region int
        public static Int32ExpressionMediator operator +(ByteIsNullFunctionExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Add));
        public static Int32ExpressionMediator operator -(ByteIsNullFunctionExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Subtract));
        public static Int32ExpressionMediator operator *(ByteIsNullFunctionExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Multiply));
        public static Int32ExpressionMediator operator /(ByteIsNullFunctionExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Divide));
        public static Int32ExpressionMediator operator %(ByteIsNullFunctionExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Modulo));

        public static Int32ExpressionMediator operator +(int a, ByteIsNullFunctionExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static Int32ExpressionMediator operator -(int a, ByteIsNullFunctionExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static Int32ExpressionMediator operator *(int a, ByteIsNullFunctionExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static Int32ExpressionMediator operator /(int a, ByteIsNullFunctionExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static Int32ExpressionMediator operator %(int a, ByteIsNullFunctionExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(ByteIsNullFunctionExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(ByteIsNullFunctionExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(ByteIsNullFunctionExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(ByteIsNullFunctionExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(ByteIsNullFunctionExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(int? a, ByteIsNullFunctionExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(int? a, ByteIsNullFunctionExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(int? a, ByteIsNullFunctionExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(int? a, ByteIsNullFunctionExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(int? a, ByteIsNullFunctionExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new Int32ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region long
        public static Int64ExpressionMediator operator +(ByteIsNullFunctionExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Add));
        public static Int64ExpressionMediator operator -(ByteIsNullFunctionExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Subtract));
        public static Int64ExpressionMediator operator *(ByteIsNullFunctionExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Multiply));
        public static Int64ExpressionMediator operator /(ByteIsNullFunctionExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Divide));
        public static Int64ExpressionMediator operator %(ByteIsNullFunctionExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Modulo));

        public static Int64ExpressionMediator operator +(long a, ByteIsNullFunctionExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static Int64ExpressionMediator operator -(long a, ByteIsNullFunctionExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static Int64ExpressionMediator operator *(long a, ByteIsNullFunctionExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static Int64ExpressionMediator operator /(long a, ByteIsNullFunctionExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static Int64ExpressionMediator operator %(long a, ByteIsNullFunctionExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(ByteIsNullFunctionExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(ByteIsNullFunctionExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(ByteIsNullFunctionExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(ByteIsNullFunctionExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(ByteIsNullFunctionExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(long? a, ByteIsNullFunctionExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(long? a, ByteIsNullFunctionExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(long? a, ByteIsNullFunctionExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(long? a, ByteIsNullFunctionExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(long? a, ByteIsNullFunctionExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new Int64ExpressionMediator(b), ArithmeticExpressionOperator.Modulo));
        #endregion

        #region string
        public static StringExpressionMediator operator +(ByteIsNullFunctionExpression a, string b) => new StringExpressionMediator(new ArithmeticExpression(new StringExpressionMediator(a), new StringExpressionMediator(new LiteralExpression<string>(b)), ArithmeticExpressionOperator.Add));

        public static StringExpressionMediator operator +(string a, ByteIsNullFunctionExpression b) => new StringExpressionMediator(new ArithmeticExpression(new StringExpressionMediator(new LiteralExpression<string>(a)), new StringExpressionMediator(b), ArithmeticExpressionOperator.Add));


        #endregion

        #endregion

        #region mediator
        #region bool

        #endregion

        #region byte
        public static ByteExpressionMediator operator +(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static ByteExpressionMediator operator -(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static ByteExpressionMediator operator *(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static ByteExpressionMediator operator /(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static ByteExpressionMediator operator %(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new ByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableByteExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableByteExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableByteExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableByteExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableByteExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new NullableByteExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region decimal
        public static DecimalExpressionMediator operator +(ByteIsNullFunctionExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static DecimalExpressionMediator operator -(ByteIsNullFunctionExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static DecimalExpressionMediator operator *(ByteIsNullFunctionExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static DecimalExpressionMediator operator /(ByteIsNullFunctionExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static DecimalExpressionMediator operator %(ByteIsNullFunctionExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region DateTime
        public static DateTimeExpressionMediator operator +(ByteIsNullFunctionExpression a, DateTimeExpressionMediator b) => new DateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static DateTimeExpressionMediator operator -(ByteIsNullFunctionExpression a, DateTimeExpressionMediator b) => new DateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static DateTimeExpressionMediator operator *(ByteIsNullFunctionExpression a, DateTimeExpressionMediator b) => new DateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static DateTimeExpressionMediator operator /(ByteIsNullFunctionExpression a, DateTimeExpressionMediator b) => new DateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static DateTimeExpressionMediator operator %(ByteIsNullFunctionExpression a, DateTimeExpressionMediator b) => new DateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableDateTimeExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableDateTimeExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableDateTimeExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableDateTimeExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region DateTimeOffset
        public static DateTimeOffsetExpressionMediator operator +(ByteIsNullFunctionExpression a, DateTimeOffsetExpressionMediator b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static DateTimeOffsetExpressionMediator operator -(ByteIsNullFunctionExpression a, DateTimeOffsetExpressionMediator b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static DateTimeOffsetExpressionMediator operator *(ByteIsNullFunctionExpression a, DateTimeOffsetExpressionMediator b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static DateTimeOffsetExpressionMediator operator /(ByteIsNullFunctionExpression a, DateTimeOffsetExpressionMediator b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static DateTimeOffsetExpressionMediator operator %(ByteIsNullFunctionExpression a, DateTimeOffsetExpressionMediator b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableDateTimeOffsetExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableDateTimeOffsetExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableDateTimeOffsetExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableDateTimeOffsetExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region double
        public static DoubleExpressionMediator operator +(ByteIsNullFunctionExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static DoubleExpressionMediator operator -(ByteIsNullFunctionExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static DoubleExpressionMediator operator *(ByteIsNullFunctionExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static DoubleExpressionMediator operator /(ByteIsNullFunctionExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static DoubleExpressionMediator operator %(ByteIsNullFunctionExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region float
        public static SingleExpressionMediator operator +(ByteIsNullFunctionExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static SingleExpressionMediator operator -(ByteIsNullFunctionExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static SingleExpressionMediator operator *(ByteIsNullFunctionExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static SingleExpressionMediator operator /(ByteIsNullFunctionExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static SingleExpressionMediator operator %(ByteIsNullFunctionExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region Guid

        #endregion

        #region short
        public static Int16ExpressionMediator operator +(ByteIsNullFunctionExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(ByteIsNullFunctionExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(ByteIsNullFunctionExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(ByteIsNullFunctionExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(ByteIsNullFunctionExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region int
        public static Int32ExpressionMediator operator +(ByteIsNullFunctionExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static Int32ExpressionMediator operator -(ByteIsNullFunctionExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static Int32ExpressionMediator operator *(ByteIsNullFunctionExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static Int32ExpressionMediator operator /(ByteIsNullFunctionExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static Int32ExpressionMediator operator %(ByteIsNullFunctionExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region long
        public static Int64ExpressionMediator operator +(ByteIsNullFunctionExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static Int64ExpressionMediator operator -(ByteIsNullFunctionExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static Int64ExpressionMediator operator *(ByteIsNullFunctionExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static Int64ExpressionMediator operator /(ByteIsNullFunctionExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static Int64ExpressionMediator operator %(ByteIsNullFunctionExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(ByteIsNullFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(ByteIsNullFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(ByteIsNullFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(ByteIsNullFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(ByteIsNullFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Modulo));
        #endregion

        #region string
        public static StringExpressionMediator operator +(ByteIsNullFunctionExpression a, StringExpressionMediator b) => new StringExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(a), b, ArithmeticExpressionOperator.Add));

        #endregion

        #endregion
        #endregion

        #region filter operators
        #region TValue
        #region byte
        public static FilterExpression<bool> operator ==(ByteIsNullFunctionExpression a, byte b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool> operator !=(ByteIsNullFunctionExpression a, byte b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool> operator <(ByteIsNullFunctionExpression a, byte b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool> operator <=(ByteIsNullFunctionExpression a, byte b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool> operator >(ByteIsNullFunctionExpression a, byte b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool> operator >=(ByteIsNullFunctionExpression a, byte b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool> operator ==(byte a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool> operator !=(byte a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool> operator <(byte a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool> operator <=(byte a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool> operator >(byte a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool> operator >=(byte a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool> operator ==(ByteIsNullFunctionExpression a, byte? b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte?>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool> operator !=(ByteIsNullFunctionExpression a, byte? b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte?>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool> operator <(ByteIsNullFunctionExpression a, byte? b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte?>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool> operator <=(ByteIsNullFunctionExpression a, byte? b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte?>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool> operator >(ByteIsNullFunctionExpression a, byte? b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte?>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool> operator >=(ByteIsNullFunctionExpression a, byte? b) => new FilterExpression<bool>(new ByteExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte?>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool> operator ==(byte? a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool> operator !=(byte? a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool> operator <(byte? a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool> operator <=(byte? a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool> operator >(byte? a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool> operator >=(byte? a, ByteIsNullFunctionExpression b) => new FilterExpression<bool>(new ByteExpressionMediator(new LiteralExpression<byte?>(a)), new ByteExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        public static FilterExpression<bool> operator ==(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new FilterExpression<bool>(new ByteExpressionMediator(a), b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool> operator !=(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new FilterExpression<bool>(new ByteExpressionMediator(a), b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool> operator <(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new FilterExpression<bool>(new ByteExpressionMediator(a), b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool> operator <=(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new FilterExpression<bool>(new ByteExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool> operator >(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new FilterExpression<bool>(new ByteExpressionMediator(a), b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool> operator >=(ByteIsNullFunctionExpression a, ByteExpressionMediator b) => new FilterExpression<bool>(new ByteExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new FilterExpression<bool?>(new ByteExpressionMediator(a), b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new FilterExpression<bool?>(new ByteExpressionMediator(a), b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new FilterExpression<bool?>(new ByteExpressionMediator(a), b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new FilterExpression<bool?>(new ByteExpressionMediator(a), b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new FilterExpression<bool?>(new ByteExpressionMediator(a), b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(ByteIsNullFunctionExpression a, NullableByteExpressionMediator b) => new FilterExpression<bool?>(new ByteExpressionMediator(a), b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
    }
}