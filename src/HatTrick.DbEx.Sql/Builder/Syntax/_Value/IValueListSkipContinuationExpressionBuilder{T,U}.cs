﻿namespace HatTrick.DbEx.Sql.Builder.Syntax
{
    public interface IValueListSkipContinuationExpressionBuilder<T, U> :
        IExpressionBuilder<T>,
        IValueListContinuationExpressionBuilder<T>, 
        IValueContinuationExpressionBuilder<T, U>
        where U : class, IContinuationExpressionBuilder<T>
    {
        IValueListContinuationExpressionBuilder<T, U> Limit(int limitValue);
    }
}