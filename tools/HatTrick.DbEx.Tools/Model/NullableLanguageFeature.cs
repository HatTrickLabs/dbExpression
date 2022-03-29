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


namespace HatTrick.DbEx.Tools.Model
{
    public class NullableLanguageFeature
    {
        private NullableFeature? _nullableFeature;
        public bool IsFeatureEnabled => _nullableFeature == NullableFeature.Enable;
        public string Directive => _nullableFeature is not null ? $"#nullable {_nullableFeature.Value.ToString().ToLower()}" : string.Empty;
        public string Annotation => _nullableFeature == NullableFeature.Enable ? "?" : string.Empty;
        public string ForgivingOperator => _nullableFeature == NullableFeature.Enable ? "!" : string.Empty;

        public NullableLanguageFeature(NullableFeature? nullableFeature)
        {
            _nullableFeature = nullableFeature;
        }
    }
}