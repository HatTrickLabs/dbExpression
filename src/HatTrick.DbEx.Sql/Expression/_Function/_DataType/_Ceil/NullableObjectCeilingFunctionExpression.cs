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
// The latest version of this file can be found at https://github.com/HatTrickLCeiling/db-ex
#endregion

using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableObjectCeilingFunctionExpression :
        CeilingFunctionExpression<object?>,
        NullableObjectElement<object?>,
        IEquatable<NullableObjectCeilingFunctionExpression>
    {
        #region constructors
        public NullableObjectCeilingFunctionExpression(AnyElement expression) : base(expression)
        {

        }
        #endregion

        #region as
        public NullableObjectElement<object?> As(string alias)
            => new NullableObjectSelectExpression<object?>(this).As(alias);
        #endregion

        #region equals
        public bool Equals(NullableObjectCeilingFunctionExpression? obj)
            => obj is not null && base.Equals(obj);

        public override bool Equals(object? obj)
            => obj is NullableObjectCeilingFunctionExpression exp && Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
