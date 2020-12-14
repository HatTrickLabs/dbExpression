﻿using HatTrick.DbEx.Sql.Expression;
using System;
using System.Linq;

namespace HatTrick.DbEx.Sql.Builder
{
    public class SelectJoinExpressionBuilder<T>
        where T : IExpressionBuilder
    {
        #region internals
        private readonly SelectQueryExpression expression;
        private readonly IExpressionElement joinTo;
        private readonly JoinOperationExpressionOperator joinType;
        private string alias;
        #endregion

        #region constructors
        public SelectJoinExpressionBuilder(SelectQueryExpression expression, IExpressionElement joinTo, JoinOperationExpressionOperator joinType)
        {
            this.expression = expression ?? throw new ArgumentNullException($"{nameof(expression)} is required.");
            this.joinTo = joinTo ?? throw new ArgumentNullException($"{nameof(joinTo)} is required.");
            this.joinType = joinType;
        }
        #endregion

        #region methods
        protected void On(AnyJoinOnClause joinOn)
        {
            var join = new JoinExpression(joinTo, joinType, joinOn);

            if (!string.IsNullOrWhiteSpace(alias))
                join = join.As(alias);

            expression.Joins = expression.Joins is null ?
                new JoinExpressionSet(join)
                :
                new JoinExpressionSet(expression.Joins.Expressions.Concat(new JoinExpression[1] { join }));
        }

        protected void As(string alias)
            => this.alias = alias;
        #endregion
    }
}