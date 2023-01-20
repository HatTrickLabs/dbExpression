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
using System;
using System.Linq.Expressions;

namespace HatTrick.DbEx.Sql.Assembler
{
    public abstract class ExpressionElementAppender<T> : ExpressionElementAppender,
        IExpressionElementAppender<T>
        where T : class, IExpressionElement
    {
        public override void AppendElement(IExpressionElement element, ISqlStatementBuilder builder, AssemblyContext context)
        {
            if (element is not T)
                throw new DbExpressionQueryException(element, ExceptionMessages.WrongType(element.GetType(), typeof(T)));

            AppendElement((element as T)!, builder, context);
        }

        public abstract void AppendElement(T element, ISqlStatementBuilder builder, AssemblyContext context);
    }
}
