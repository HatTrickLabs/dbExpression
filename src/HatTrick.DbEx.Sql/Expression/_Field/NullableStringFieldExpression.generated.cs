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
    public partial class NullableStringFieldExpression
    {
        #region in value set
        public override FilterExpressionSet In(params string[] value) => value is object ? new FilterExpressionSet(new FilterExpression<bool>(this, new InExpression<string>(this, value), FilterExpressionOperator.None)) : null;
        public override FilterExpressionSet In(IEnumerable<string> value) => value is object ? new FilterExpression<bool>(this, new InExpression<string>(this, value), FilterExpressionOperator.None) : null;
        #endregion

        #region implicit operators
        public static implicit operator NullableStringExpressionMediator(NullableStringFieldExpression a) => new NullableStringExpressionMediator(a);
        #endregion

        #region arithmetic operators
        #region data types
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
        public static NullableStringExpressionMediator operator +(NullableStringFieldExpression a, string b) => new NullableStringExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<string>(b, a), ArithmeticExpressionOperator.Add));

        public static NullableStringExpressionMediator operator +(string a, NullableStringFieldExpression b) => new NullableStringExpressionMediator(new ArithmeticExpression(new LiteralExpression<string>(a, b), b, ArithmeticExpressionOperator.Add));

        #endregion        

        #region TimeSpan



        #endregion        

        #endregion

        #region fields











        #region string
        public static NullableStringExpressionMediator operator +(NullableStringFieldExpression a, StringFieldExpression b) => new NullableStringExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));

        public static NullableStringExpressionMediator operator +(NullableStringFieldExpression a, NullableStringFieldExpression b) => new NullableStringExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        #endregion


        #endregion

        #region mediators











        #region string
        public static NullableStringExpressionMediator operator +(NullableStringFieldExpression a, StringExpressionMediator b) => new NullableStringExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));

        public static NullableStringExpressionMediator operator +(NullableStringFieldExpression a, NullableStringExpressionMediator b) => new NullableStringExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        #endregion


        #endregion

        #region alias
        public static ObjectExpressionMediator operator +(NullableStringFieldExpression a, AliasExpression b) => new ObjectExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        public static ObjectExpressionMediator operator +(NullableStringFieldExpression a, (string TableName, string FieldName) b) => new ObjectExpressionMediator(new ArithmeticExpression(a, new AliasExpression(b.TableName, b.FieldName), ArithmeticExpressionOperator.Add));
        #endregion
        #endregion

        #region filter operators
        #region DBNull
        public static FilterExpressionSet operator ==(NullableStringFieldExpression a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableStringFieldExpression a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator ==(DBNull a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(DBNull a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.NotEqual));
        #endregion

        #region data types
        #region string
        public static FilterExpressionSet operator ==(NullableStringFieldExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableStringFieldExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableStringFieldExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableStringFieldExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableStringFieldExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableStringFieldExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<string>(b, a), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(string a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(string a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(string a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(string a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(string a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(string a, NullableStringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<string>(a, b), b, FilterExpressionOperator.GreaterThanOrEqual));

        #endregion
        #endregion

        #region fields
        public static FilterExpressionSet operator ==(NullableStringFieldExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableStringFieldExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableStringFieldExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableStringFieldExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableStringFieldExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableStringFieldExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));

        #endregion
        
        #region mediators
        public static FilterExpressionSet operator ==(NullableStringFieldExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableStringFieldExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableStringFieldExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableStringFieldExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableStringFieldExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableStringFieldExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));

        #endregion

        #region alias
        public static FilterExpressionSet operator ==(NullableStringFieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableStringFieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableStringFieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableStringFieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableStringFieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableStringFieldExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        public static FilterExpressionSet operator ==(NullableStringFieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableStringFieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(NullableStringFieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(NullableStringFieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(NullableStringFieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(NullableStringFieldExpression a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion
    }
}
