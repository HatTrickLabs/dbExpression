#region license
// Copyright (c) dbExpression.  All rights reserved.
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
// The latest version of this file can be found at https://github.com/dbexpression-team/dbexpression
#endregion

﻿using System;

namespace DbExpression.Sql.Expression
{
    public abstract class SystemFunctionExpression : FunctionExpression,
        AnyGroupByExpression
    {
        #region constructors
        protected SystemFunctionExpression(Type declaredType) 
            : base(declaredType)
        {

        }
        #endregion

        #region implicit operators
        public static implicit operator GroupByExpression(SystemFunctionExpression a) => new GroupByExpression(a);
        #endregion
    }
}
