﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HatTrick.DbEx.Sql.Expression
{
    public class JoinOnExpressionSet : 
        IDbExpression, 
        IDbExpressionSet<JoinOnExpression>
    {
        #region internals
        private readonly IList<object> expressions;
        #endregion

        #region interface
        public IList<JoinOnExpression> Expressions { get; }
        public ExpressionContainerPair JoinPair => new ExpressionContainerPair(expressions.First() is ExpressionContainer first ? first : new ExpressionContainer(expressions.First()), expressions.Skip(1).First() is ExpressionContainer second ? second : new ExpressionContainer(expressions.Skip(1).First()));
        public readonly ConditionalExpressionOperator ConditionalOperator;
        public bool Negate { get; set; }
        #endregion

        #region constructors
        public JoinOnExpressionSet()
        { 
        
        }

        public JoinOnExpressionSet(JoinOnExpression singleJoinOn)
        {
            expressions = new List<object>
            {
                singleJoinOn ?? throw new ArgumentNullException($"{nameof(singleJoinOn)} is required."),
            };
        }

        public JoinOnExpressionSet(JoinOnExpression leftArg, JoinOnExpression rightArg, ConditionalExpressionOperator conditinalOperator)
        {
            expressions = new List<object>
            {
                leftArg ?? throw new ArgumentNullException($"{nameof(leftArg)} is required."),
                rightArg ?? throw new ArgumentNullException($"{nameof(rightArg)} is required.")
            };
            ConditionalOperator = conditinalOperator;
        }

        private JoinOnExpressionSet(JoinOnExpressionSet leftArg, JoinOnExpression rightArg, ConditionalExpressionOperator conditinalOperator)
        {
            expressions = new List<object>
            {
                leftArg ?? throw new ArgumentNullException($"{nameof(leftArg)} is required."),
                rightArg ?? throw new ArgumentNullException($"{nameof(rightArg)} is required.")
            };
            ConditionalOperator = conditinalOperator;
        }

        private JoinOnExpressionSet(JoinOnExpressionSet leftArg, JoinOnExpressionSet rightArg, ConditionalExpressionOperator conditinalOperator)
        {
            expressions = new List<object>
            {
                leftArg ?? throw new ArgumentNullException($"{nameof(leftArg)} is required."),
                rightArg ?? throw new ArgumentNullException($"{nameof(rightArg)} is required.")
            };
            ConditionalOperator = conditinalOperator;
        }
        #endregion

        #region to string
        public override string ToString()
        {
            string left = JoinPair.LeftPart.Object.ToString();
            string right = JoinPair?.RightPart?.Object.ToString();
            string expression = $"{left} {ConditionalOperator} {right}";
            return (Negate) ? $"NOT ({expression})" : expression;
        }
        #endregion

        #region conditional &, | operators
        public static JoinOnExpressionSet operator &(JoinOnExpressionSet a, JoinOnExpression b)
        {
            if (a == null && b != null) { return new JoinOnExpressionSet(b); }
            if (a != null && b == null) { return a; }
            if (a == null && b == null) { return null; }

            return new JoinOnExpressionSet(a, b, ConditionalExpressionOperator.And);
        }

        public static JoinOnExpressionSet operator &(JoinOnExpressionSet a, JoinOnExpressionSet b)
        {
            if (a == null && b != null) { return b; }
            if (a != null && b == null) { return a; }
            if (a == null && b == null) { return null; }

            return new JoinOnExpressionSet(a, b, ConditionalExpressionOperator.And);
        }

        public static JoinOnExpressionSet operator |(JoinOnExpressionSet a, JoinOnExpression b)
        {
            if (a == null && b != null) { return new JoinOnExpressionSet(b); }
            if (a != null && b == null) { return a; }
            if (a == null && b == null) { return null; }

            return new JoinOnExpressionSet(a, b, ConditionalExpressionOperator.Or);
        }

        public static JoinOnExpressionSet operator |(JoinOnExpressionSet a, JoinOnExpressionSet b)
        {
            if (a == null && b != null) { return b; }
            if (a != null && b == null) { return a; }
            if (a == null && b == null) { return null; }

            return new JoinOnExpressionSet(a, b, ConditionalExpressionOperator.Or);
        }
        #endregion

        #region negation operator
        public static JoinOnExpressionSet operator !(JoinOnExpressionSet filter)
        {
            if (filter != null) filter.Negate = !filter.Negate;
            return filter;
        }
        #endregion
    }
    
}
