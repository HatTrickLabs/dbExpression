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
using System.Collections.Generic;
using System.Linq;

namespace HatTrick.DbEx.Sql.Expression
{
    public class InsertExpressionSet : IExpression
    {
        #region interface
        public IDbEntity Entity { get; }
        public IEnumerable<InsertExpression> Expressions { get; private set; } = new List<InsertExpression>();
        #endregion

        #region constructors
        protected InsertExpressionSet() { }

        public InsertExpressionSet(IDbEntity entity, IEnumerable<InsertExpression> fields)
        {
            Entity = entity ?? throw new ArgumentNullException(nameof(entity));
            Expressions = fields ?? throw new ArgumentNullException(nameof(fields));
        }
        #endregion

        #region to string
        public override string ToString() => string.Join(", ", Expressions.Select(g => g.ToString()));
        #endregion
    }
}
