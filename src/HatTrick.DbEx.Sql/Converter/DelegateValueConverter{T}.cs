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
    public class DelegateValueConverter<T> : IValueConverter
    {
        #region internals
        private readonly Func<object, object> convertToDatabase;
        private readonly Func<object, object> convertFromDatabase;
        #endregion

        #region constructors
        public DelegateValueConverter(Func<T, object> convertToDatabase, Func<object, T> convertFromDatabase)
        {
            if (convertToDatabase is null)
                throw new ArgumentNullException(nameof(convertToDatabase));

            if (convertFromDatabase is null)
                throw new ArgumentNullException(nameof(convertFromDatabase));

            this.convertToDatabase = o => convertToDatabase((T)o);
            this.convertFromDatabase = o => convertFromDatabase(o);
        }
        #endregion

        #region methods
        public (Type Type, object ConvertedValue) ConvertToDatabase(object value)
            => (typeof(T), convertToDatabase(value));

        public object ConvertFromDatabase(object value)
            => convertFromDatabase(value);

        public U ConvertFromDatabase<U>(object value)
            => (U)convertFromDatabase(value);
        #endregion
    }
}
