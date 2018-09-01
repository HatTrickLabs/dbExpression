﻿using HTL.DbEx.Sql.Expression;
using HTL.DbEx.Sql.Extensions.Attribute;
using System;
using System.Collections.Generic;

namespace HTL.DbEx.Sql.Assembler
{
    public class JoinOnClauseAssembler :
        ISqlPartAssembler<DBJoinOnExpressionSet>
    {
        private static IDictionary<DBFilterExpressionOperator, string> _filterOperatorMap;
        private static IDictionary<DBConditionalExpressionOperator, string> _conditionalOperatorMap;
        private static IDictionary<DBFilterExpressionOperator, string> FilterOperatorMap => _filterOperatorMap ?? (_filterOperatorMap = typeof(DBFilterExpressionOperator).GetValuesAndFilterOperators());
        private static IDictionary<DBConditionalExpressionOperator, string> ConditionalOperatorMap => _conditionalOperatorMap ?? (_conditionalOperatorMap = typeof(DBConditionalExpressionOperator).GetValuesAndConditionalOperators());
        private static Func<bool, string, string> negate = (bool negate, string s) => negate ? $" NOT ({s})" : s;

        public string Assemble(object expressionPart, ISqlStatementBuilder builder, AssemblerOverrides overrides)
        {
            return expressionPart is DBJoinOnExpressionSet ?
                Assemble((DBJoinOnExpressionSet)expressionPart, builder, overrides)
                :
                Assemble((DBJoinOnExpression)expressionPart, builder, overrides);
        }

        public string Assemble(DBJoinOnExpressionSet expressionPart, ISqlStatementBuilder builder, AssemblerOverrides overrides)
        {
            if (ReferenceEquals(expressionPart, null))
            {
                return null;
            }

            string left = string.Empty;
            if (!expressionPart.LeftPart.Equals(default))
            {
                left = builder.AssemblePart(expressionPart.LeftPart, overrides);
            }
            string right = string.Empty;
            if (!expressionPart.RightPart.Equals(default))
            {
                right = builder.AssemblePart(expressionPart.RightPart, overrides);
            }

            return negate
                (expressionPart.Negate, 
                !string.IsNullOrWhiteSpace(left) 
                    ? $"({left}{ConditionalOperatorMap[expressionPart.ConditionalOperator]}{right})"
                    : right
            );
        }

        public string Assemble(DBJoinOnExpression expressionPart, ISqlStatementBuilder builder, AssemblerOverrides overrides)
        {
            if (expressionPart is null)
            {
                return null;
            }

            string left = builder.AssemblePart(expressionPart.LeftPart, overrides);
            if (!expressionPart.RightPart.Equals(default))
            {
                if (expressionPart.ExpressionOperator == DBFilterExpressionOperator.In)
                {
                    throw new InvalidOperationException("Join on clause does not support in");
                }

                string right = typeof(IComparable).IsAssignableFrom(expressionPart.RightPart.Item1) ? 
                    builder.Parameters.Add(builder.FormatValueType(expressionPart.RightPart), expressionPart.RightPart.Item1).ParameterName
                    :
                    builder.AssemblePart(expressionPart.RightPart, overrides);

                if (!string.IsNullOrWhiteSpace(right))
                    return negate(expressionPart.Negate, $"{left}{FilterOperatorMap[expressionPart.ExpressionOperator]}{right}");

            }
            switch (expressionPart.ExpressionOperator)
            {
                case DBFilterExpressionOperator.Equal: return $"{left} IS NULL";
                case DBFilterExpressionOperator.NotEqual: return $"{left} IS NOT NULL";
                default:
                    throw new ArgumentException($"Operator {expressionPart.ExpressionOperator} invalid with null arguments");
            }
        }
    }
}
