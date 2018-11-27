﻿using HatTrick.DbEx.Sql.Executor;
using HatTrick.DbEx.Sql.Mapper;

namespace HatTrick.DbEx.Sql.Expression
{
    public interface IDbExpressionEntity<T>
    {
        SelectExpressionSet GetInclusiveSelectExpression();

        InsertExpressionSet GetInclusiveInsertExpression(T entity);

        void FillObject(SqlStatementExecutionResultSet.Row data, T entity, IValueMapper mapper);
    }
}