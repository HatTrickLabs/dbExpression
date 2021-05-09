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

namespace HatTrick.DbEx.Sql.Configuration
{
    public interface IValueConverterFactoryContinuationConfigurationBuilder
    {
        /// <summary>
        /// Override the default behaviour of converting <typeparamref name="TEnum"/> values to and from a different value type. 
        /// </summary>
        /// <typeparam name="TEnum">The type of the enumeration.</typeparam>
        IEnumTypeValueConverterConfigurationBuilder<TEnum> OverrideForEnumType<TEnum>()
            where TEnum : struct, Enum, IComparable;

        /// <summary>
        /// Override the default behaviour of converting values to and from a different value type using the provided value converter. 
        /// </summary>
        /// <typeparam name="TValue">The type of the value that will be converted to another value type.</typeparam>
        IValueTypeValueConverterConfigurationBuilder<TValue> OverrideForType<TValue>()
            where TValue : struct, IComparable;
    }
}
