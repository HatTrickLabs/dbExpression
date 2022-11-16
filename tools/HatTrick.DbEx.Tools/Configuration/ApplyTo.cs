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

using System.Collections.Generic;
using System.Linq;

namespace HatTrick.DbEx.Tools.Configuration
{
    public class ApplyTo
    {
        public string Path { get; set; } = string.Empty;

        public ObjectType ObjectType { get; set; } = Configuration.ObjectType.Any;

        public Dictionary<string, object> Match { get; set; } = new();

        public override string? ToString()
        {
            return $"path: {Path}, objectType: {ObjectType}, match: {Match.Keys.Aggregate(string.Empty, (s, k) => s += $",{k}", s => s.TrimStart(','))}";
        }
    }
}
