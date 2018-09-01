﻿using HTL.DbEx.Sql.Builder.Syntax;
using HTL.DbEx.Sql.Expression;

namespace HTL.DbEx.Sql.Builder
{
    public class JoinBuilder<T, U> : JoinBuilder<U>, IJoinBuilder<T, U>
        where U : IBuilder<T>
    {

        internal JoinBuilder(DBExpressionSet expression, DBExpressionEntity joinOn, DBExpressionJoinType joinType, U caller)
            : base(expression, joinOn, joinType, caller)
        {
        }

    }
}