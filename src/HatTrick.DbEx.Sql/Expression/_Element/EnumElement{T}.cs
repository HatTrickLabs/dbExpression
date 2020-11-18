﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
#pragma warning disable IDE1006 // Naming Styles
    public interface EnumElement<TEnum> : AnyNonNullElement
#pragma warning restore IDE1006 // Naming Styles
        where TEnum : struct, Enum, IComparable
    {
        EnumElement<TEnum> As(string alias);
    }
}
