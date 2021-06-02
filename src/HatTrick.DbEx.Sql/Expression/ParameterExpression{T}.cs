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

using System;
using System.Data;

namespace HatTrick.DbEx.Sql.Expression
{
    public class ParameterExpression<TValue> : ParameterExpression,
        IExpressionElement<TValue>,
        IEquatable<ParameterExpression<TValue>>
    {
        #region constructors
        public ParameterExpression(string identifier, string name, ParameterDirection direction) : base(identifier, name, typeof(TValue), direction)
        {

        }

        public ParameterExpression(string identifier, string name, TValue value, ParameterDirection direction) : base(identifier, name, typeof(TValue), value, direction)
        {

        }

        public ParameterExpression(string identifier, string name, DBNull value, ParameterDirection direction) : base(identifier, name, typeof(TValue), value, direction)
        {

        }
        #endregion

        #region equals
        public bool Equals(ParameterExpression<TValue> obj)
            => obj is ParameterExpression<TValue> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is ParameterExpression<TValue> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}