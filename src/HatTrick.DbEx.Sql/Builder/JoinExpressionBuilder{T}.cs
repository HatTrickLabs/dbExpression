﻿using HatTrick.DbEx.Sql.Builder.Syntax;
using HatTrick.DbEx.Sql.Expression;

namespace HatTrick.DbEx.Sql.Builder
{
    public class JoinExpressionBuilder<T> : IJoinExpressionBuilder<T>
        where T : IExpressionBuilder
    {
        private ExpressionSet Expression { get; set; }
        private EntityExpression JoinOn { get; set; }
        private JoinOperationExpressionOperator JoinType { get; set; }
        private T Caller { get; set; }

        internal JoinExpressionBuilder(ExpressionSet expression, EntityExpression joinOn, JoinOperationExpressionOperator joinType, T caller)
        {
            Expression = expression;
            JoinOn = joinOn;
            JoinType = joinType;
            Caller = caller;
        }

        T IJoinExpressionBuilder<T>.On(JoinOnExpression expression)
        {
            if (Expression.Joins == null)
                Expression.Joins = new JoinExpressionSet(new JoinExpression(JoinOn, JoinType, expression));
            else
                Expression.Joins.Expressions.Add(new JoinExpression(JoinOn, JoinType, expression));
            return Caller;
        }
    }
}
