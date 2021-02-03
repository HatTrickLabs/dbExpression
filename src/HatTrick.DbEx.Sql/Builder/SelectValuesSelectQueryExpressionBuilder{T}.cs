﻿using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Expression;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Builder
{
    public abstract class SelectValuesSelectQueryExpressionBuilder<TValue> : SelectQueryExpressionBuilder,
        IExpressionBuilder<TValue>,
        SelectValues<TValue>,
        SelectValuesContinuation<TValue>,
        SelectValuesSkipContinuation<TValue>,
        SelectValuesOrderByContinuation<TValue>
    {
        #region constructors
        protected SelectValuesSelectQueryExpressionBuilder(RuntimeSqlDatabaseConfiguration config, SelectQueryExpression expression) 
            : base(config, expression)
        {

        }
        #endregion

        #region methods
        SelectValues<TValue> SelectValues<TValue>.Top(int value)
        {
            Top(value);
            return this;
        }

        SelectValues<TValue> SelectValues<TValue>.Distinct()
        {
            Distinct();
            return this;
        }

        SelectValuesContinuation<TValue> SelectValues<TValue>.From<TEntity>(Entity<TEntity> entity)
        {
            From(entity);
            return this;
        }

        SelectValuesOrderByContinuation<TValue> SelectValuesContinuation<TValue>.OrderBy(params AnyOrderByClause[] orderBy)
        {
            OrderBy(orderBy);
            return this;
        }

        SelectValuesOrderByContinuation<TValue> SelectValuesContinuation<TValue>.OrderBy(IEnumerable<AnyOrderByClause> orderBy)
        {
            OrderBy(orderBy);
            return this;
        }

        SelectValuesContinuation<TValue> SelectValuesContinuation<TValue>.GroupBy(params AnyGroupByClause[] groupBy)
        {
            GroupBy(groupBy);
            return this;
        }

        SelectValuesContinuation<TValue> SelectValuesContinuation<TValue>.GroupBy(IEnumerable<AnyGroupByClause> groupBy)
        {
            GroupBy(groupBy);
            return this;
        }

        SelectValuesContinuation<TValue> SelectValuesContinuation<TValue>.Having(AnyHavingClause having)
        {
            Having(having);
            return this;
        }

        SelectValuesContinuation<TValue> SelectValuesContinuation<TValue>.Where(AnyWhereClause where)
        {
            Where(where);
            return this;
        }

        JoinOn<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.InnerJoin(AnyEntity entity)
            => new SelectValuesJoinBuilder<TValue>(Expression, entity, JoinOperationExpressionOperator.INNER, this);

        JoinOnWithAlias<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.InnerJoin(AnySelectSubquery subquery)
            => new SelectValuesJoinBuilder<TValue>(Expression, (subquery as IQueryExpressionProvider).Expression, JoinOperationExpressionOperator.INNER, this);

        JoinOn<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.LeftJoin(AnyEntity entity)
            => new SelectValuesJoinBuilder<TValue>(Expression, entity, JoinOperationExpressionOperator.LEFT, this);

        JoinOnWithAlias<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.LeftJoin(AnySelectSubquery subquery)
            => new SelectValuesJoinBuilder<TValue>(Expression, (subquery as IQueryExpressionProvider).Expression, JoinOperationExpressionOperator.LEFT, this);

        JoinOn<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.RightJoin(AnyEntity entity)
            => new SelectValuesJoinBuilder<TValue>(Expression, entity, JoinOperationExpressionOperator.RIGHT, this);

        JoinOnWithAlias<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.RightJoin(AnySelectSubquery subquery)
            => new SelectValuesJoinBuilder<TValue>(Expression, (subquery as IQueryExpressionProvider).Expression, JoinOperationExpressionOperator.RIGHT, this);

        JoinOn<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.FullJoin(AnyEntity entity)
            => new SelectValuesJoinBuilder<TValue>(Expression, entity, JoinOperationExpressionOperator.FULL, this);

        JoinOnWithAlias<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.FullJoin(AnySelectSubquery subquery)
            => new SelectValuesJoinBuilder<TValue>(Expression, (subquery as IQueryExpressionProvider).Expression, JoinOperationExpressionOperator.FULL, this);

        JoinOn<SelectValuesContinuation<TValue>> SelectValuesContinuation<TValue>.CrossJoin(AnyEntity entity)
            => new SelectValuesJoinBuilder<TValue>(Expression, entity, JoinOperationExpressionOperator.CROSS, this);

        SelectValuesSkipContinuation<TValue> SelectValuesOrderByContinuation<TValue>.Skip(int value)
        {
            Skip(value);
            return this;
        }

        SelectValuesOrderByContinuation<TValue> Limit<SelectValuesOrderByContinuation<TValue>>.Limit(int value)
        {
            Limit(value);
            return this;
        }

        SelectValuesOrderByContinuation<TValue> SelectValuesOrderByContinuation<TValue>.GroupBy(params AnyGroupByClause[] groupBy)
        {
            GroupBy(groupBy);
            return this;
        }

        SelectValuesOrderByContinuation<TValue> SelectValuesOrderByContinuation<TValue>.GroupBy(IEnumerable<AnyGroupByClause> groupBy)
        {
            GroupBy(groupBy);
            return this;
        }

        SelectValuesOrderByContinuation<TValue> Limit<SelectValuesOrderByContinuation<TValue>>.Having(AnyHavingClause having)
        {
            Having(having);
            return this;
        }

        SelectValuesOrderByContinuation<TValue> SelectValuesOrderByContinuation<TValue>.Having(AnyHavingClause having)
        {
            Having(having);
            return this;
        }
        #endregion
    }
}
