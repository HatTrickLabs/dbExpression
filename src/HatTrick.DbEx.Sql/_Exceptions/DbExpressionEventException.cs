﻿#region license
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

using HatTrick.DbEx.Sql.Expression;
using System;
using System.Runtime.Serialization;

namespace HatTrick.DbEx.Sql
{
    [Serializable]
    public class DbExpressionEventException : DbExpressionException
    {
        public IExpressionElement Expression { get; init; }

        public DbExpressionEventException(IExpressionElement expression, string message) 
            : base(message)
        {
            Expression = expression;
        }

        public DbExpressionEventException(IExpressionElement expression, string message, Exception innerException) 
            : base(message, innerException)
        {
            Expression = expression;
        }

        protected DbExpressionEventException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Expression = (IExpressionElement)info.GetValue("Expression", typeof(IExpressionElement))!;
        }
    }
}
