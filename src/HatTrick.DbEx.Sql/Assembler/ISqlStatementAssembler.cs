﻿using HatTrick.DbEx.Sql.Expression;
using System.Collections.Generic;
using System.Data.Common;

namespace HatTrick.DbEx.Sql.Assembler
{
    public interface ISqlStatementAssembler
    {
        SqlStatement Assemble(ExpressionSet expression, ISqlStatementBuilder builder);
    }
}
