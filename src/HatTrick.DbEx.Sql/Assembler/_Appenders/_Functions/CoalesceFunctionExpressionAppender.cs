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
using System.Linq;

namespace HatTrick.DbEx.Sql.Assembler
{
    public class CoalesceFunctionExpressionAppender : ExpressionElementAppender<CoalesceFunctionExpression>
    {
        #region methods
        public override void AppendElement(CoalesceFunctionExpression expression, ISqlStatementBuilder builder, AssemblyContext context)
        {
            if (!expression.Expression.Any())
                return;

            builder.Appender.Write("COALESCE(");
            for (var i = 0; i < expression.Expression.Count; i++)
            {
                builder.AppendElement(expression.Expression[i], context);
                if (i < expression.Expression.Count - 1)
                    builder.Appender.Write(", ");
            }
            builder.Appender.Write(")");
        }
        #endregion
    }
}