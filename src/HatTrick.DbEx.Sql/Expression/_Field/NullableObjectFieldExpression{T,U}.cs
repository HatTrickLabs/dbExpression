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
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableObjectFieldExpression<TEntity, TType> :
        NullableObjectFieldExpression<TType>,
        IEquatable<NullableObjectFieldExpression<TEntity, TType>>
        where TEntity : class, IDbEntity
        where TType : class
    {
        #region constructors
        public NullableObjectFieldExpression(string identifier, string name, Table entity) : base(identifier, name, entity)
        {

        }
        #endregion

        #region equals
        public bool Equals(NullableObjectFieldExpression<TEntity, TType>? obj)
            => obj is not null && base.Equals(obj);

        public override bool Equals(object? obj)
            => obj is NullableObjectFieldExpression<TEntity, TType> exp && Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region in
        public override FilterExpressionSet In(params TType[] value) => new(new FilterExpression<bool>(this, new InExpression<TType>(this, value), FilterExpressionOperator.None));
        public override FilterExpressionSet In(IEnumerable<TType> value) => new(new FilterExpression<bool>(this, new InExpression<TType>(this, value), FilterExpressionOperator.None));
        #endregion
    }
}