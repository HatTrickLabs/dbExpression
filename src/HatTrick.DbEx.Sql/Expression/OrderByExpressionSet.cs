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
    public class OrderByExpressionSet :
        AnyOrderByClause,
        IExpressionListProvider<AnyOrderByClause>
    {
        #region interface
        public IEnumerable<AnyOrderByClause> Expressions { get; private set; }  = new List<AnyOrderByClause>();
        #endregion

        #region constructors
        private OrderByExpressionSet()
        { 
        
        }

        public OrderByExpressionSet(AnyOrderByClause orderBy)
        {
            Expressions = Expressions.Concat(new AnyOrderByClause[1] { (orderBy ?? throw new ArgumentNullException(nameof(orderBy))) is OrderByExpression ? orderBy : new OrderByExpression(orderBy, OrderExpressionDirection.ASC) });
        }

        public OrderByExpressionSet(OrderByExpression aOrderBy, OrderByExpression bOrderBy)
        {
            Expressions = new List<AnyOrderByClause>
            {
                aOrderBy ?? throw new ArgumentNullException(nameof(aOrderBy)),
                bOrderBy ?? throw new ArgumentNullException(nameof(bOrderBy))
            };
        }

        public OrderByExpressionSet(IEnumerable<AnyOrderByClause> orderBys)
        {
            Expressions = (orderBys ?? throw new ArgumentNullException(nameof(orderBys))).Select(x => x is OrderByExpression ? x : new OrderByExpression(x, OrderExpressionDirection.ASC));
        }
        #endregion

        #region to string
        public override string ToString() => string.Join(", ", Expressions.Select(g => g.ToString()));
        #endregion

        #region condition & operators
        public static OrderByExpressionSet operator &(OrderByExpressionSet aSet, OrderByExpression b)
        {
            if (aSet is null)
            {
                aSet = b;
            }
            else
            {
                aSet.Expressions = aSet.Expressions.Concat(new AnyOrderByClause[1] { b });
            }
            return aSet;
        }

        public static OrderByExpressionSet operator &(OrderByExpressionSet aSet, OrderByExpressionSet bSet)
        {
            if (aSet is null)
                return bSet;

            aSet.Expressions = aSet.Expressions.Concat(bSet?.Expressions);
            return aSet;
        }
        #endregion
    }
    
}
