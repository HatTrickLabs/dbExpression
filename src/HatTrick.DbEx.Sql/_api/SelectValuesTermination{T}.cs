﻿using HatTrick.DbEx.Sql.Builder;

namespace HatTrick.DbEx.Sql
{
#pragma warning disable IDE1006 // Naming Styles
    public interface SelectValuesTermination<T> :
#pragma warning restore IDE1006 // Naming Styles
        IExpressionBuilder<T>,
        ISelectTerminationExpressionBuilder
    {
    }
}
