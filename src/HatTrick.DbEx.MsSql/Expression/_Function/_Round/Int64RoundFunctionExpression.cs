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
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.MsSql.Expression
{
    public partial class Int64RoundFunctionExpression :
        RoundFunctionExpression<long>,
        Int64Element,
        AnyInt64Element,
        IEquatable<Int64RoundFunctionExpression>
    {
        #region constructors
        public Int64RoundFunctionExpression(Int64Element expression, IntegralNumericElement length) : base(expression, length)
        {

        }

        public Int64RoundFunctionExpression(Int64Element expression, IntegralNumericElement length, IntegralNumericElement function) : base(expression, length, function)
        {

        }
        #endregion

        #region as
        public Int64Element As(string alias)
            => new Int64SelectExpression(this).As(alias);
        #endregion

        #region equals
        public bool Equals(Int64RoundFunctionExpression obj)
            => obj is Int64RoundFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is Int64RoundFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}