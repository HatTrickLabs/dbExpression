using System;


namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableDateTimeOffsetCastFunctionExpression
    {
        #region implicit operators
        public static implicit operator SelectExpression<DateTimeOffset?>(NullableDateTimeOffsetCastFunctionExpression a) => new SelectExpression<DateTimeOffset?>(new NullableDateTimeOffsetExpressionMediator(a));
        public static implicit operator NullableDateTimeOffsetExpressionMediator(NullableDateTimeOffsetCastFunctionExpression a) => new NullableDateTimeOffsetExpressionMediator(a);
        public static implicit operator OrderByExpression(NullableDateTimeOffsetCastFunctionExpression a) => new OrderByExpression(new DateTimeOffsetExpressionMediator(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(NullableDateTimeOffsetCastFunctionExpression a) => new GroupByExpression(new DateTimeOffsetExpressionMediator(a));
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new DateTimeOffsetExpressionMediator(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new DateTimeOffsetExpressionMediator(this), OrderExpressionDirection.DESC);
        #endregion

        #region arithmetic operators
        #region TValue
        #region bool



        
        #endregion

        #region byte
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, byte b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, byte b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(byte a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(byte a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, byte? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, byte? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(byte? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(byte? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region decimal
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, decimal b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, decimal b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(decimal a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(decimal a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, decimal? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, decimal? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(decimal? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(decimal? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region DateTime
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DateTime b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DateTime b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTime a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTime a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DateTime? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DateTime? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTime? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTime? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region DateTimeOffset
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region double
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, double b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, double b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(double a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(double a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, double? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, double? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(double? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(double? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region float
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, float b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, float b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(float a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(float a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, float? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, float? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(float? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(float? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region Guid



        
        #endregion

        #region short
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, short b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, short b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(short a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(short a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, short? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, short? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(short? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(short? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region int
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, int b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, int b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(int a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(int a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, int? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, int? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(int? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(int? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region long
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, long b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, long b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(long a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(long a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, long? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, long? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(long? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(long? a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region string
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, string b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new StringExpressionMediator(new LiteralExpression<string>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, string b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), new StringExpressionMediator(new LiteralExpression<string>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(string a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new StringExpressionMediator(new LiteralExpression<string>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(string a, NullableDateTimeOffsetCastFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new StringExpressionMediator(new LiteralExpression<string>(a)), new NullableDateTimeOffsetExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        
        #endregion

        #endregion

        #region mediator
        #region bool

        #endregion

        #region byte
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, ByteExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, ByteExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableByteExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableByteExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region decimal
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DecimalExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DecimalExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region DateTime
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DateTimeExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DateTimeExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region DateTimeOffset
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region double
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, DoubleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, DoubleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region float
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, SingleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, SingleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableSingleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableSingleExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region Guid

        #endregion

        #region short
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, Int16ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, Int16ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region int
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, Int32ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, Int32ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region long
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, Int64ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, Int64ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region string
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeOffsetCastFunctionExpression a, StringExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeOffsetCastFunctionExpression a, StringExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        #endregion

        #endregion
        #endregion

        #region filter operators
        #region TValue
        #region DateTimeOffset
        public static FilterExpression<bool?> operator ==(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(DateTimeOffset a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffset? b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(DateTimeOffset? a, NullableDateTimeOffsetCastFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeOffsetExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        public static FilterExpression<bool?> operator ==(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeOffsetCastFunctionExpression a, DateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeOffsetCastFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
    }
}