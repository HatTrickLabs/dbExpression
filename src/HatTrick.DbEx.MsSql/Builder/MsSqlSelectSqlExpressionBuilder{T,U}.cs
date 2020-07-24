﻿using HatTrick.DbEx.Sql.Builder;
using HatTrick.DbEx.Sql.Builder.Syntax;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.MsSql.Builder
{
    public class MsSqlSelectSqlExpressionBuilder<T,U> : SelectSqlExpressionBuilder<T, U>
        where U : class, IContinuationExpressionBuilder<T>
    {
        public MsSqlSelectSqlExpressionBuilder(DatabaseConfiguration configuration) : base(configuration, configuration.QueryExpressionFactory.CreateQueryExpression<SelectQueryExpression>())
        { }
    }
}
