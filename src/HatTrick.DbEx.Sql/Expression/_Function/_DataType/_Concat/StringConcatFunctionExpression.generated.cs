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

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class StringConcatFunctionExpression
    {
        #region implicit operators
        public static implicit operator StringExpressionMediator(StringConcatFunctionExpression a) => new StringExpressionMediator(a);
        #endregion

        #region arithmetic operators
        #region data types
        #region string
        public static StringExpressionMediator operator +(StringConcatFunctionExpression a, string b) => new StringExpressionMediator(new ArithmeticExpression(a, new LiteralExpression<string>(b), ArithmeticExpressionOperator.Add));

        public static StringExpressionMediator operator +(string a, StringConcatFunctionExpression b) => new StringExpressionMediator(new ArithmeticExpression(new LiteralExpression<string>(a), b, ArithmeticExpressionOperator.Add));


        #endregion
        
        #endregion

        #region fields
        #region string
        public static StringExpressionMediator operator +(StringConcatFunctionExpression a, StringFieldExpression b) => new StringExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));

        #endregion        
        #endregion

        #region mediators
        #region string
        public static StringExpressionMediator operator +(StringConcatFunctionExpression a, StringExpressionMediator b) => new StringExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));

        #endregion        
        #endregion

        #region alias
        public static ObjectExpressionMediator operator +(StringConcatFunctionExpression a, AliasExpression b) => new ObjectExpressionMediator(new ArithmeticExpression(a, b, ArithmeticExpressionOperator.Add));
        #endregion
        #endregion

        #region filter operators
        #region data types
        #region string
        public static FilterExpressionSet operator ==(StringConcatFunctionExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<string>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(StringConcatFunctionExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<string>(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(StringConcatFunctionExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<string>(b), FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(StringConcatFunctionExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<string>(b), FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(StringConcatFunctionExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<string>(b), FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(StringConcatFunctionExpression a, string b) => new FilterExpressionSet(new FilterExpression<bool>(a, new LiteralExpression<string>(b), FilterExpressionOperator.GreaterThanOrEqual));

        public static FilterExpressionSet operator ==(string a, StringConcatFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<string>(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(string a, StringConcatFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<string>(a), b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(string a, StringConcatFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<string>(a), b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(string a, StringConcatFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<string>(a), b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(string a, StringConcatFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<string>(a), b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(string a, StringConcatFunctionExpression b) => new FilterExpressionSet(new FilterExpression<bool>(new LiteralExpression<string>(a), b, FilterExpressionOperator.GreaterThanOrEqual));

        #endregion
        #endregion

        #region fields
        public static FilterExpressionSet operator ==(StringConcatFunctionExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(StringConcatFunctionExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(StringConcatFunctionExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(StringConcatFunctionExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(StringConcatFunctionExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(StringConcatFunctionExpression a, StringFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        

        #endregion

        #region mediators
        public static FilterExpressionSet operator ==(StringConcatFunctionExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(StringConcatFunctionExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(StringConcatFunctionExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(StringConcatFunctionExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(StringConcatFunctionExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(StringConcatFunctionExpression a, StringExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool>(a, b, FilterExpressionOperator.GreaterThanOrEqual));

        #endregion

        #region alias
        public static FilterExpressionSet operator ==(StringConcatFunctionExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(StringConcatFunctionExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator <(StringConcatFunctionExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThan));
        public static FilterExpressionSet operator >(StringConcatFunctionExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThan));
        public static FilterExpressionSet operator <=(StringConcatFunctionExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.LessThanOrEqual));
        public static FilterExpressionSet operator >=(StringConcatFunctionExpression a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.GreaterThanOrEqual));
        #endregion
        #endregion
    }
}
