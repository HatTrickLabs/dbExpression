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

using HatTrick.DbEx.MsSql.Expression;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Builder;
using HatTrick.DbEx.Sql.Expression;
using System;

namespace HatTrick.DbEx.MsSql.Builder
{
    /// <inheritdoc/>
    public partial class MsSqlFunctionExpressionBuilder : SqlFunctionExpressionBuilder
    {
        #region cast
        #region object
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="AnyObjectElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(AnyObjectElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);
        #endregion

        #region bool
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="BooleanElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(BooleanElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableBooleanElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableBooleanElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region byte
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="ByteElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(ByteElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableByteElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableByteElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region DateTime
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="DateTimeElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(DateTimeElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableDateTimeElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region DateTimeOffset
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="DateTimeOffsetElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(DateTimeOffsetElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeOffsetElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableDateTimeOffsetElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region decimal
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="DecimalElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(DecimalElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableDecimalElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableDecimalElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region double
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="DoubleElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(DoubleElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableDoubleElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableDoubleElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region enum
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="EnumElement{TEnum}"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast<TEnum>(EnumElement<TEnum> element)
            where TEnum : struct, Enum, IComparable
            => new MsSqlCastFunctionExpressionBuilder(new NullableEnumExpressionMediator<TEnum>(element));

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableEnumElement{TEnum}"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast<TEnum>(NullableEnumElement<TEnum> element)
            where TEnum : struct, Enum, IComparable
            => new MsSqlNullableCastFunctionExpressionBuilder(new NullableEnumExpressionMediator<TEnum>(element));
        #endregion

