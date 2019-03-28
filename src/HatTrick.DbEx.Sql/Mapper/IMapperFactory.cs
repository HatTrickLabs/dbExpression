﻿using HatTrick.DbEx.Sql.Executor;
using HatTrick.DbEx.Sql.Expression;
using System;

namespace HatTrick.DbEx.Sql.Mapper
{
    public interface IMapperFactory
    {
        void RegisterEntityMapper<T>(Action<T, ISqlFieldReader, IValueMapper> mapFunction)
            where T : class, IDbEntity;

        void RegisterValueMapper<T>(IValueMapper<T> mapper)
           where T : IComparable;

        void RegisterValueMapper<T>(Func<IValueMapper<T>> mapper)
           where T : IComparable;

        IEntityMapper<T> CreateEntityMapper<T>(EntityExpression<T> entity)
            where T : class, IDbEntity;

        IValueMapper<T> CreateValueMapper<T>();

        IExpandoObjectMapper CreateExpandoObjectMapper();

        IValueMapper CreateValueMapper();
    }
}
