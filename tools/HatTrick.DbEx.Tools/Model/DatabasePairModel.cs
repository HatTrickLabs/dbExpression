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

﻿using HatTrick.Model.MsSql;
using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Tools.Model
{
    public class DatabasePairModel
    { 
        public MsSqlModel Database { get; set; }
        public DatabaseExpressionModel DatabaseExpression { get; set; }
        public IList<SchemaPairModel> Items { get; set; } = new List<SchemaPairModel>();
        public DocumentationItemsModel Documentation { get; set; }

        public DatabasePairModel(MsSqlModel database, DatabaseExpressionModel databaseExpression)
        {
            Database = database ?? throw new ArgumentNullException(nameof(database));
            DatabaseExpression = databaseExpression ?? throw new ArgumentNullException(nameof(databaseExpression));
        }
    }
}
