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

namespace HatTrick.DbEx.Sql.Converter
{
    public class DateTimeOffsetValueConverter : ValueConverter<DateTimeOffset>, IValueConverter<DateTimeOffset>
    {
        public override (Type Type, object? ConvertedValue) ConvertToDatabase(object? value)
        {
            if (value is null)
                throw new DbExpressionException("Expected a non-null value from the database, but received a null value.");

            if (value is DateTimeOffset)
                return (typeof(DateTimeOffset), (DateTimeOffset)value);

            if (value is DateTime)
            {
                if (((DateTime)value).Kind == DateTimeKind.Unspecified)
                    throw new DbExpressionException("Cannot convert a value from DateTime to DateTimeOffset without loss of time zone information.");

                return (typeof(DateTimeOffset), new DateTimeOffset((DateTime)value));
            }

            return base.ConvertToDatabase(value);
        }

        public override DateTimeOffset ConvertFromDatabase(object? value)
        {
            if (value is null)
                throw new DbExpressionException("Expected a non-null value from the database, but received a null value.");

            if (value is DateTimeOffset)
                return (DateTimeOffset)value;

            if (value is DateTime)
            {
                if (((DateTime)value).Kind == DateTimeKind.Unspecified)
                    throw new DbExpressionException("Cannot convert a value from DateTime to DateTimeOffset without loss of time zone information.");

                return new DateTimeOffset((DateTime)value);
            }

            return base.ConvertFromDatabase(value);
        }
    }
}
