﻿using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.Sql.Builder.Syntax
{
    public interface ITypeListContinuationExpressionBuilder<T> : IContinuationExpressionBuilder<T>, ITypeListTerminationExpressionBuilder<T>
    {
    }
}
