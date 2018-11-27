﻿using HatTrick.DbEx.Sql.Executor;
using System;

namespace HatTrick.DbEx.Sql.Mapper
{
    public class EntityMapper<T> : IEntityMapper<T>
        where T : class, IDbEntity
    {
        public Action<SqlStatementExecutionResultSet.Row, T, IValueMapper> Map { get; private set; }

        public EntityMapper(Action<SqlStatementExecutionResultSet.Row, T, IValueMapper> mapper)
        {
            Map = mapper;
        }
    }
}