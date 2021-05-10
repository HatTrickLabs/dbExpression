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
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class DateAddFunctionExpression : DataTypeFunctionExpression,
        IExpressionListProvider<IExpressionElement>,
        IExpressionProvider<DatePartsExpression>,
        IEquatable<DateAddFunctionExpression>
    {
        #region internals
        private readonly DatePartsExpression datePart;
        private readonly IExpressionElement number;
        private readonly IExpressionElement date;
        #endregion

        #region interface
        IList<IExpressionElement> IExpressionListProvider<IExpressionElement>.Expressions => new List<IExpressionElement> { number, date };
        DatePartsExpression IExpressionProvider<DatePartsExpression>.Expression => datePart;
        #endregion

        #region constructors
        protected DateAddFunctionExpression(DatePartsExpression datePart, IExpressionElement number, IExpressionElement date, Type declaredType) 
            : base(declaredType)
        {
            this.datePart = datePart ?? throw new ArgumentNullException(nameof(datePart));
            this.number = number ?? throw new ArgumentNullException(nameof(number));
            this.date = date ?? throw new ArgumentNullException(nameof(date));
        }
        #endregion

        #region to string
        public override string ToString() => $"DateAdd({datePart}, {number}, {date})";
        #endregion

        #region equals
        public bool Equals(DateAddFunctionExpression obj)
        {
            if (!base.Equals(obj)) return false;

            if (datePart is null && obj.datePart is object) return false;
            if (datePart is object && obj.datePart is null) return false;
            if (!datePart.Equals(obj.datePart)) return false;

            if (this.number is null && obj.number is object) return false;
            if (this.number is object && obj.number is null) return false;
            if (!this.number.Equals(obj.number)) return false;

            if (this.date is null && obj.date is object) return false;
            if (this.date is object && obj.date is null) return false;
            if (!this.date.Equals(obj.date)) return false;

            return true;
        }

        public override bool Equals(object obj)
            => obj is DateAddFunctionExpression exp ? Equals(exp) : false;

        public override int GetHashCode()
        {
            unchecked
            {
                const int multiplier = 16777619;

                int hash = base.GetHashCode();
                hash = (hash * multiplier) ^ (datePart is object ? datePart.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (number is object ? number.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (date is object ? date.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion
    }
}
