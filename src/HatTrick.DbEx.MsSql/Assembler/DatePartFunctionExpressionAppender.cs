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

using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Expression;
using System.Linq;

namespace HatTrick.DbEx.MsSql.Assembler
{
    public class DatePartFunctionExpressionAppender : ExpressionElementAppender<DatePartFunctionExpression>
    {
        #region methods
        public override void AppendElement(DatePartFunctionExpression expression, ISqlStatementBuilder builder, AssemblyContext context)
        {
            var datePart = (expression as IExpressionProvider<DatePartsExpression>).Expression!;
            var part = (expression as IExpressionProvider<IExpressionElement>).Expression!;

            var value = datePart.Expression.ToString()?.ToLower();
            if (value is null)
                throw new DbExpressionQueryException(expression, ExceptionMessages.NullValueUnexpected());

            builder.Appender
                .Write("DATEPART(")
                .Write(value)
                .Write(", ");

            builder.AppendElement(part, context);
            builder.Appender.Write(")");
        }
        #endregion
    }
}
