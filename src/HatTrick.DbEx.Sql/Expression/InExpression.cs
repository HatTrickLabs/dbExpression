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
using System.Collections;
using System.Text;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class InExpression :
        IExpressionElement,
        IEquatable<InExpression>
    {
        #region interface
        public IEnumerable Expression { get; private set; }
        #endregion

        #region constructors
        protected InExpression(IEnumerable expression)
        {
            Expression = expression;
        }
        #endregion

        #region tostring
        public override string ToString()
        {
            if (Expression is null)
                return "null";

            var builder = new StringBuilder();
            var enumerator = Expression.GetEnumerator();
            var firstElement = true;
            while (enumerator.MoveNext())
            {
                if (!firstElement)
                {
                    builder.Append(',');
                }
                else
                {
                    firstElement = false;
                }
                builder.Append(enumerator.Current);
            }

            return builder.ToString();
        }
        #endregion

        #region equals
        public bool Equals(InExpression obj)
        {
            if (obj is null) return false;

            if (Expression is null && obj.Expression is object) return false;
            if (Expression is object && obj.Expression is null) return false;
            if (!Expression.Equals(obj.Expression)) return false;

            return true;
        }

        public override bool Equals(object obj)
            => obj is InExpression exp && Equals(exp);

        public override int GetHashCode()
        {
            unchecked
            {
                const int @base = (int)2166136261;
                const int multiplier = 16777619;

                int hash = @base;
                hash = (hash * multiplier) ^ (Expression is object ? Expression.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion
    }
}