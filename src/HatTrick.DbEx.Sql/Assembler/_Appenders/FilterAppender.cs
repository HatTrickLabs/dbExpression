﻿using HatTrick.DbEx.Sql.Expression;
using HatTrick.DbEx.Sql.Extensions.Attribute;
using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Assembler
{
    public class FilterAppender :
        IAssemblyPartAppender<FilterExpressionSet>,
        IAssemblyPartAppender<FilterExpression>
    {
        #region internals
        private static IDictionary<FilterExpressionOperator, string> _filterOperatorMap;
        private static IDictionary<ConditionalExpressionOperator, string> _conditionalOperatorMap;
        private static IDictionary<FilterExpressionOperator, string> FilterOperatorMap => _filterOperatorMap ?? (_filterOperatorMap = typeof(FilterExpressionOperator).GetValuesAndFilterOperators());
        private static IDictionary<ConditionalExpressionOperator, string> ConditionalOperatorMap => _conditionalOperatorMap ?? (_conditionalOperatorMap = typeof(ConditionalExpressionOperator).GetValuesAndConditionalOperators());
        #endregion

        #region methods
        public void AppendPart(object expression, ISqlStatementBuilder builder, AssemblerContext context)
        {
            if (expression is FilterExpressionSet set)
            {
                AppendPart(set, builder, context);
                return;
            }
            AppendPart(expression as FilterExpression, builder, context);
        }

        public void AppendPart(FilterExpressionSet expression, ISqlStatementBuilder builder, AssemblerContext context)
        {
            builder.Appender.Indent().Write("(");
            if (expression.Negate)
            {
                builder.Appender.Write("NOT (");
            }
            if (expression.Expression.LeftPart != default)
            {
                builder.AppendPart(expression.Expression.LeftPart, context);
            }
            if (expression.Expression.RightPart != default)
            {
                builder.Appender.Write(ConditionalOperatorMap[expression.ConditionalOperator]);
                builder.AppendPart(expression.Expression.RightPart, context);
            }
            if (expression.Negate)
            {
                builder.Appender.Write(")");
            }
            builder.Appender.Write(")");
        }

        public void AppendPart(FilterExpression expression, ISqlStatementBuilder builder, AssemblerContext context)
        {           
            if (expression.Expression.RightPart.Item2 == DBNull.Value)
            {
                builder.AppendPart(expression.Expression.LeftPart, context);
                switch (expression.ExpressionOperator)
                {
                    case FilterExpressionOperator.Equal:
                        builder.Appender.Write(expression.Negate ? " IS NOT NULL" : " IS NULL");
                        break;
                    case FilterExpressionOperator.NotEqual:
                        builder.Appender.Write(expression.Negate ? " IS NULL" : " IS NOT NULL");
                        break;
                    default:
                        throw new ArgumentException($"Operator {expression.ExpressionOperator} invalid with null arguments");
                }
                return;
            }

            if (expression.Negate)
            {
                builder.Appender.Write("NOT (");
            }
            builder.AppendPart(expression.Expression.LeftPart, context);
            builder.Appender.Write(FilterOperatorMap[expression.ExpressionOperator]);
            if (expression.ExpressionOperator == FilterExpressionOperator.In && expression.Expression.RightPart.Item2 is Array arr)
            {
                builder.Appender.Write("(");
                for (var i = 0; i < arr.Length; i++)
                {
                    var value = arr.GetValue(i);
                    builder.AppendPart((value.GetType(), value), context);
                    if (i != arr.Length - 1)
                        builder.Appender.Write(", ");
                }
                builder.Appender.Write(")");
            }
            else
            {
                builder.AppendPart(expression.Expression.RightPart, context);
            }
            if (expression.Negate)
            {
                builder.Appender.Write(")");
            }
        }
        #endregion
    }
}