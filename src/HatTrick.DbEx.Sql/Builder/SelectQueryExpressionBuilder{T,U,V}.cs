﻿using HatTrick.DbEx.Sql.Builder.Syntax;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Expression;
using System.Linq;

namespace HatTrick.DbEx.Sql.Builder
{
    public abstract class SelectQueryExpressionBuilder<T, U, V> : SelectQueryExpressionBuilder<T, U>,
        IFromExpressionBuilder<T, U, V>,
        IListFromExpressionBuilder<T, U, V>
        where U : class, IContinuationExpressionBuilder<T>
        where V : class, IContinuationExpressionBuilder<T, U>
    {
        private SelectQueryExpression expression => Expression as SelectQueryExpression;

        public SelectQueryExpressionBuilder(RuntimeSqlDatabaseConfiguration configuration, SelectQueryExpression expression) : base(configuration, expression)
        {
        }

        IListFromExpressionBuilder<T, U, V> IListFromExpressionBuilder<T, U, V>.Distinct()
        {
            expression.Select.Distinct(true);
            return this;
        }

        IListFromExpressionBuilder<T, U, V> IListFromExpressionBuilder<T, U, V>.Top(int count)
        {
            expression.Select.Top(count);
            return this;
        }

        V IListFromExpressionBuilder<T, U, V>.From(EntityExpression entity)
        {
            Expression.BaseEntity = entity;
            SelectExpressionSet select = expression.Select;
            if (select is null || !select.Expressions.Any())
            {
                expression.Select = new SelectExpressionSet((entity as IExpressionEntity<T>).BuildInclusiveSelectExpression())
                    .Distinct((select as IExpressionIsDistinctProvider).IsDistinct)
                    .Top((select as IExpressionTopProvider).Top);
            }
            return this as V;
        }

        V IFromExpressionBuilder<T, U, V>.From<W>(EntityExpression<W> entity)
        {
            Expression.BaseEntity = entity;
            SelectExpressionSet select = expression.Select;
            if (select is null || !select.Expressions.Any())
            {
                expression.Select = new SelectExpressionSet((entity as IExpressionEntity<T>).BuildInclusiveSelectExpression())
                    .Distinct((select as IExpressionIsDistinctProvider).IsDistinct)
                    .Top((select as IExpressionTopProvider).Top);
            }
            return this as V;
        }
    }
}