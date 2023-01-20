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

namespace HatTrick.DbEx.Sql.Converter
{
    public class StringEnumValueConverter<TEnum> : StringEnumValueConverter, IValueConverter<TEnum>
        where TEnum : struct, Enum, IComparable
    {
        public StringEnumValueConverter() : base(typeof(TEnum))
        {

        }

        public new virtual TEnum ConvertFromDatabase(object? value)
        {
            if (value is not string)
                throw new DbExpressionConversionException(value, ExceptionMessages.NullValueUnexpected());
            
            try
            {
                return (TEnum)Enum.Parse(typeof(TEnum), (value as string)!);
            }
            catch (Exception e)
            {
                throw new DbExpressionConversionException(value, ExceptionMessages.ValueConversionFailed(value, value?.GetType(), typeof(TEnum)), e);
            }
        }

    }
}