        #region float
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="SingleElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(SingleElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableSingleElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableSingleElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region Guid
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="GuidElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(GuidElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableGuidElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableGuidElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region short
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="Int16Element"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(Int16Element element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableInt16Element"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableInt16Element element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region int
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="Int32Element"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(Int32Element element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableInt32Element"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableInt32Element element)
            => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region long
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="Int64Element"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(Int64Element element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableInt64Element"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableInt64Element element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region string
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="StringElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(StringElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);


        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableStringElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableStringElement element)
            => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion

        #region TimeSpan
        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="TimeSpanElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="Cast"/> to specify the sql data type to convert to.</returns>
        public static MsSqlCast Cast(TimeSpanElement element)
            => new MsSqlCastFunctionExpressionBuilder(element);

        /// <summary>
        /// Construct an expression for the CAST transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql">Microsoft docs on CAST</see></para>
        /// </summary>
        /// <param name="element">Any expression of type <see cref="NullableTimeSpanElement"/> to convert to a different sql data type.</param>
        /// <returns><see cref="NullableCast"/> to specify the sql data type to convert to.</returns>
        public static NullableCast Cast(NullableTimeSpanElement element)
           => new MsSqlNullableCastFunctionExpressionBuilder(element);
        #endregion
        #endregion

        #region date add
        #region object
        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="AnyObjectElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, int value, AnyObjectElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new Int32ExpressionMediator(new LiteralExpression<int>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="AnyObjectElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, int? value, AnyObjectElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">Any expression of type <see cref="Int32Element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="AnyObjectElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, Int32Element value, AnyObjectElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">Any expression of type <see cref="NullableInt32Element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="AnyObjectElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, NullableInt32Element value, AnyObjectElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);
        #endregion

        #region DateTime
        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="DateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="DateTimeElement"/>.</returns>
        public static DateTimeDateAddFunctionExpression DateAdd(DateParts datePart, int value, DateTimeElement element)
            => new DateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new Int32ExpressionMediator(new LiteralExpression<int>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, int value, NullableDateTimeElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new Int32ExpressionMediator(new LiteralExpression<int>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, int? value, DateTimeElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, int? value, NullableDateTimeElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="DateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="DateTimeElement"/>.</returns>
        public static DateTimeDateAddFunctionExpression DateAdd(DateParts datePart, Int32Element value, DateTimeElement element)
            => new DateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, Int32Element value, NullableDateTimeElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">Any expression of type <see cref="NullableInt32Element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, NullableInt32Element value, DateTimeElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">Any expression of type <see cref="NullableInt32Element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="NullableDateTimeElement"/>.</returns>
        public static NullableDateTimeDateAddFunctionExpression DateAdd(DateParts datePart, NullableInt32Element value, NullableDateTimeElement element)
            => new NullableDateTimeDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);
        #endregion

        #region DateTimeOffset
        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="DateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="DateTimeOffsetElement"/>.</returns>
        public static DateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, int value, DateTimeOffsetElement element)
            => new DateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new Int32ExpressionMediator(new LiteralExpression<int>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="NullableDateTimeOffsetElement"/>.</returns>
        public static NullableDateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, int value, NullableDateTimeOffsetElement element)
            => new NullableDateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new Int32ExpressionMediator(new LiteralExpression<int>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="NullableDateTimeOffsetElement"/>.</returns>
        public static NullableDateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, int? value, DateTimeOffsetElement element)
            => new NullableDateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="NullableDateTimeOffsetElement"/>.</returns>
        public static NullableDateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, int? value, NullableDateTimeOffsetElement element)
            => new NullableDateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableInt32ExpressionMediator(new LiteralExpression<int?>(value)), element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="DateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="DateTimeOffsetElement"/>.</returns>
        public static DateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, Int32Element value, DateTimeOffsetElement element)
            => new DateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">The value to add to <paramref name="element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="NullableDateTimeOffsetElement"/>.</returns>
        public static NullableDateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, Int32Element value, NullableDateTimeOffsetElement element)
            => new NullableDateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">Any expression of type <see cref="NullableInt32Element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="NullableDateTimeOffsetElement"/>.</returns>
        public static NullableDateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, NullableInt32Element value, DateTimeOffsetElement element)
            => new NullableDateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);

        /// <summary>
        /// Construct an expression for the DATEADD transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql">Microsoft docs on DATEADD</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date to add <paramref name="value"/> to.</param>
        /// <param name="value">Any expression of type <see cref="NullableInt32Element"/> to add to <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeOffsetElement"/> to add <paramref name="value"/> to.</param>
        /// <returns><see cref="NullableDateTimeOffsetDateAddFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeOffsetElement"/> or <see cref="NullableDateTimeOffsetElement"/>.</returns>
        public static NullableDateTimeOffsetDateAddFunctionExpression DateAdd(DateParts datePart, NullableInt32Element value, NullableDateTimeOffsetElement element)
            => new NullableDateTimeOffsetDateAddFunctionExpression(new DatePartsExpression<DateParts>(datePart), value, element);
        #endregion
        #endregion

        #region date part
        /// <summary>
        /// Construct an expression for the DATEPART transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datepart-transact-sql">Microsoft docs on DATEPART</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the date value to extract from <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="AnyObjectElement"/> that represents a date.</param>
        /// <returns><see cref="NullableInt32DatePartFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DatePartFunctionExpression DatePart(DateParts datePart, AnyObjectElement element)
            => new NullableInt32DatePartFunctionExpression(new DatePartsExpression<DateParts>(datePart), element);

        /// <summary>
        /// Construct an expression for the DATEPART transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datepart-transact-sql">Microsoft docs on DATEPART</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the date value to extract from <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeElement"/>.</param>
        /// <returns><see cref="Int32DatePartFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DatePartFunctionExpression DatePart(DateParts datePart, DateTimeElement element)
            => new Int32DatePartFunctionExpression(new DatePartsExpression<DateParts>(datePart), element);

        /// <summary>
        /// Construct an expression for the DATEPART transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datepart-transact-sql">Microsoft docs on DATEPART</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the date value to extract from <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeElement"/>.</param>
        /// <returns><see cref="NullableInt32DatePartFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DatePartFunctionExpression DatePart(DateParts datePart, NullableDateTimeElement element)
            => new NullableInt32DatePartFunctionExpression(new DatePartsExpression<DateParts>(datePart), element);

        /// <summary>
        /// Construct an expression for the DATEPART transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datepart-transact-sql">Microsoft docs on DATEPART</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the date value to extract from <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="DateTimeOffsetElement"/>.</param>
        /// <returns><see cref="Int32DatePartFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DatePartFunctionExpression DatePart(DateParts datePart, DateTimeOffsetElement element)
            => new Int32DatePartFunctionExpression(new DatePartsExpression<DateParts>(datePart), element);

        /// <summary>
        /// Construct an expression for the DATEPART transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datepart-transact-sql">Microsoft docs on DATEPART</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the date value to extract from <paramref name="element"/>.</param>
        /// <param name="element">Any expression of type <see cref="NullableDateTimeOffsetElement"/>.</param>
        /// <returns><see cref="NullableInt32DatePartFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DatePartFunctionExpression DatePart(DateParts datePart, NullableDateTimeOffsetElement element)
            => new NullableInt32DatePartFunctionExpression(new DatePartsExpression<DateParts>(datePart), element);
        #endregion

        #region date diff
        #region object
        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="AnyDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime startDate, AnyObjectElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="AnyObjectElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="AnyDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, AnyObjectElement startDate, AnyDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="AnyDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="AnyObjectElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, AnyDateTimeElement startDate, AnyObjectElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="AnyObjectElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="AnyDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, AnyObjectElement startDate, AnyDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="AnyDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="AnyObjectElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, AnyDateTimeOffsetElement startDate, AnyObjectElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);
        #endregion

        #region DateTime
        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime startDate, DateTimeElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime startDate, DateTimeOffsetElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeExpressionMediator(new LiteralExpression<DateTime>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime? startDate, DateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime? startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime? startDate, DateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTime? startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, DateTime endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeExpressionMediator(new LiteralExpression<DateTime>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, DateTime? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(endDate)));


        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, DateTimeOffset endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeExpressionMediator(new LiteralExpression<DateTimeOffset>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, DateTimeOffset? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeExpressionMediator(new LiteralExpression<DateTimeOffset?>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, DateTime? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeExpressionMediator(new LiteralExpression<DateTime?>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, DateTime endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeExpressionMediator(new LiteralExpression<DateTime>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, DateTimeElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, DateTimeOffset? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeExpressionMediator(new LiteralExpression<DateTimeOffset?>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, DateTimeOffset endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeExpressionMediator(new LiteralExpression<DateTimeOffset>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, DateTimeOffsetElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeElement startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, DateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, DateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeElement startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);
        #endregion

        #region DateTimeOffset
        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset startDate, DateTimeOffsetElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset startDate, DateTimeElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset? startDate, DateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset? startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset? startDate, DateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">The starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffset? startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(startDate)), endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, DateTimeOffset endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, DateTimeOffset? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, DateTime endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTime>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, DateTime? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTime?>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, DateTimeOffset? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset?>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, DateTimeOffset endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTimeOffset>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, DateTimeOffsetElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, DateTime? endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new NullableDateTimeOffsetExpressionMediator(new LiteralExpression<DateTime?>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">The ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, DateTime endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, new DateTimeOffsetExpressionMediator(new LiteralExpression<DateTime>(endDate)));

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="Int32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, DateTimeElement endDate)
            => new Int32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, DateTimeOffsetElement startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, DateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, NullableDateTimeOffsetElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="DateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, DateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);

        /// <summary>
        /// Construct an expression for the DATEDIFF transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql">Microsoft docs on DATEDIFF</see></para>
        /// </summary>
        /// <param name="datePart">A <see cref="DateParts"/> specifying the part of the date value to use for calculation.</param>
        /// <param name="startDate">Any expression of type <see cref="NullableDateTimeOffsetElement"/>, the starting date used for calculation.</param>
        /// <param name="endDate">Any expression of type <see cref="NullableDateTimeElement"/>, the ending date used for calculation.</param>
        /// <returns><see cref="NullableInt32DateDiffFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32DateDiffFunctionExpression DateDiff(DateParts datePart, NullableDateTimeOffsetElement startDate, NullableDateTimeElement endDate)
            => new NullableInt32DateDiffFunctionExpression(new DatePartsExpression<DateParts>(datePart), startDate, endDate);
        #endregion
        #endregion

        #region discrete date
        /// <summary>
        /// Construct an expression for the GETDATE transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/getdate-transact-sql">Microsoft docs on GETDATE</see></para>
        /// </summary>
        /// <returns><see cref="GetDateFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="DateTimeElement"/>.</returns>
        public static GetDateFunctionExpression GetDate()
            => new GetDateFunctionExpression();

        /// <summary>
        /// Construct an expression for the GETUTCDATE transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/getutcdate-transact-sql">Microsoft docs on GETUTCDATE</see></para>
        /// </summary>
        /// <returns><see cref="GetUtcDateFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="DateTimeElement"/>.</returns>
        public static GetUtcDateFunctionExpression GetUtcDate()
            => new GetUtcDateFunctionExpression();

        /// <summary>
        /// Construct an expression for the SYSDATETIME transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/sysdatetime-transact-sql">Microsoft docs on SYSDATETIME</see></para>
        /// </summary>
        /// <returns><see cref="SysDateTimeFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="DateTimeElement"/>.</returns>
        public static SysDateTimeFunctionExpression SysDateTime()
            => new SysDateTimeFunctionExpression();

        /// <summary>
        /// Construct an expression for the SYSDATETIMEOFFSET transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/sysdatetimeoffset-transact-sql">Microsoft docs on SYSDATETIMEOFFSET</see></para>
        /// </summary>
        /// <returns><see cref="SysDateTimeOffsetFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="DateTimeElement"/>.</returns>
        public static SysDateTimeOffsetFunctionExpression SysDateTimeOffset()
            => new SysDateTimeOffsetFunctionExpression();

        /// <summary>
        /// Construct an expression for the SYSUTCDATETIME transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/sysutcdatetimeoffset-transact-sql">Microsoft docs on SYSUTCDATETIME</see></para>
        /// </summary>
        /// <returns><see cref="SysUtcDateTimeFunctionExpression"/> for use with any operation accepting a <see cref="AnyDateTimeElement"/> or <see cref="DateTimeElement"/>.</returns>
        public static SysUtcDateTimeFunctionExpression SysUtcDateTime()
            => new SysUtcDateTimeFunctionExpression();
        #endregion

        #region newid
        /// <summary>
        /// Construct an expression for the NEWID transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/sysutcdatetimeoffset-transact-sql">Microsoft docs on NEWID</see></para>
        /// </summary>
        /// <returns><see cref="NewIdFunctionExpression"/> for use with any operation accepting a <see cref="AnyGuidElement"/> or <see cref="GuidElement"/>.</returns>
        public static NewIdFunctionExpression NewId()
             => new NewIdFunctionExpression();
        #endregion

        #region len
        /// <summary>
        /// Construct an expression for the LEN transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/len-transact-sql">Microsoft docs on LEN</see></para>
        /// </summary>
        /// <param name="element">A <see cref="AnyStringElement"/> for determining the number of characters, excluding trailing spaces.</param>
        /// <returns><see cref="Int64LengthFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64LengthFunctionExpression Len(StringElement element)
            => new Int64LengthFunctionExpression(element);

        /// <summary>
        /// Construct an expression for the LEN transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/len-transact-sql">Microsoft docs on LEN</see></para>
        /// </summary>
        /// <param name="element">A <see cref="NullableStringElement"/> for determining the number of characters, excluding trailing spaces.</param>
        /// <returns><see cref="NullableInt64LengthFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64LengthFunctionExpression Len(NullableStringElement element)
            => new NullableInt64LengthFunctionExpression(element);
        #endregion

        #region patindex
        /// <summary>
        /// Construct an expression for the PATINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/patindex-transact-sql">Microsoft docs on PATINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> literal to be found.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <returns><see cref="ObjectPatIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static ObjectPatIndexFunctionExpression PatIndex(string pattern, ObjectElement element)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new ObjectPatIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element);
        }

        /// <summary>
        /// Construct an expression for the PATINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/patindex-transact-sql">Microsoft docs on PATINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> that contains the expression to be found.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <returns><see cref="ObjectPatIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static ObjectPatIndexFunctionExpression PatIndex(StringElement pattern, ObjectElement element)
            => new ObjectPatIndexFunctionExpression(pattern, element);

        /// <summary>
        /// Construct an expression for the PATINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/patindex-transact-sql">Microsoft docs on PATINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> literal to be found.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <returns><see cref="Int64PatIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64PatIndexFunctionExpression PatIndex(string pattern, StringElement element)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new Int64PatIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element);
        }

        /// <summary>
        /// Construct an expression for the PATINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/patindex-transact-sql">Microsoft docs on PATINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> that contains the expression to be found.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <returns><see cref="Int64PatIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64PatIndexFunctionExpression PatIndex(StringElement pattern, StringElement element)
            => new Int64PatIndexFunctionExpression(pattern, element);

        /// <summary>
        /// Construct an expression for the PATINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/patindex-transact-sql">Microsoft docs on PATINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> literal to be found.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <returns><see cref="NullableInt64PatIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64PatIndexFunctionExpression PatIndex(string pattern, NullableStringElement element)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64PatIndexFunctionExpression(new NullableStringExpressionMediator(new LiteralExpression<string>(pattern)), element);
        }

        /// <summary>
        /// Construct an expression for the PATINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/patindex-transact-sql">Microsoft docs on PATINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="AnyStringElement"/> that contains the expression to be found.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <returns><see cref="NullableInt64PatIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64PatIndexFunctionExpression PatIndex(AnyStringElement pattern, NullableStringElement element)
            => new NullableInt64PatIndexFunctionExpression(pattern, element);
        #endregion

        #region charindex
        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(string pattern, ObjectElement element)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new ObjectCharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="AnyStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(string pattern, ObjectElement element, long startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new ObjectCharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(string pattern, ObjectElement element, int startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new ObjectCharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(string pattern, ObjectElement element, Int32Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new ObjectCharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(string pattern, ObjectElement element, Int64Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new ObjectCharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(StringElement pattern, ObjectElement element)
            => new ObjectCharIndexFunctionExpression(pattern, element);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(StringElement pattern, ObjectElement element, long startSearchPosition)
            => new ObjectCharIndexFunctionExpression(pattern, element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(StringElement pattern, ObjectElement element, int startSearchPosition)
            => new ObjectCharIndexFunctionExpression(pattern, element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(StringElement pattern, ObjectElement element, Int32Element startSearchPosition)
            => new ObjectCharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="ObjectElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="ObjectCharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectCharIndexFunctionExpression CharIndex(StringElement pattern, ObjectElement element, Int64Element startSearchPosition)
            => new ObjectCharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(string pattern, StringElement element)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new Int64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="AnyStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(string pattern, StringElement element, long startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new Int64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(string pattern, StringElement element, int startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new Int64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(string pattern, StringElement element, Int32Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new Int64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(string pattern, StringElement element, Int64Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new Int64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(StringElement pattern, StringElement element)
            => new Int64CharIndexFunctionExpression(pattern, element);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(StringElement pattern, StringElement element, long startSearchPosition)
            => new Int64CharIndexFunctionExpression(pattern, element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(StringElement pattern, StringElement element, int startSearchPosition)
            => new Int64CharIndexFunctionExpression(pattern, element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(StringElement pattern, StringElement element, Int32Element startSearchPosition)
            => new Int64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="Int64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64CharIndexFunctionExpression CharIndex(StringElement pattern, StringElement element, Int64Element startSearchPosition)
            => new Int64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, NullableStringElement element)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="AnyStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, NullableStringElement element, long startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, NullableStringElement element, int startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, NullableStringElement element, Int32Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="expression"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, NullableStringElement element, Int64Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, StringElement element, NullableInt32Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, StringElement element, NullableInt64Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, NullableStringElement element, NullableInt32Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(string pattern, NullableStringElement element, NullableInt64Element startSearchPosition)
        {
            if (pattern is null)
                throw new ArgumentException($"{nameof(pattern)} cannot be null or empty.", nameof(pattern));
            return new NullableInt64CharIndexFunctionExpression(new StringExpressionMediator(new LiteralExpression<string>(pattern)), element, startSearchPosition);
        }

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, NullableStringElement element)
            => new NullableInt64CharIndexFunctionExpression(pattern, element);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="AnyStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, NullableStringElement element, long startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, NullableStringElement element, int startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, NullableStringElement element, Int32Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="expression"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, NullableStringElement element, Int64Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, StringElement element, NullableInt32Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, StringElement element, NullableInt64Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, NullableStringElement element, NullableInt32Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="StringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(StringElement pattern, NullableStringElement element, NullableInt64Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, StringElement element)
            => new NullableInt64CharIndexFunctionExpression(pattern, element);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, NullableStringElement element)
            => new NullableInt64CharIndexFunctionExpression(pattern, element);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, NullableStringElement element, long startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, NullableStringElement element, int startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, StringElement element, Int32Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, NullableStringElement element, Int32Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="string"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, StringElement element, long startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, new Int64ExpressionMediator(new LiteralExpression<long>(startSearchPosition)));
        
        /// <summary>
                                                                                                                                                             /// Construct an expression for the CHARINDEX transact sql function.
                                                                                                                                                             /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
                                                                                                                                                             /// </summary>
                                                                                                                                                             /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
                                                                                                                                                             /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
                                                                                                                                                             /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
                                                                                                                                                             /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, StringElement element, Int64Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, NullableStringElement element, Int64Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, StringElement element, int startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, new Int32ExpressionMediator(new LiteralExpression<int>(startSearchPosition)));
        
        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, StringElement element, NullableInt32Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="StringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, StringElement element, NullableInt64Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, NullableStringElement element, NullableInt32Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);

        /// <summary>
        /// Construct an expression for the CHARINDEX transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/charindex-transact-sql">Microsoft docs on CHARINDEX</see></para>
        /// </summary>
        /// <param name="pattern">A <see cref="NullableStringElement"/> to search for in <paramref name="element"/>.</param>
        /// <param name="element">A <see cref="NullableStringElement"/> the expression to search.</param>
        /// <param name="startSearchPosition">Where in <paramref name="element"/> to begin the search for <paramref name="pattern"/>.</param>
        /// <returns><see cref="NullableInt64CharIndexFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64CharIndexFunctionExpression CharIndex(NullableStringElement pattern, NullableStringElement element, NullableInt64Element startSearchPosition)
            => new NullableInt64CharIndexFunctionExpression(pattern, element, startSearchPosition);
        #endregion

        #region substring
        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, int start, int length)
            => new ObjectSubstringFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(start)), new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int32Element start, int length)
            => new ObjectSubstringFunctionExpression(expression, start, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int32Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, int start, Int32Element length)
            => new ObjectSubstringFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int32Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int32Element start, Int32Element length)
            => new ObjectSubstringFunctionExpression(expression, start, length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, long start, long length)
            => new ObjectSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int64Element start, long length)
            => new ObjectSubstringFunctionExpression(expression, start, new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, long start, Int64Element length)
            => new ObjectSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int64Element start, Int64Element length)
            => new ObjectSubstringFunctionExpression(expression, start, length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, int start, long length)
            => new ObjectSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int32Element start, long length)
            => new ObjectSubstringFunctionExpression(expression, start, new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, int start, Int64Element length)
            => new ObjectSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int32Element start, Int64Element length)
            => new ObjectSubstringFunctionExpression(expression, start, length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, long start, int length)
            => new ObjectSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int64Element start, int length)
            => new ObjectSubstringFunctionExpression(expression, start, new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int32Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, long start, Int32Element length)
            => new ObjectSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int32Element"/>, the number of characters to take.</param>
        /// <returns><see cref="ObjectSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectSubstringFunctionExpression Substring(ObjectElement expression, Int64Element start, Int32Element length)
            => new ObjectSubstringFunctionExpression(expression, start, length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, int start, int length)
            => new StringSubstringFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(start)), new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int32Element start, int length)
            => new StringSubstringFunctionExpression(expression, start, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int32Element"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, int start, Int32Element length)
            => new StringSubstringFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int32Element"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int32Element start, Int32Element length)
            => new StringSubstringFunctionExpression(expression, start, length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, long start, long length)
            => new StringSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int64Element start, long length)
            => new StringSubstringFunctionExpression(expression, start, new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, long start, Int64Element length)
            => new StringSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int64Element start, Int64Element length)
            => new StringSubstringFunctionExpression(expression, start, length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, int start, long length)
            => new StringSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int32Element start, long length)
            => new StringSubstringFunctionExpression(expression, start, new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, int start, Int64Element length)
            => new StringSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int32Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64Element"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int32Element start, Int64Element length)
            => new StringSubstringFunctionExpression(expression, start, length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, long start, int length)
            => new StringSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">The number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int64Element start, int length)
            => new StringSubstringFunctionExpression(expression, start, new Int64ExpressionMediator(new LiteralExpression<long>(length)));

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">The start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int32Element"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, long start, Int32Element length)
            => new StringSubstringFunctionExpression(expression, new Int64ExpressionMediator(new LiteralExpression<long>(start)), length);

        /// <summary>
        /// Construct an expression for the SUBSTRING transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/substring-transact-sql">Microsoft docs on SUBSTRING</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="StringElement"/> to take a portion of.</param>
        /// <param name="start">A <see cref="Int64Element"/>, the start position in <paramref name="expression"/> to start taking characters.</param>
        /// <param name="length">A <see cref="Int64ElInt32Elementement"/>, the number of characters to take.</param>
        /// <returns><see cref="StringSubstringFunctionExpression"/> for use with any operation accepting a <see cref="AnyStringElement"/> or <see cref="StringElement"/>.</returns>
        public static StringSubstringFunctionExpression Substring(StringElement expression, Int64Element start, Int32Element length)
            => new StringSubstringFunctionExpression(expression, start, length);
        #endregion

        #region round
        #region object
        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="ObjectRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectRoundFunctionExpression Round(ObjectElement expression, int length)
            => new ObjectRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="ObjectRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectRoundFunctionExpression Round(ObjectElement expression, int length, int function)
            => new ObjectRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="ObjectRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectRoundFunctionExpression Round(ObjectElement expression, IntegralNumericElement length)
            => new ObjectRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="ObjectRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectRoundFunctionExpression Round(ObjectElement expression, IntegralNumericElement length, int function)
            => new ObjectRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="ObjectRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectRoundFunctionExpression Round(ObjectElement expression, int length, IntegralNumericElement function)
            => new ObjectRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="ObjectElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="ObjectRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyObjectElement"/> or <see cref="ObjectElement"/>.</returns>
        public static ObjectRoundFunctionExpression Round(ObjectElement expression, IntegralNumericElement length, IntegralNumericElement function)
            => new ObjectRoundFunctionExpression(expression, length, function);
        #endregion

        #region decimal
        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DecimalElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="DecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDecimalElement"/> or <see cref="DecimalElement"/>.</returns>
        public static DecimalRoundFunctionExpression Round(DecimalElement expression, int length)
            => new DecimalRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DecimalElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="DecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDecimalElement"/> or <see cref="DecimalElement"/>.</returns>
        public static DecimalRoundFunctionExpression Round(DecimalElement expression, int length, int function)
            => new DecimalRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="DecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDecimalElement"/> or <see cref="DecimalElement"/>.</returns>
        public static DecimalRoundFunctionExpression Round(DecimalElement expression, IntegralNumericElement length)
            => new DecimalRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="DecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDecimalElement"/> or <see cref="DecimalElement"/>.</returns>
        public static DecimalRoundFunctionExpression Round(DecimalElement expression, IntegralNumericElement length, int function)
            => new DecimalRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DecimalElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="DecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDecimalElement"/> or <see cref="DecimalElement"/>.</returns>
        public static DecimalRoundFunctionExpression Round(DecimalElement expression, int length, IntegralNumericElement function)
            => new DecimalRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="DecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDecimalElement"/> or <see cref="DecimalElement"/>.</returns>
        public static DecimalRoundFunctionExpression Round(DecimalElement expression, IntegralNumericElement length, IntegralNumericElement function)
            => new DecimalRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, int length)
            => new NullableDecimalRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, int length, int function)
            => new NullableDecimalRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, IntegralNumericElement length)
            => new NullableDecimalRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, NullableIntegralNumericElement length)
            => new NullableDecimalRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, IntegralNumericElement length, int function)
            => new NullableDecimalRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, NullableIntegralNumericElement length, int function)
            => new NullableDecimalRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, int length, IntegralNumericElement function)
            => new NullableDecimalRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, int length, NullableIntegralNumericElement function)
            => new NullableDecimalRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, IntegralNumericElement length, IntegralNumericElement function)
            => new NullableDecimalRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, NullableIntegralNumericElement length, IntegralNumericElement function)
            => new NullableDecimalRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, IntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableDecimalRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDecimalElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDecimalRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDecimalElement"/> or <see cref="NullableDecimalElement"/>.</returns>
        public static NullableDecimalRoundFunctionExpression Round(NullableDecimalElement expression, NullableIntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableDecimalRoundFunctionExpression(expression, length, function);
        #endregion

        #region double
        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DoubleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="DoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDoubleElement"/> or <see cref="DoubleElement"/>.</returns>
        public static DoubleRoundFunctionExpression Round(DoubleElement expression, int length)
            => new DoubleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DoubleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="DoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDoubleElement"/> or <see cref="DoubleElement"/>.</returns>
        public static DoubleRoundFunctionExpression Round(DoubleElement expression, int length, int function)
            => new DoubleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="DoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDoubleElement"/> or <see cref="DoubleElement"/>.</returns>
        public static DoubleRoundFunctionExpression Round(DoubleElement expression, IntegralNumericElement length)
            => new DoubleRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="DoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDoubleElement"/> or <see cref="DoubleElement"/>.</returns>
        public static DoubleRoundFunctionExpression Round(DoubleElement expression, IntegralNumericElement length, int function)
            => new DoubleRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DoubleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="DoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDoubleElement"/> or <see cref="DoubleElement"/>.</returns>
        public static DoubleRoundFunctionExpression Round(DoubleElement expression, int length, IntegralNumericElement function)
            => new DoubleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="DoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="DoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyDoubleElement"/> or <see cref="DoubleElement"/>.</returns>
        public static DoubleRoundFunctionExpression Round(DoubleElement expression, IntegralNumericElement length, IntegralNumericElement function)
            => new DoubleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, int length)
            => new NullableDoubleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, int length, int function)
            => new NullableDoubleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, IntegralNumericElement length)
            => new NullableDoubleRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, NullableIntegralNumericElement length)
            => new NullableDoubleRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, IntegralNumericElement length, int function)
            => new NullableDoubleRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, NullableIntegralNumericElement length, int function)
            => new NullableDoubleRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, int length, IntegralNumericElement function)
            => new NullableDoubleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, int length, NullableIntegralNumericElement function)
            => new NullableDoubleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, IntegralNumericElement length, IntegralNumericElement function)
            => new NullableDoubleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, NullableIntegralNumericElement length, IntegralNumericElement function)
            => new NullableDoubleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, IntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableDoubleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableDoubleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableDoubleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableDoubleElement"/> or <see cref="NullableDoubleElement"/>.</returns>
        public static NullableDoubleRoundFunctionExpression Round(NullableDoubleElement expression, NullableIntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableDoubleRoundFunctionExpression(expression, length, function);
        #endregion

        #region short
        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int16Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="Int16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt16Element"/> or <see cref="Int16Element"/>.</returns>
        public static Int16RoundFunctionExpression Round(Int16Element expression, int length)
            => new Int16RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int16Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="Int16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt16Element"/> or <see cref="Int16Element"/>.</returns>
        public static Int16RoundFunctionExpression Round(Int16Element expression, int length, int function)
            => new Int16RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int16Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="Int16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt16Element"/> or <see cref="Int16Element"/>.</returns>
        public static Int16RoundFunctionExpression Round(Int16Element expression, IntegralNumericElement length)
            => new Int16RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int16Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="Int16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt16Element"/> or <see cref="Int16Element"/>.</returns>
        public static Int16RoundFunctionExpression Round(Int16Element expression, IntegralNumericElement length, int function)
            => new Int16RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int16Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="Int16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt16Element"/> or <see cref="Int16Element"/>.</returns>
        public static Int16RoundFunctionExpression Round(Int16Element expression, int length, IntegralNumericElement function)
            => new Int16RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int16Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="Int16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt16Element"/> or <see cref="Int16Element"/>.</returns>
        public static Int16RoundFunctionExpression Round(Int16Element expression, IntegralNumericElement length, IntegralNumericElement function)
            => new Int16RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, int length)
            => new NullableInt16RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, int length, int function)
            => new NullableInt16RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, IntegralNumericElement length)
            => new NullableInt16RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, NullableIntegralNumericElement length)
            => new NullableInt16RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, IntegralNumericElement length, int function)
            => new NullableInt16RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, NullableIntegralNumericElement length, int function)
            => new NullableInt16RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, int length, IntegralNumericElement function)
            => new NullableInt16RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, int length, NullableIntegralNumericElement function)
            => new NullableInt16RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, IntegralNumericElement length, IntegralNumericElement function)
            => new NullableInt16RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, NullableIntegralNumericElement length, IntegralNumericElement function)
            => new NullableInt16RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, IntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableInt16RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt16Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt16RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt16Element"/> or <see cref="NullableInt16Element"/>.</returns>
        public static NullableInt16RoundFunctionExpression Round(NullableInt16Element expression, NullableIntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableInt16RoundFunctionExpression(expression, length, function);
        #endregion

        #region int
        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int32Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="Int32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32RoundFunctionExpression Round(Int32Element expression, int length)
            => new Int32RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int32Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="Int32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32RoundFunctionExpression Round(Int32Element expression, int length, int function)
            => new Int32RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int32Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="Int32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32RoundFunctionExpression Round(Int32Element expression, IntegralNumericElement length)
            => new Int32RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int32Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="Int32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32RoundFunctionExpression Round(Int32Element expression, IntegralNumericElement length, int function)
            => new Int32RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int32Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="Int32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32RoundFunctionExpression Round(Int32Element expression, int length, IntegralNumericElement function)
            => new Int32RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int32Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="Int32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt32Element"/> or <see cref="Int32Element"/>.</returns>
        public static Int32RoundFunctionExpression Round(Int32Element expression, IntegralNumericElement length, IntegralNumericElement function)
            => new Int32RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, int length)
            => new NullableInt32RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, int length, int function)
            => new NullableInt32RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, IntegralNumericElement length)
            => new NullableInt32RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, NullableIntegralNumericElement length)
            => new NullableInt32RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, IntegralNumericElement length, int function)
            => new NullableInt32RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, NullableIntegralNumericElement length, int function)
            => new NullableInt32RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, int length, IntegralNumericElement function)
            => new NullableInt32RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, int length, NullableIntegralNumericElement function)
            => new NullableInt32RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, IntegralNumericElement length, IntegralNumericElement function)
            => new NullableInt32RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, NullableIntegralNumericElement length, IntegralNumericElement function)
            => new NullableInt32RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, IntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableInt32RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt32Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt32RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt32Element"/> or <see cref="NullableInt32Element"/>.</returns>
        public static NullableInt32RoundFunctionExpression Round(NullableInt32Element expression, NullableIntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableInt32RoundFunctionExpression(expression, length, function);
        #endregion

        #region long
        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int64Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="Int64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64RoundFunctionExpression Round(Int64Element expression, int length)
            => new Int64RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int64Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="Int64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64RoundFunctionExpression Round(Int64Element expression, int length, int function)
            => new Int64RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int64Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="Int64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64RoundFunctionExpression Round(Int64Element expression, IntegralNumericElement length)
            => new Int64RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int64Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="Int64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64RoundFunctionExpression Round(Int64Element expression, IntegralNumericElement length, int function)
            => new Int64RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int64Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="Int64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64RoundFunctionExpression Round(Int64Element expression, int length, IntegralNumericElement function)
            => new Int64RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="Int64Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="Int64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyInt64Element"/> or <see cref="Int64Element"/>.</returns>
        public static Int64RoundFunctionExpression Round(Int64Element expression, IntegralNumericElement length, IntegralNumericElement function)
            => new Int64RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, int length)
            => new NullableInt64RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, int length, int function)
            => new NullableInt64RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, IntegralNumericElement length)
            => new NullableInt64RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, NullableIntegralNumericElement length)
            => new NullableInt64RoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, IntegralNumericElement length, int function)
            => new NullableInt64RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, NullableIntegralNumericElement length, int function)
            => new NullableInt64RoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, int length, IntegralNumericElement function)
            => new NullableInt64RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, int length, NullableIntegralNumericElement function)
            => new NullableInt64RoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, IntegralNumericElement length, IntegralNumericElement function)
            => new NullableInt64RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, NullableIntegralNumericElement length, IntegralNumericElement function)
            => new NullableInt64RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, IntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableInt64RoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableInt64Element"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableInt64RoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableInt64Element"/> or <see cref="NullableInt64Element"/>.</returns>
        public static NullableInt64RoundFunctionExpression Round(NullableInt64Element expression, NullableIntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableInt64RoundFunctionExpression(expression, length, function);
        #endregion

        #region float
        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="SingleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="SingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnySingleElement"/> or <see cref="SingleElement"/>.</returns>
        public static SingleRoundFunctionExpression Round(SingleElement expression, int length)
            => new SingleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="SingleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="SingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnySingleElement"/> or <see cref="SingleElement"/>.</returns>
        public static SingleRoundFunctionExpression Round(SingleElement expression, int length, int function)
            => new SingleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="SingleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="SingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnySingleElement"/> or <see cref="SingleElement"/>.</returns>
        public static SingleRoundFunctionExpression Round(SingleElement expression, IntegralNumericElement length)
            => new SingleRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="SingleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="SingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnySingleElement"/> or <see cref="SingleElement"/>.</returns>
        public static SingleRoundFunctionExpression Round(SingleElement expression, IntegralNumericElement length, int function)
            => new SingleRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="SingleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="SingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnySingleElement"/> or <see cref="SingleElement"/>.</returns>
        public static SingleRoundFunctionExpression Round(SingleElement expression, int length, IntegralNumericElement function)
            => new SingleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="SingleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="SingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnySingleElement"/> or <see cref="SingleElement"/>.</returns>
        public static SingleRoundFunctionExpression Round(SingleElement expression, IntegralNumericElement length, IntegralNumericElement function)
            => new SingleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, int length)
            => new NullableSingleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, int length, int function)
            => new NullableSingleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, IntegralNumericElement length)
            => new NullableSingleRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, NullableIntegralNumericElement length)
            => new NullableSingleRoundFunctionExpression(expression, length);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, IntegralNumericElement length, int function)
            => new NullableSingleRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">The type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, NullableIntegralNumericElement length, int function)
            => new NullableSingleRoundFunctionExpression(expression, length, new Int32ExpressionMediator(new LiteralExpression<int>(function)));

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, int length, IntegralNumericElement function)
            => new NullableSingleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">The precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, int length, NullableIntegralNumericElement function)
            => new NullableSingleRoundFunctionExpression(expression, new Int32ExpressionMediator(new LiteralExpression<int>(length)), function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, IntegralNumericElement length, IntegralNumericElement function)
            => new NullableSingleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, NullableIntegralNumericElement length, IntegralNumericElement function)
            => new NullableSingleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="IntegralNumericElement" /> (one of <see cref="ByteElement" />, <see cref="Int16Element" />, <see cref="Int32Element" />, or <see cref="Int64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, IntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableSingleRoundFunctionExpression(expression, length, function);

        /// <summary>
        /// Construct an expression for the ROUND transact sql function.
        /// <para><see href="https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql">Microsoft docs on ROUND</see></para>
        /// </summary>
        /// <param name="expression">A <see cref="NullableSingleElement"/> to round.</param>
        /// <param name="length">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />), the precision to which <paramref name="expression" /> is to be rounded.</param>
        /// <param name="function">A <see cref="NullableIntegralNumericElement" /> (one of <see cref="NullableByteElement" />, <see cref="NullableInt16Element" />, <see cref="NullableInt32Element" />, or <see cref="NullableInt64Element" />) indicating the type of operation to perform.</param>
        /// <returns><see cref="NullableSingleRoundFunctionExpression"/> for use with any operation accepting a <see cref="AnyNullableSingleElement"/> or <see cref="NullableSingleElement"/>.</returns>
        public static NullableSingleRoundFunctionExpression Round(NullableSingleElement expression, NullableIntegralNumericElement length, NullableIntegralNumericElement function)
            => new NullableSingleRoundFunctionExpression(expression, length, function);
        #endregion
        #endregion
    }
}