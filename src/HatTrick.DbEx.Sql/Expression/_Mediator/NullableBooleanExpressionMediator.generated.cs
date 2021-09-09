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
    public partial class NullableBooleanExpressionMediator
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
        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(a, a.Expression is FieldExpression field ? new LiteralExpression<bool?>(b, field) : new LiteralExpression<bool?>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, DBNull b) => new FilterExpressionSet(new FilterExpression<bool?>(a, a.Expression is FieldExpression field ? new LiteralExpression<bool?>(b, field) : new LiteralExpression<bool?>(b), FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator ==(DBNull a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<bool?>(a), b.Expression is FieldExpression field ? new LiteralExpression<bool?>(a, field) : new LiteralExpression<bool?>(a), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(DBNull a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<bool?>(a), b.Expression is FieldExpression field ? new LiteralExpression<bool?>(a, field) : new LiteralExpression<bool?>(a), FilterExpressionOperator.NotEqual));
        #endregion

        #region data type
        #region bool
        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<bool>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, bool b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<bool>(b), FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(bool a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<bool>(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(bool a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<bool>(a), b, FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<bool?>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, bool? b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new LiteralExpression<bool?>(b), FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(bool? a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<bool?>(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(bool? a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(new LiteralExpression<bool?>(a), b, FilterExpressionOperator.NotEqual));
        #endregion
        #endregion

        #region fields
        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, BooleanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, BooleanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, NullableBooleanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, NullableBooleanFieldExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        #endregion
        
        #region mediator
        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, BooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, NullableBooleanExpressionMediator b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        #endregion

        #region alias
        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, AliasExpression b) => new FilterExpressionSet(new FilterExpression<bool?>(a, b, FilterExpressionOperator.NotEqual));
        public static FilterExpressionSet operator ==(NullableBooleanExpressionMediator a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(NullableBooleanExpressionMediator a, (string TableName, string FieldName) b) => new FilterExpressionSet(new FilterExpression<bool?>(a, new AliasExpression(b.TableName, b.FieldName), FilterExpressionOperator.NotEqual));
        #endregion
        #endregion
    }
}
