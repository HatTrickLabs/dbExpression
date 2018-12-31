﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Sql.Expression
{
    public interface IDbExpressionProvider<T>
        where T : IDbExpression
    {
        T Expression { get; }
    }
}
