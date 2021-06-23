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
    public partial class DecimalRoundFunctionExpression :
        RoundFunctionExpression<decimal>,
        DecimalElement,
        AnyDecimalElement,
        IEquatable<DecimalRoundFunctionExpression>
    {
        #region constructors
        public DecimalRoundFunctionExpression(DecimalElement expression, IntegralNumericElement length) : base(expression, length)
        {

        }

        public DecimalRoundFunctionExpression(DecimalElement expression, IntegralNumericElement length, IntegralNumericElement function) : base(expression, length, function)
        {

        }
        #endregion

        #region as
        public DecimalElement As(string alias)
            => new DecimalSelectExpression(this).As(alias);
        #endregion

        #region equals
        public bool Equals(DecimalRoundFunctionExpression obj)
            => obj is DecimalRoundFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is DecimalRoundFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
