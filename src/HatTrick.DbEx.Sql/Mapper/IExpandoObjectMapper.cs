﻿using HatTrick.DbEx.Sql.Executor;
using System.Dynamic;

namespace HatTrick.DbEx.Sql.Mapper
{
    public interface IExpandoObjectMapper : IMapper
    {
        void Map(ExpandoObject xpando, ISqlRow row, IValueConverterFinder finder);
    }
}