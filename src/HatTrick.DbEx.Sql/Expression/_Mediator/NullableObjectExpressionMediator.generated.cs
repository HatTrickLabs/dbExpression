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

#nullable enable

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableObjectExpressionMediator
    {
        #region arithmetic operators 
        #region data type 
        #endregion

        #region fields
        #endregion

        #region mediator
        #endregion

        #region alias
        #endregion
        #endregion

        #region filter operators
        #region DBNull
        public static FilterExpressionSet operator ==(NullableObjectExpressionMediator a, DBNull b) => new(new FilterExpression<bool?>(a, a.Expression is FieldExpression field ? new LiteralExpression<object?>(b, field) : new LiteralExpression<object?>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableObjectExpressionMediator a, DBNull b) => new(new FilterExpression<bool?>(a, a.Expression is FieldExpression field ? new LiteralExpression<object?>(b, field) : new LiteralExpression<object?>(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator ==(DBNull a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b.Expression is FieldExpression field ? new LiteralExpression<object?>(a, field) : new LiteralExpression<object?>(a), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(DBNull a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b.Expression is FieldExpression field ? new LiteralExpression<object?>(a, field) : new LiteralExpression<object?>(a), FilterExpressionOperator.NotEqual));
        #endregion

        #region data type
        #region object?
        public static FilterExpressionSet operator ==(NullableObjectExpressionMediator a, object? b) => new(new FilterExpression<bool?>(a, new LiteralExpression<object?>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableObjectExpressionMediator a, object? b) => new(new FilterExpression<bool?>(a, new LiteralExpression<object?>(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableObjectExpressionMediator a, object? b) => new(new FilterExpression<bool?>(a, new LiteralExpression<object?>(b), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableObjectExpressionMediator a, object? b) => new(new FilterExpression<bool?>(a, new LiteralExpression<object?>(b), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableObjectExpressionMediator a, object? b) => new(new FilterExpression<bool?>(a, new LiteralExpression<object?>(b), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableObjectExpressionMediator a, object? b) => new(new FilterExpression<bool?>(a, new LiteralExpression<object?>(b), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(object? a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(object? a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(object? a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(object? a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(object? a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(object? a, NullableObjectExpressionMediator b) => new(new FilterExpression<bool?>(new LiteralExpression<object?>(a), b, FilterExpressionOperator.GreaterThanOrEqual));

        #endregion
        #endregion

        #region fields

        #endregion
        
        #region mediator
        public static FilterExpressionSet operator ==(NullableObjectExpressionMediator a, ObjectExpressionMediator b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableObjectExpressionMediator a, ObjectExpressionMediator b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableObjectExpressionMediator a, ObjectExpressionMediator b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableObjectExpressionMediator a, ObjectExpressionMediator b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableObjectExpressionMediator a, ObjectExpressionMediator b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableObjectExpressionMediator a, ObjectExpressionMediator b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));

        #endregion

        #region alias
        public static FilterExpressionSet operator ==(NullableObjectExpressionMediator a, AliasExpression b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableObjectExpressionMediator a, AliasExpression b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableObjectExpressionMediator a, AliasExpression b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableObjectExpressionMediator a, AliasExpression b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableObjectExpressionMediator a, AliasExpression b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableObjectExpressionMediator a, AliasExpression b) => new(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        public static FilterExpressionSet operator ==(NullableObjectExpressionMediator a, (string TableName, string FieldName) b) => new(new FilterExpression<bool?>(a, new AliasExpression<object?>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableObjectExpressionMediator a, (string TableName, string FieldName) b) => new(new FilterExpression<bool?>(a, new AliasExpression<object?>(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableObjectExpressionMediator a, (string TableName, string FieldName) b) => new(new FilterExpression<bool?>(a, new AliasExpression<object?>(b), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableObjectExpressionMediator a, (string TableName, string FieldName) b) => new(new FilterExpression<bool?>(a, new AliasExpression<object?>(b), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableObjectExpressionMediator a, (string TableName, string FieldName) b) => new(new FilterExpression<bool?>(a, new AliasExpression<object?>(b), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableObjectExpressionMediator a, (string TableName, string FieldName) b) => new(new FilterExpression<bool?>(a, new AliasExpression<object?>(b), FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion
    }
}