﻿using HTL.DbEx.Sql.Expression;

namespace HTL.DbEx.Sql.Builder.Syntax
{
    public interface IDeleteContinuationBuilder : IContinuationBuilder, ITerminationBuilder
    {
        IDeleteContinuationBuilder Where(DBWhereExpression filter);
        IDeleteContinuationBuilder Where(DBWhereExpressionSet filter);
        IJoinBuilder<IDeleteContinuationBuilder> InnerJoin(DBExpressionEntity joinOn);
        IJoinBuilder<IDeleteContinuationBuilder> LeftJoin(DBExpressionEntity joinOn);
        IJoinBuilder<IDeleteContinuationBuilder> RightJoin(DBExpressionEntity joinOn);
        IJoinBuilder<IDeleteContinuationBuilder> FullJoin(DBExpressionEntity entity);
        IJoinBuilder<IDeleteContinuationBuilder> CrossJoin(DBExpressionEntity entity);
    }
}
