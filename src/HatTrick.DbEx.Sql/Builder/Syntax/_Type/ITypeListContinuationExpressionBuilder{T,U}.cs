﻿using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.Sql.Builder.Syntax
{
    public interface ITypeListContinuationExpressionBuilder<T,U> : ITypeListContinuationExpressionBuilder<T>, IContinuationExpressionBuilder<T,U>
        where U : class, IContinuationExpressionBuilder<T>
    {
        ITypeListContinuationExpressionBuilder<T, U> Where(FilterExpression expression);
        ITypeListContinuationExpressionBuilder<T, U> Where(FilterExpressionSet expression);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> InnerJoin(EntityExpression entity);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> LeftJoin(EntityExpression entity);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> RightJoin(EntityExpression entity);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> FullJoin(EntityExpression entity);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> CrossJoin(EntityExpression entity);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> InnerJoin(ISubqueryTerminationExpressionBuilder subquery);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> LeftJoin(ISubqueryTerminationExpressionBuilder subquery);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> RightJoin(ISubqueryTerminationExpressionBuilder subquery);
        IJoinExpressionBuilder<T, ITypeListContinuationExpressionBuilder<T, U>> FullJoin(ISubqueryTerminationExpressionBuilder subquery);
        ITypeListContinuationExpressionBuilder<T, U> OrderBy(OrderByExpressionSet orderBy);
        ITypeListContinuationExpressionBuilder<T, U> OrderBy(params OrderByExpression[] orderBy);
        ITypeListContinuationExpressionBuilder<T, U> GroupBy(params GroupByExpression[] groupBy);
        ITypeListContinuationExpressionBuilder<T, U> Having(HavingExpression havingCondition);
        ITypeListSkipContinuationExpressionBuilder<T, U> Skip(int skipValue);
        ITypeListContinuationExpressionBuilder<T, U> Top(int count);
    }
}
