﻿using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Builder;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Expression;
using System.Collections.Generic;

namespace HatTrick.DbEx.MsSql.Builder
{
    public class MsSqlInsertQueryExpressionBuilder<T> : InsertQueryExpressionBuilder<T>
        where T : class, IDbEntity
    {
        public new InsertQueryExpression Expression => base.Expression as InsertQueryExpression;

        public MsSqlInsertQueryExpressionBuilder(RuntimeSqlDatabaseConfiguration configuration, IEnumerable<T> instances) : base(configuration, instances, configuration.QueryExpressionFactory.CreateQueryExpression<InsertQueryExpression>())
        {
        }
    }
}