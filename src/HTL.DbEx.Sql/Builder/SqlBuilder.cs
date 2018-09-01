﻿using HTL.DbEx.Sql.Builder.Syntax;
using HTL.DbEx.Sql.Expression;
using System;
using System.Configuration;

namespace HTL.DbEx.Sql.Builder
{
    public abstract class SqlBuilder :
        IDeleteFromBuilder,
        IDeleteContinuationBuilder, 
        IUpdateInitiationBuilder,
        IUpdateFromBuilder,
        IUpdateContinuationBuilder,
        ITerminationBuilder,
        IDBExpressionProvider
    {
        public DBExpressionSet Expression { get; set; } = new DBExpressionSet();

        protected SqlBuilder(DBExpressionSet expression)
        {
            Expression = expression;
        }

        DBExpressionSet IDBExpressionProvider.GetExpression() => Expression;

        #region Delete
        IDeleteContinuationBuilder IDeleteFromBuilder.From(DBExpressionEntity entity)
        {
            Expression.BaseEntity = entity;
            return this;
        }

        IDeleteContinuationBuilder IDeleteContinuationBuilder.Where(DBWhereExpression filter)
        {
            return Where<IDeleteContinuationBuilder>(filter) as IDeleteContinuationBuilder;
        }

        IDeleteContinuationBuilder IDeleteContinuationBuilder.Where(DBWhereExpressionSet filter)
        {
            return Where<IDeleteContinuationBuilder>(filter) as IDeleteContinuationBuilder;
        }

        IJoinBuilder<IDeleteContinuationBuilder> IDeleteContinuationBuilder.InnerJoin(DBExpressionEntity entity)
        {
            return Join<IDeleteContinuationBuilder>(entity, DBExpressionJoinType.INNER);
        }

        IJoinBuilder<IDeleteContinuationBuilder> IDeleteContinuationBuilder.LeftJoin(DBExpressionEntity entity)
        {
            return Join<IDeleteContinuationBuilder>(entity, DBExpressionJoinType.LEFT);
        }

        IJoinBuilder<IDeleteContinuationBuilder> IDeleteContinuationBuilder.RightJoin(DBExpressionEntity entity)
        {
            return Join<IDeleteContinuationBuilder>(entity, DBExpressionJoinType.RIGHT);
        }

        IJoinBuilder<IDeleteContinuationBuilder> IDeleteContinuationBuilder.FullJoin(DBExpressionEntity entity)
        {
            return Join<IDeleteContinuationBuilder>(entity, DBExpressionJoinType.FULL);
        }

        IJoinBuilder<IDeleteContinuationBuilder> IDeleteContinuationBuilder.CrossJoin(DBExpressionEntity entity)
        {
            return Join<IDeleteContinuationBuilder>(entity, DBExpressionJoinType.CROSS);
        }
        #endregion

        #region Update
        IUpdateContinuationBuilder IUpdateFromBuilder.From(DBExpressionEntity entity)
        {
            Expression.BaseEntity = entity;
            return this as IUpdateContinuationBuilder;
        }

        IUpdateContinuationBuilder IUpdateInitiationBuilder.Update(DBAssignmentExpression[] assignments)
        {
            foreach (var assignment in assignments)
                Expression &= assignment;
            return this as IUpdateContinuationBuilder;
        }

        IUpdateContinuationBuilder IUpdateContinuationBuilder.Where(DBWhereExpression filter)
        {
            return Where<IUpdateContinuationBuilder>(filter) as IUpdateContinuationBuilder;
        }

        IUpdateContinuationBuilder IUpdateContinuationBuilder.Where(DBWhereExpressionSet filter)
        {
            return Where<IUpdateContinuationBuilder>(filter) as IUpdateContinuationBuilder;
        }

        IJoinBuilder<IUpdateContinuationBuilder> IUpdateContinuationBuilder.InnerJoin(DBExpressionEntity entity)
        {
            return Join<IUpdateContinuationBuilder>(entity, DBExpressionJoinType.INNER);
        }

        IJoinBuilder<IUpdateContinuationBuilder> IUpdateContinuationBuilder.LeftJoin(DBExpressionEntity entity)
        {
            return Join<IUpdateContinuationBuilder>(entity, DBExpressionJoinType.LEFT);
        }

        IJoinBuilder<IUpdateContinuationBuilder> IUpdateContinuationBuilder.RightJoin(DBExpressionEntity entity)
        {
            return Join<IUpdateContinuationBuilder>(entity, DBExpressionJoinType.RIGHT);
        }

        IJoinBuilder<IUpdateContinuationBuilder> IUpdateContinuationBuilder.FullJoin(DBExpressionEntity entity)
        {
            return Join<IUpdateContinuationBuilder>(entity, DBExpressionJoinType.FULL);
        }

        IJoinBuilder<IUpdateContinuationBuilder> IUpdateContinuationBuilder.CrossJoin(DBExpressionEntity entity)
        {
            return Join<IUpdateContinuationBuilder>(entity, DBExpressionJoinType.CROSS);
        }
        #endregion

        protected U Where<U>(DBWhereExpressionSet expression) where U : class, IBuilder
        {
            if (Expression.Where == null)
                Expression.Where = expression;
            else
                Expression.Where &= expression;
            return this as U;
        }

        protected U Where<T, U>(DBWhereExpressionSet expression) where U : class, IBuilder<T>
        {
            if (Expression.Where == null)
                Expression.Where = expression;
            else
                Expression.Where &= expression;
            return this as U;
        }

        protected IJoinBuilder<T> Join<T>(DBExpressionEntity joinEntity, DBExpressionJoinType joinType)
            where T : class, IBuilder
        {
            return new JoinBuilder<T>(Expression, joinEntity, joinType, this as T);
        }

        protected IJoinBuilder<T, TBuilder> Join<T, TBuilder>(DBExpressionEntity joinEntity, DBExpressionJoinType joinType)
            where TBuilder : class, IBuilder<T>
        {
            return new JoinBuilder<T, TBuilder>(Expression, joinEntity, joinType, this as TBuilder);
        }
    }
}
