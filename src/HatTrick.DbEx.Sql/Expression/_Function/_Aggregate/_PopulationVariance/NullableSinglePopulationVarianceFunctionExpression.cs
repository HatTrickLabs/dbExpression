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

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableSinglePopulationVarianceFunctionExpression :
        NullablePopulationVarianceFunctionExpression<float,float?>,
        NullableSingleElement,
        AnySingleElement,
        IEquatable<NullableSinglePopulationVarianceFunctionExpression>
    {
        #region constructors
        public NullableSinglePopulationVarianceFunctionExpression(NullableByteElement expression) : base(expression)
        {

        }

        public NullableSinglePopulationVarianceFunctionExpression(NullableInt16Element expression) : base(expression)
        {

        }

        public NullableSinglePopulationVarianceFunctionExpression(NullableInt32Element expression) : base(expression)
        {

        }

        public NullableSinglePopulationVarianceFunctionExpression(NullableInt64Element expression) : base(expression)
        {

        }

        public NullableSinglePopulationVarianceFunctionExpression(NullableDoubleElement expression) : base(expression)
        {

        }

        public NullableSinglePopulationVarianceFunctionExpression(NullableDecimalElement expression) : base(expression)
        {

        }

        public NullableSinglePopulationVarianceFunctionExpression(NullableSingleElement expression) : base(expression)
        {

        }
        #endregion

        #region as
        public NullableSingleElement As(string alias)
            => new NullableSingleSelectExpression(this).As(alias);
        #endregion

        #region distinct
        public NullableSinglePopulationVarianceFunctionExpression Distinct()
        {
            IsDistinct = true;
            return this;
        }
        #endregion

        #region equals
        public bool Equals(NullableSinglePopulationVarianceFunctionExpression obj)
            => obj is NullableSinglePopulationVarianceFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableSinglePopulationVarianceFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
