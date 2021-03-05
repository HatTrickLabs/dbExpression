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
    public abstract class CastFunctionExpression : ConversionFunctionExpression,
        IEquatable<CastFunctionExpression>
    {
        #region interface
        public DbTypeExpression ConvertToDbType { get; set; }
        public int? Size { get; set; }
        public int? Precision { get; set; }
        public int? Scale { get; set; }
        #endregion

        #region constructors
        protected CastFunctionExpression(IExpressionElement expression, DbTypeExpression convertToDbType, Type convertToType) : base(expression, convertToType)
        {
            ConvertToDbType = convertToDbType ?? throw new ArgumentNullException(nameof(convertToDbType));
        }

        protected CastFunctionExpression(IExpressionElement expression, DbTypeExpression convertToDbType, Type convertToType, int size) : base(expression, convertToType)
        {
            ConvertToDbType = convertToDbType ?? throw new ArgumentNullException(nameof(convertToDbType));
            Size = size;
        }

        protected CastFunctionExpression(IExpressionElement expression, DbTypeExpression convertToDbType, Type convertToType, int precision, int? scale) : base(expression, convertToType)
        {
            ConvertToDbType = convertToDbType ?? throw new ArgumentNullException(nameof(convertToDbType));
            Precision = precision;
            Scale = scale;
        }
        #endregion

        #region to string
        public override string ToString() => $"CAST({Expression} AS {ConvertToDbType}{(Size.HasValue ? $"({Size})" : "")})";
        #endregion

        #region equals
        public bool Equals(CastFunctionExpression obj)
        {
            if (!base.Equals(obj)) return false;

            if (this.ConvertToDbType is null && obj.ConvertToDbType is object) return false;
            if (this.ConvertToDbType is object && obj.ConvertToDbType is null) return false;
            if (!this.ConvertToDbType.Equals(obj.ConvertToDbType)) return false;

            if (this.Size is null && obj.Size is object) return false;
            if (this.Size is object && obj.Size is null) return false;
            if (!this.Size.Equals(obj.Size)) return false;

            if (this.Scale is null && obj.Scale is object) return false;
            if (this.Scale is object && obj.Scale is null) return false;
            if (!this.Scale.Equals(obj.Scale)) return false;

            return true;
        }

        public override bool Equals(object obj)
            => obj is CastFunctionExpression exp ? Equals(exp) : false;

        public override int GetHashCode()
        {
            unchecked
            {
                const int multiplier = 16777619;

                int hash = base.GetHashCode();
                hash = (hash * multiplier) ^ (ConvertToDbType is object ? ConvertToDbType.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (Size is object ? Size?.GetHashCode() ?? 0 : 0);
                hash = (hash * multiplier) ^ (Precision is object ? Precision?.GetHashCode() ?? 0 : 0);
                hash = (hash * multiplier) ^ (Scale is object ? Scale?.GetHashCode() ?? 0 : 0);
                return hash;
            }
        }
        #endregion
    }
}
