﻿using HTL.DbEx.Sql.Expression;

namespace HTL.DbEx.Sql.Builder.Syntax
{
    public interface IValueListContinuationBuilder<T,U> : IValueListContinuationBuilder<T>, IContinuationBuilder<T,U>
        where U : class, IContinuationBuilder<T>
    {
        IValueListContinuationBuilder<T, U> Where(DBWhereExpression expression);
        IValueListContinuationBuilder<T, U> Where(DBWhereExpressionSet expression);
        IJoinBuilder<T, IValueListContinuationBuilder<T, U>> InnerJoin(DBExpressionEntity entity);
        IJoinBuilder<T, IValueListContinuationBuilder<T, U>> LeftJoin(DBExpressionEntity entity);
        IJoinBuilder<T, IValueListContinuationBuilder<T, U>> RightJoin(DBExpressionEntity entity);
        IJoinBuilder<T, IValueListContinuationBuilder<T, U>> FullJoin(DBExpressionEntity entity);
        IJoinBuilder<T, IValueListContinuationBuilder<T, U>> CrossJoin(DBExpressionEntity entity);
        IValueListContinuationBuilder<T, U> OrderBy(DBOrderByExpressionSet orderBy);
        IValueListContinuationBuilder<T, U> OrderBy(params DBOrderByExpression[] orderBy);
        IValueListContinuationBuilder<T, U> GroupBy(params DBGroupByExpression[] groupBy);
        IValueListContinuationBuilder<T, U> Having(DBHavingExpression havingCondition);
        IValueListSkipContinuationBuilder<T, U> Skip(int skipValue);
        IValueListContinuationBuilder<T, U> Top(int count);
    }
}