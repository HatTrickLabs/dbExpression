#region license
// Copyright (c) HatTrick Labs, LLC.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/HatTrickLabs/db-ex
#endregion

using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class Int16FieldExpression
    {
        #region in value set
        public override FilterExpressionSet In(params short[] value) => value is object ? new FilterExpressionSet(new FilterExpression<bool>(this, new InExpression<short>(this, value), FilterExpressionOperator.None)) : null;
        public override FilterExpressionSet In(IEnumerable<short> value) => value is object ? new FilterExpressionSet(new FilterExpression<bool>(this, new InExpression<short>(this, value), FilterExpressionOperator.None)) : null;
        #endregion

        #region implicit operators
        public static implicit operator Int16ExpressionMediator(Int16FieldExpression a) => new Int16ExpressionMediator(a);
        #endregion

        #region arithmetic operators
        #region data types
        #region byte
        public static Int16ExpressionMediator operator +(Int16FieldExpression a, byte b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte>(b, a), ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(Int16FieldExpression a, byte b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte>(b, a), ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(Int16FieldExpression a, byte b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte>(b, a), ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(Int16FieldExpression a, byte b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte>(b, a), ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(Int16FieldExpression a, byte b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte>(b, a), ArithmeticExpressionOperator.Modulo));

        public static Int16ExpressionMediator operator +(byte a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte>(a, b), b, ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(byte a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(byte a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(byte a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(byte a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte>(a, b), b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(Int16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(Int16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte?>(b, a), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(Int16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte?>(b, a), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(Int16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte?>(b, a), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(Int16FieldExpression a, byte? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<byte?>(b, a), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(byte? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(byte? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(byte? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte?>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(byte? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte?>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(byte? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<byte?>(a, b), b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region decimal
        public static DecimalExpressionMediator operator +(Int16FieldExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal>(b, a), ArithmeticExpressionOperator.Add));
        public static DecimalExpressionMediator operator -(Int16FieldExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal>(b, a), ArithmeticExpressionOperator.Subtract));
        public static DecimalExpressionMediator operator *(Int16FieldExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal>(b, a), ArithmeticExpressionOperator.Multiply));
        public static DecimalExpressionMediator operator /(Int16FieldExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal>(b, a), ArithmeticExpressionOperator.Divide));
        public static DecimalExpressionMediator operator %(Int16FieldExpression a, decimal b) => new DecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal>(b, a), ArithmeticExpressionOperator.Modulo));

        public static DecimalExpressionMediator operator +(decimal a, Int16FieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal>(a, b), b, ArithmeticExpressionOperator.Add));
        public static DecimalExpressionMediator operator -(decimal a, Int16FieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static DecimalExpressionMediator operator *(decimal a, Int16FieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static DecimalExpressionMediator operator /(decimal a, Int16FieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static DecimalExpressionMediator operator %(decimal a, Int16FieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal>(a, b), b, ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(Int16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(Int16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal?>(b, a), ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(Int16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal?>(b, a), ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(Int16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal?>(b, a), ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(Int16FieldExpression a, decimal? b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<decimal?>(b, a), ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(decimal? a, Int16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(decimal? a, Int16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(decimal? a, Int16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal?>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(decimal? a, Int16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal?>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(decimal? a, Int16FieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(new LiteralExpression<decimal?>(a, b), b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region DateTime
        public static DateTimeExpressionMediator operator +(Int16FieldExpression a, DateTime b) => new DateTimeExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTime>(b, a), ArithmeticExpressionOperator.Add));
        public static DateTimeExpressionMediator operator -(Int16FieldExpression a, DateTime b) => new DateTimeExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTime>(b, a), ArithmeticExpressionOperator.Subtract));

        public static DateTimeExpressionMediator operator +(DateTime a, Int16FieldExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTime>(a, b), b, ArithmeticExpressionOperator.Add));
        public static DateTimeExpressionMediator operator -(DateTime a, Int16FieldExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTime>(a, b), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(Int16FieldExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTime?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(Int16FieldExpression a, DateTime? b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTime?>(b, a), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(DateTime? a, Int16FieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTime?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(DateTime? a, Int16FieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTime?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region DateTimeOffset
        public static DateTimeOffsetExpressionMediator operator +(Int16FieldExpression a, DateTimeOffset b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTimeOffset>(b, a), ArithmeticExpressionOperator.Add));
        public static DateTimeOffsetExpressionMediator operator -(Int16FieldExpression a, DateTimeOffset b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTimeOffset>(b, a), ArithmeticExpressionOperator.Subtract));

        public static DateTimeOffsetExpressionMediator operator +(DateTimeOffset a, Int16FieldExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTimeOffset>(a, b), b, ArithmeticExpressionOperator.Add));
        public static DateTimeOffsetExpressionMediator operator -(DateTimeOffset a, Int16FieldExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTimeOffset>(a, b), b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(Int16FieldExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTimeOffset?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(Int16FieldExpression a, DateTimeOffset? b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<DateTimeOffset?>(b, a), ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(DateTimeOffset? a, Int16FieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTimeOffset?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(DateTimeOffset? a, Int16FieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(new LiteralExpression<DateTimeOffset?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region double
        public static DoubleExpressionMediator operator +(Int16FieldExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double>(b, a), ArithmeticExpressionOperator.Add));
        public static DoubleExpressionMediator operator -(Int16FieldExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double>(b, a), ArithmeticExpressionOperator.Subtract));
        public static DoubleExpressionMediator operator *(Int16FieldExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double>(b, a), ArithmeticExpressionOperator.Multiply));
        public static DoubleExpressionMediator operator /(Int16FieldExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double>(b, a), ArithmeticExpressionOperator.Divide));
        public static DoubleExpressionMediator operator %(Int16FieldExpression a, double b) => new DoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double>(b, a), ArithmeticExpressionOperator.Modulo));

        public static DoubleExpressionMediator operator +(double a, Int16FieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double>(a, b), b, ArithmeticExpressionOperator.Add));
        public static DoubleExpressionMediator operator -(double a, Int16FieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static DoubleExpressionMediator operator *(double a, Int16FieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static DoubleExpressionMediator operator /(double a, Int16FieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static DoubleExpressionMediator operator %(double a, Int16FieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double>(a, b), b, ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(Int16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(Int16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double?>(b, a), ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(Int16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double?>(b, a), ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(Int16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double?>(b, a), ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(Int16FieldExpression a, double? b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<double?>(b, a), ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(double? a, Int16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(double? a, Int16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(double? a, Int16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double?>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(double? a, Int16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double?>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(double? a, Int16FieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(new LiteralExpression<double?>(a, b), b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region float
        public static SingleExpressionMediator operator +(Int16FieldExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float>(b, a), ArithmeticExpressionOperator.Add));
        public static SingleExpressionMediator operator -(Int16FieldExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float>(b, a), ArithmeticExpressionOperator.Subtract));
        public static SingleExpressionMediator operator *(Int16FieldExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float>(b, a), ArithmeticExpressionOperator.Multiply));
        public static SingleExpressionMediator operator /(Int16FieldExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float>(b, a), ArithmeticExpressionOperator.Divide));
        public static SingleExpressionMediator operator %(Int16FieldExpression a, float b) => new SingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float>(b, a), ArithmeticExpressionOperator.Modulo));

        public static SingleExpressionMediator operator +(float a, Int16FieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float>(a, b), b, ArithmeticExpressionOperator.Add));
        public static SingleExpressionMediator operator -(float a, Int16FieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static SingleExpressionMediator operator *(float a, Int16FieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static SingleExpressionMediator operator /(float a, Int16FieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static SingleExpressionMediator operator %(float a, Int16FieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float>(a, b), b, ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(Int16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(Int16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float?>(b, a), ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(Int16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float?>(b, a), ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(Int16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float?>(b, a), ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(Int16FieldExpression a, float? b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<float?>(b, a), ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(float? a, Int16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(float? a, Int16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(float? a, Int16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float?>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(float? a, Int16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float?>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(float? a, Int16FieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(new LiteralExpression<float?>(a, b), b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region short
        public static Int16ExpressionMediator operator +(Int16FieldExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short>(b, a), ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(Int16FieldExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short>(b, a), ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(Int16FieldExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short>(b, a), ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(Int16FieldExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short>(b, a), ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(Int16FieldExpression a, short b) => new Int16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short>(b, a), ArithmeticExpressionOperator.Modulo));

        public static Int16ExpressionMediator operator +(short a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short>(a, b), b, ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(short a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(short a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(short a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(short a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short>(a, b), b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(Int16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(Int16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short?>(b, a), ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(Int16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short?>(b, a), ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(Int16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short?>(b, a), ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(Int16FieldExpression a, short? b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<short?>(b, a), ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(short? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(short? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(short? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short?>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(short? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short?>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(short? a, Int16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(new LiteralExpression<short?>(a, b), b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region int
        public static Int32ExpressionMediator operator +(Int16FieldExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int>(b, a), ArithmeticExpressionOperator.Add));
        public static Int32ExpressionMediator operator -(Int16FieldExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int>(b, a), ArithmeticExpressionOperator.Subtract));
        public static Int32ExpressionMediator operator *(Int16FieldExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int>(b, a), ArithmeticExpressionOperator.Multiply));
        public static Int32ExpressionMediator operator /(Int16FieldExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int>(b, a), ArithmeticExpressionOperator.Divide));
        public static Int32ExpressionMediator operator %(Int16FieldExpression a, int b) => new Int32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int>(b, a), ArithmeticExpressionOperator.Modulo));

        public static Int32ExpressionMediator operator +(int a, Int16FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int>(a, b), b, ArithmeticExpressionOperator.Add));
        public static Int32ExpressionMediator operator -(int a, Int16FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static Int32ExpressionMediator operator *(int a, Int16FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static Int32ExpressionMediator operator /(int a, Int16FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static Int32ExpressionMediator operator %(int a, Int16FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int>(a, b), b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(Int16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(Int16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int?>(b, a), ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(Int16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int?>(b, a), ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(Int16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int?>(b, a), ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(Int16FieldExpression a, int? b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<int?>(b, a), ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(int? a, Int16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(int? a, Int16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(int? a, Int16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int?>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(int? a, Int16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int?>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(int? a, Int16FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(new LiteralExpression<int?>(a, b), b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region long
        public static Int64ExpressionMediator operator +(Int16FieldExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long>(b, a), ArithmeticExpressionOperator.Add));
        public static Int64ExpressionMediator operator -(Int16FieldExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long>(b, a), ArithmeticExpressionOperator.Subtract));
        public static Int64ExpressionMediator operator *(Int16FieldExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long>(b, a), ArithmeticExpressionOperator.Multiply));
        public static Int64ExpressionMediator operator /(Int16FieldExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long>(b, a), ArithmeticExpressionOperator.Divide));
        public static Int64ExpressionMediator operator %(Int16FieldExpression a, long b) => new Int64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long>(b, a), ArithmeticExpressionOperator.Modulo));

        public static Int64ExpressionMediator operator +(long a, Int16FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long>(a, b), b, ArithmeticExpressionOperator.Add));
        public static Int64ExpressionMediator operator -(long a, Int16FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static Int64ExpressionMediator operator *(long a, Int16FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static Int64ExpressionMediator operator /(long a, Int16FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static Int64ExpressionMediator operator %(long a, Int16FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long>(a, b), b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(Int16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long?>(b, a), ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(Int16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long?>(b, a), ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(Int16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long?>(b, a), ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(Int16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long?>(b, a), ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(Int16FieldExpression a, long? b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<long?>(b, a), ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(long? a, Int16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long?>(a, b), b, ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(long? a, Int16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long?>(a, b), b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(long? a, Int16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long?>(a, b), b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(long? a, Int16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long?>(a, b), b, ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(long? a, Int16FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(new LiteralExpression<long?>(a, b), b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region string


        #endregion
        
        #region TimeSpan



        #endregion
        
        #endregion

        #region fields
        #region byte
        public static Int16ExpressionMediator operator +(Int16FieldExpression a, ByteFieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(Int16FieldExpression a, ByteFieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(Int16FieldExpression a, ByteFieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(Int16FieldExpression a, ByteFieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(Int16FieldExpression a, ByteFieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(Int16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(Int16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(Int16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(Int16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(Int16FieldExpression a, NullableByteFieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region decimal
        public static DecimalExpressionMediator operator +(Int16FieldExpression a, DecimalFieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DecimalExpressionMediator operator -(Int16FieldExpression a, DecimalFieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static DecimalExpressionMediator operator *(Int16FieldExpression a, DecimalFieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static DecimalExpressionMediator operator /(Int16FieldExpression a, DecimalFieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static DecimalExpressionMediator operator %(Int16FieldExpression a, DecimalFieldExpression b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(Int16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(Int16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(Int16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(Int16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(Int16FieldExpression a, NullableDecimalFieldExpression b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region DateTime
        public static DateTimeExpressionMediator operator +(Int16FieldExpression a, DateTimeFieldExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DateTimeExpressionMediator operator -(Int16FieldExpression a, DateTimeFieldExpression b) => new DateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(Int16FieldExpression a, NullableDateTimeFieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(Int16FieldExpression a, NullableDateTimeFieldExpression b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region DateTimeOffset
        public static DateTimeOffsetExpressionMediator operator +(Int16FieldExpression a, DateTimeOffsetFieldExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DateTimeOffsetExpressionMediator operator -(Int16FieldExpression a, DateTimeOffsetFieldExpression b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(Int16FieldExpression a, NullableDateTimeOffsetFieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(Int16FieldExpression a, NullableDateTimeOffsetFieldExpression b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region double
        public static DoubleExpressionMediator operator +(Int16FieldExpression a, DoubleFieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DoubleExpressionMediator operator -(Int16FieldExpression a, DoubleFieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static DoubleExpressionMediator operator *(Int16FieldExpression a, DoubleFieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static DoubleExpressionMediator operator /(Int16FieldExpression a, DoubleFieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static DoubleExpressionMediator operator %(Int16FieldExpression a, DoubleFieldExpression b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(Int16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(Int16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(Int16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(Int16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(Int16FieldExpression a, NullableDoubleFieldExpression b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region float
        public static SingleExpressionMediator operator +(Int16FieldExpression a, SingleFieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static SingleExpressionMediator operator -(Int16FieldExpression a, SingleFieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static SingleExpressionMediator operator *(Int16FieldExpression a, SingleFieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static SingleExpressionMediator operator /(Int16FieldExpression a, SingleFieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static SingleExpressionMediator operator %(Int16FieldExpression a, SingleFieldExpression b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(Int16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(Int16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(Int16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(Int16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(Int16FieldExpression a, NullableSingleFieldExpression b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region short
        public static Int16ExpressionMediator operator +(Int16FieldExpression a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(Int16FieldExpression a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(Int16FieldExpression a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(Int16FieldExpression a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(Int16FieldExpression a, Int16FieldExpression b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(Int16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(Int16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(Int16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(Int16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(Int16FieldExpression a, NullableInt16FieldExpression b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region int
        public static Int32ExpressionMediator operator +(Int16FieldExpression a, Int32FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int32ExpressionMediator operator -(Int16FieldExpression a, Int32FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int32ExpressionMediator operator *(Int16FieldExpression a, Int32FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int32ExpressionMediator operator /(Int16FieldExpression a, Int32FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int32ExpressionMediator operator %(Int16FieldExpression a, Int32FieldExpression b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(Int16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(Int16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(Int16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(Int16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(Int16FieldExpression a, NullableInt32FieldExpression b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region long
        public static Int64ExpressionMediator operator +(Int16FieldExpression a, Int64FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int64ExpressionMediator operator -(Int16FieldExpression a, Int64FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int64ExpressionMediator operator *(Int16FieldExpression a, Int64FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int64ExpressionMediator operator /(Int16FieldExpression a, Int64FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int64ExpressionMediator operator %(Int16FieldExpression a, Int64FieldExpression b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(Int16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(Int16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(Int16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(Int16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(Int16FieldExpression a, NullableInt64FieldExpression b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region string

        #endregion
        
        #region TimeSpan

        #endregion
        
        #endregion

        #region mediators
        #region byte
        public static Int16ExpressionMediator operator +(Int16FieldExpression a, ByteExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(Int16FieldExpression a, ByteExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(Int16FieldExpression a, ByteExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(Int16FieldExpression a, ByteExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(Int16FieldExpression a, ByteExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(Int16FieldExpression a, NullableByteExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(Int16FieldExpression a, NullableByteExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(Int16FieldExpression a, NullableByteExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(Int16FieldExpression a, NullableByteExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(Int16FieldExpression a, NullableByteExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region decimal
        public static DecimalExpressionMediator operator +(Int16FieldExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DecimalExpressionMediator operator -(Int16FieldExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static DecimalExpressionMediator operator *(Int16FieldExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static DecimalExpressionMediator operator /(Int16FieldExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static DecimalExpressionMediator operator %(Int16FieldExpression a, DecimalExpressionMediator b) => new DecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableDecimalExpressionMediator operator +(Int16FieldExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDecimalExpressionMediator operator -(Int16FieldExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableDecimalExpressionMediator operator *(Int16FieldExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableDecimalExpressionMediator operator /(Int16FieldExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableDecimalExpressionMediator operator %(Int16FieldExpression a, NullableDecimalExpressionMediator b) => new NullableDecimalExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region DateTime
        public static DateTimeExpressionMediator operator +(Int16FieldExpression a, DateTimeExpressionMediator b) => new DateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DateTimeExpressionMediator operator -(Int16FieldExpression a, DateTimeExpressionMediator b) => new DateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeExpressionMediator operator +(Int16FieldExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeExpressionMediator operator -(Int16FieldExpression a, NullableDateTimeExpressionMediator b) => new NullableDateTimeExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region DateTimeOffset
        public static DateTimeOffsetExpressionMediator operator +(Int16FieldExpression a, DateTimeOffsetExpressionMediator b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DateTimeOffsetExpressionMediator operator -(Int16FieldExpression a, DateTimeOffsetExpressionMediator b) => new DateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));

        public static NullableDateTimeOffsetExpressionMediator operator +(Int16FieldExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDateTimeOffsetExpressionMediator operator -(Int16FieldExpression a, NullableDateTimeOffsetExpressionMediator b) => new NullableDateTimeOffsetExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        #endregion
        
        #region double
        public static DoubleExpressionMediator operator +(Int16FieldExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static DoubleExpressionMediator operator -(Int16FieldExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static DoubleExpressionMediator operator *(Int16FieldExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static DoubleExpressionMediator operator /(Int16FieldExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static DoubleExpressionMediator operator %(Int16FieldExpression a, DoubleExpressionMediator b) => new DoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableDoubleExpressionMediator operator +(Int16FieldExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableDoubleExpressionMediator operator -(Int16FieldExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableDoubleExpressionMediator operator *(Int16FieldExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableDoubleExpressionMediator operator /(Int16FieldExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableDoubleExpressionMediator operator %(Int16FieldExpression a, NullableDoubleExpressionMediator b) => new NullableDoubleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region float
        public static SingleExpressionMediator operator +(Int16FieldExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static SingleExpressionMediator operator -(Int16FieldExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static SingleExpressionMediator operator *(Int16FieldExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static SingleExpressionMediator operator /(Int16FieldExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static SingleExpressionMediator operator %(Int16FieldExpression a, SingleExpressionMediator b) => new SingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableSingleExpressionMediator operator +(Int16FieldExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableSingleExpressionMediator operator -(Int16FieldExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableSingleExpressionMediator operator *(Int16FieldExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableSingleExpressionMediator operator /(Int16FieldExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableSingleExpressionMediator operator %(Int16FieldExpression a, NullableSingleExpressionMediator b) => new NullableSingleExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region short
        public static Int16ExpressionMediator operator +(Int16FieldExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int16ExpressionMediator operator -(Int16FieldExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int16ExpressionMediator operator *(Int16FieldExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int16ExpressionMediator operator /(Int16FieldExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int16ExpressionMediator operator %(Int16FieldExpression a, Int16ExpressionMediator b) => new Int16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt16ExpressionMediator operator +(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt16ExpressionMediator operator -(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt16ExpressionMediator operator *(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt16ExpressionMediator operator /(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt16ExpressionMediator operator %(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new NullableInt16ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region int
        public static Int32ExpressionMediator operator +(Int16FieldExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int32ExpressionMediator operator -(Int16FieldExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int32ExpressionMediator operator *(Int16FieldExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int32ExpressionMediator operator /(Int16FieldExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int32ExpressionMediator operator %(Int16FieldExpression a, Int32ExpressionMediator b) => new Int32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt32ExpressionMediator operator +(Int16FieldExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt32ExpressionMediator operator -(Int16FieldExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt32ExpressionMediator operator *(Int16FieldExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt32ExpressionMediator operator /(Int16FieldExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt32ExpressionMediator operator %(Int16FieldExpression a, NullableInt32ExpressionMediator b) => new NullableInt32ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region long
        public static Int64ExpressionMediator operator +(Int16FieldExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static Int64ExpressionMediator operator -(Int16FieldExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static Int64ExpressionMediator operator *(Int16FieldExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static Int64ExpressionMediator operator /(Int16FieldExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static Int64ExpressionMediator operator %(Int16FieldExpression a, Int64ExpressionMediator b) => new Int64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));

        public static NullableInt64ExpressionMediator operator +(Int16FieldExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static NullableInt64ExpressionMediator operator -(Int16FieldExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static NullableInt64ExpressionMediator operator *(Int16FieldExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static NullableInt64ExpressionMediator operator /(Int16FieldExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static NullableInt64ExpressionMediator operator %(Int16FieldExpression a, NullableInt64ExpressionMediator b) => new NullableInt64ExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        #endregion
        
        #region string

        #endregion
        
        #region TimeSpan

        #endregion
        
        #endregion

        #region alias
        public static ObjectExpressionMediator operator +(Int16FieldExpression a, AliasExpression b) => new ObjectExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static ObjectExpressionMediator operator -(Int16FieldExpression a, AliasExpression b) => new ObjectExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Subtract));
        public static ObjectExpressionMediator operator *(Int16FieldExpression a, AliasExpression b) => new ObjectExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Multiply));
        public static ObjectExpressionMediator operator /(Int16FieldExpression a, AliasExpression b) => new ObjectExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Divide));
        public static ObjectExpressionMediator operator %(Int16FieldExpression a, AliasExpression b) => new ObjectExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Modulo));
        public static ObjectExpressionMediator operator +(Int16FieldExpression a, (string TableAlias, string FieldAlias) b) => new ObjectExpressionMediator(new ArithmeticExpression(a, new AliasExpression(b.TableAlias, b.FieldAlias), ArithmeticExpressionOperator.Add));
        public static ObjectExpressionMediator operator -(Int16FieldExpression a, (string TableAlias, string FieldAlias) b) => new ObjectExpressionMediator(new ArithmeticExpression(a, new AliasExpression(b.TableAlias, b.FieldAlias), ArithmeticExpressionOperator.Subtract));
        public static ObjectExpressionMediator operator *(Int16FieldExpression a, (string TableAlias, string FieldAlias) b) => new ObjectExpressionMediator(new ArithmeticExpression(a, new AliasExpression(b.TableAlias, b.FieldAlias), ArithmeticExpressionOperator.Multiply));
        public static ObjectExpressionMediator operator /(Int16FieldExpression a, (string TableAlias, string FieldAlias) b) => new ObjectExpressionMediator(new ArithmeticExpression(a, new AliasExpression(b.TableAlias, b.FieldAlias), ArithmeticExpressionOperator.Divide));
        public static ObjectExpressionMediator operator %(Int16FieldExpression a, (string TableAlias, string FieldAlias) b) => new ObjectExpressionMediator(new ArithmeticExpression(a, new AliasExpression(b.TableAlias, b.FieldAlias), ArithmeticExpressionOperator.Modulo));
        #endregion
        #endregion

        #region filter operators
        #region DBNull
        public static FilterExpressionSet operator ==(Int16FieldExpression a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator ==(DBNull a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(DBNull a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.NotEqual));
        #endregion

        #region data types
        #region short
        public static FilterExpressionSet operator ==(Int16FieldExpression a, short b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<short>(b, a), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, short b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<short>(b, a), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, short b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<short>(b, a), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, short b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<short>(b, a), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, short b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<short>(b, a), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, short b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<short>(b, a), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(short a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<short>(a, b), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(short a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<short>(a, b), b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(short a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<short>(a, b), b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(short a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<short>(a, b), b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(short a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<short>(a, b), b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(short a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<short>(a, b), b, FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(Int16FieldExpression a, short? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, short? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, short? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, short? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, short? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, short? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<short?>(b, a), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(short? a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(short? a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(short? a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(short? a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(short? a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(short? a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<short?>(a, b), b, FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion

        #region fields
        public static FilterExpressionSet operator ==(Int16FieldExpression a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, Int16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(Int16FieldExpression a, NullableInt16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, NullableInt16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, NullableInt16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, NullableInt16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, NullableInt16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, NullableInt16FieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        
        #region mediators
        public static FilterExpressionSet operator ==(Int16FieldExpression a, Int16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, Int16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, Int16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, Int16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, Int16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, Int16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, NullableInt16ExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        #endregion

        #region alias
        public static FilterExpressionSet operator ==(Int16FieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        public static FilterExpressionSet operator ==(Int16FieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(Int16FieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(Int16FieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(Int16FieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(Int16FieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(Int16FieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion
    }
}
