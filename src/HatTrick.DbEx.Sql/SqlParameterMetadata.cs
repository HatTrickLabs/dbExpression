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

namespace HatTrick.DbEx.Sql
{
    public class SqlParameterMetadata :
        ISqlParameterMetadata,
        IEquatable<SqlParameterMetadata>
    {
        public ISqlStoredProcedureMetadata StoredProcedure { get; private set; }
        public string Identifier { get; private set; }
        public string Name { get; private set; }
        public object DbType { get; private set; }
        public int? Size { get; private set; }
        public byte? Precision { get; private set; }
        public byte? Scale { get; private set; }

        public SqlParameterMetadata()
        { }

        public SqlParameterMetadata(ISqlStoredProcedureMetadata parent, string identifier, string name, object dbType)
        {
            StoredProcedure = parent;
            Identifier = identifier;
            Name = name;
            DbType = dbType;
        }

        public SqlParameterMetadata(ISqlStoredProcedureMetadata parent, string identifier, string name, object dbType, int size)
        {
            StoredProcedure = parent;
            Identifier = identifier;
            Name = name;
            DbType = dbType;
            Size = size;
        }

        public SqlParameterMetadata(ISqlStoredProcedureMetadata parent, string identifier, string name, object dbType, byte precision, byte scale)
        {
            StoredProcedure = parent;
            Identifier = identifier;
            Name = name;
            DbType = dbType;
            Precision = precision;
            Scale = scale;
        }

        #region equals
        public bool Equals(SqlParameterMetadata obj)
        {
            if (obj is null) return false;

            if (StoredProcedure is null && obj.StoredProcedure is object) return false;
            if (StoredProcedure is object && obj.StoredProcedure is null) return false;
            if (!StoredProcedure.Equals(obj.StoredProcedure)) return false;

            if (!StringComparer.Ordinal.Equals(Identifier, obj.Identifier)) return false;

            if (!StringComparer.Ordinal.Equals(Name, obj.Name)) return false;

            if (DbType is null && obj.DbType is object) return false;
            if (DbType is object && obj.DbType is null) return false;
            if (!DbType.Equals(obj.DbType)) return false;

            if (Size is null && obj.Size is object) return false;
            if (Size is object && obj.Size is null) return false;
            if (!Size.Equals(obj.Size)) return false;

            if (Precision is null && obj.Precision is object) return false;
            if (Precision is object && obj.Precision is null) return false;
            if (!Precision.Equals(obj.Precision)) return false;

            if (Scale is null && obj.Scale is object) return false;
            if (Scale is object && obj.Scale is null) return false;
            if (!Scale.Equals(obj.Scale)) return false;

            return true;
        }

        public override bool Equals(object obj)
            => obj is SqlParameterMetadata exp && Equals(exp);

        public override int GetHashCode()
        {
            unchecked
            {
                const int @base = (int)2166136261;
                const int multiplier = 16777619;

                int hash = @base;
                hash = (hash * multiplier) ^ (StoredProcedure is object ? StoredProcedure.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (Identifier is object ? Identifier.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (Name is object ? Name.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (DbType is object ? DbType.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (Size is object ? Size.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (Precision is object ? Precision.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (Scale is object ? Scale.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion
    }
}