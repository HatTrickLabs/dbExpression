﻿using HatTrick.DbEx.Sql.Builder;
using HatTrick.DbEx.Sql.Builder.Syntax;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.MsSql.Builder
{
    public class MsSqlSelectSqlExpressionBuilder<T, U, V> : SelectSqlExpressionBuilder<T, U, V>,
        IDbExpressionSetProvider<SelectQueryExpression>
        where U : class, IContinuationExpressionBuilder<T>
        where V : class, IContinuationExpressionBuilder<T, U>
    {
        public new SelectQueryExpression Expression => base.Expression as SelectQueryExpression;

        public MsSqlSelectSqlExpressionBuilder(DatabaseConfiguration configuration) : base(configuration, configuration.QueryExpressionFactory.CreateQueryExpression<SelectQueryExpression>())
        {

        }
    }
}
