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

﻿using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.Sql.Assembler
{
    public class CastFunctionExpressionAppender : ExpressionElementAppender<CastFunctionExpression>
    {
        #region methods
        public override void AppendElement(CastFunctionExpression expression, ISqlStatementBuilder builder, AssemblyContext context)
        {
            var options = (expression as IExpressionProvider<CastFunctionExpression.CastFunctionExpressionOptions>).Expression!;

            builder.Appender.Write("CAST(");
            builder.AppendElement((expression as IExpressionProvider<IExpressionElement>).Expression!, context);
            builder.Appender.Write(" AS ");

            builder.AppendElement(options.ConvertToDbType, context);

            if (options.Size.HasValue)
            {
                builder.Appender.Write("(");
                builder.Appender.Write(options.Size.Value.ToString());
                builder.Appender.Write(")");
            }
            else
            {
                if (options.Precision.HasValue)
                {
                    builder.Appender.Write("(");
                    builder.Appender.Write(options.Precision.Value.ToString());
                    if (options.Scale.HasValue)
                    {
                        builder.Appender.Write(", ");
                        builder.Appender.Write(options.Scale.Value.ToString());
                    }
                    builder.Appender.Write(")");
                }
            }
            builder.Appender.Write(")");
        }
        #endregion
    }
}
