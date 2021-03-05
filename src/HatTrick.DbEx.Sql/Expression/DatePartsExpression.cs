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

﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class DatePartsExpression : IExpressionElement,
        IEquatable<DatePartsExpression>
    {
        #region interface
        public object Expression { get; }
        #endregion

        #region constructors
        protected DatePartsExpression(object value)
        {
            Expression = value;
        }
        #endregion

        #region to string
        public override string ToString() => Expression.ToString() ?? string.Empty;
        #endregion

        #region equals
        public bool Equals(DatePartsExpression obj)
        {
            if (this.Expression is null && obj.Expression is object) return false;
            if (this.Expression is object && obj.Expression is null) return false;
            if (!this.Expression.Equals(obj.Expression)) return false;

            return true;
        }

        public override bool Equals(object obj)
         => obj is DatePartsExpression exp ? Equals(exp) : false;

        public override int GetHashCode()
            => Expression is object ? Expression.GetHashCode() : 0;
        #endregion
    }
}
