using System;


namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableDateTimeCoalesceFunctionExpression
    {
        #region implicit operators
        public static implicit operator NullableDateTimeExpressionMediator(NullableDateTimeCoalesceFunctionExpression a) => new NullableDateTimeExpressionMediator(a);
        public static implicit operator OrderByExpression(NullableDateTimeCoalesceFunctionExpression a) => new OrderByExpression(new DateTimeExpressionMediator(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(NullableDateTimeCoalesceFunctionExpression a) => new GroupByExpression(new DateTimeExpressionMediator(a));
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new DateTimeExpressionMediator(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new DateTimeExpressionMediator(this), OrderExpressionDirection.DESC);
        #endregion

        #region arithmetic operators
        #region TValue
        #region bool



        
        #endregion

        #region byte
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, byte b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, byte b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new ByteExpressionMediator(new LiteralExpression<byte>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(byte a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(byte a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new ByteExpressionMediator(new LiteralExpression<byte>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, byte? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, byte? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableByteExpressionMediator(new LiteralExpression<byte?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(byte? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(byte? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableByteExpressionMediator(new LiteralExpression<byte?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region decimal
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, decimal b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, decimal b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DecimalExpressionMediator(new LiteralExpression<decimal>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(decimal a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(decimal a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DecimalExpressionMediator(new LiteralExpression<decimal>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, decimal? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, decimal? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(decimal? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(decimal? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDecimalExpressionMediator(new LiteralExpression<decimal?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region DateTime
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region DateTimeOffset
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DateTimeOffset b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DateTimeOffset b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region double
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, double b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, double b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new DoubleExpressionMediator(new LiteralExpression<double>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(double a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(double a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new DoubleExpressionMediator(new LiteralExpression<double>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, double? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, double? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableDoubleExpressionMediator(new LiteralExpression<double?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(double? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(double? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDoubleExpressionMediator(new LiteralExpression<double?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region float
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, float b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, float b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new SingleExpressionMediator(new LiteralExpression<float>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(float a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(float a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new SingleExpressionMediator(new LiteralExpression<float>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, float? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, float? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableSingleExpressionMediator(new LiteralExpression<float?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(float? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(float? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableSingleExpressionMediator(new LiteralExpression<float?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region Guid



        
        #endregion

        #region short
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, short b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, short b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new Int16ExpressionMediator(new LiteralExpression<short>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(short a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(short a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new Int16ExpressionMediator(new LiteralExpression<short>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, short? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, short? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableInt16ExpressionMediator(new LiteralExpression<short?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(short? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(short? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt16ExpressionMediator(new LiteralExpression<short?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region int
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, int b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, int b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new Int32ExpressionMediator(new LiteralExpression<int>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(int a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(int a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new Int32ExpressionMediator(new LiteralExpression<int>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, int? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, int? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(int? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(int? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt32ExpressionMediator(new LiteralExpression<int?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region long
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, long b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, long b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new Int64ExpressionMediator(new LiteralExpression<long>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(long a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(long a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new Int64ExpressionMediator(new LiteralExpression<long>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, long? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, long? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), new NullableInt64ExpressionMediator(new LiteralExpression<long?>(b)), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(long? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(long? a, NullableDateTimeCoalesceFunctionExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableInt64ExpressionMediator(new LiteralExpression<long?>(a)), new NullableDateTimeExpressionMediator(b), ArithmeticExpressionOperator.Subtract));
        
        #endregion

        #region string


        
        #endregion

        #endregion

        #region mediator
        #region bool

        #endregion

        #region byte
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, ByteExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, ByteExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableByteExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableByteExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region decimal
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DecimalExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DecimalExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableDecimalExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region DateTime
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region DateTimeOffset
        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region double
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, DoubleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, DoubleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableDoubleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region float
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, SingleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, SingleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableSingleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableSingleExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region Guid

        #endregion

        #region short
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, Int16ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, Int16ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableInt16ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region int
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, Int32ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, Int32ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableInt32ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region long
        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, Int64ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, Int64ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(NullableDateTimeCoalesceFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(NullableDateTimeCoalesceFunctionExpression a, NullableInt64ExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new NullableDateTimeExpressionMediator(a), b, ArithmeticExpressionOperator.Subtract));
        #endregion

        #region string

        #endregion

        #endregion
        #endregion

        #region filter operators
        #region TValue
        #region DateTime
        public static FilterExpression<bool?> operator ==(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeCoalesceFunctionExpression a, DateTime b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(DateTime a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new DateTimeExpressionMediator(new LiteralExpression<DateTime>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeCoalesceFunctionExpression a, DateTime? b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(a), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(b)), FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(DateTime? a, NullableDateTimeCoalesceFunctionExpression b) => new FilterExpression<bool?>(new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(a)), new NullableDateTimeExpressionMediator(b), FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion

        #region mediator
        public static FilterExpression<bool?> operator ==(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeCoalesceFunctionExpression a, DateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual);

        public static FilterExpression<bool?> operator ==(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal);
        public static FilterExpression<bool?> operator !=(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual);
        public static FilterExpression<bool?> operator <(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan);
        public static FilterExpression<bool?> operator <=(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual);
        public static FilterExpression<bool?> operator >(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan);
        public static FilterExpression<bool?> operator >=(NullableDateTimeCoalesceFunctionExpression a, NullableDateTimeExpressionMediator b) => new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual);
        #endregion
        #endregion
    }
}