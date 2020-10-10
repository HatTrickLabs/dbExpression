﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public class AssignmentExpression : 
        IExpression,
        IAssignmentExpressionProvider
    {
        #region internals
        private FieldExpression assignee;
        private ExpressionMediator assignment;
        #endregion

        #region interface
        FieldExpression IAssignmentExpressionProvider.Assignee => assignee;
        ExpressionMediator IAssignmentExpressionProvider.Assignment => assignment;
        #endregion

        #region constructors
        public AssignmentExpression(FieldExpression assignee, ExpressionMediator assignment)
        {
            this.assignee = assignee ?? throw new ArgumentNullException($"{nameof(assignee)} is required.");
            this.assignment = assignment ?? throw new ArgumentNullException($"{nameof(assignment)} is required.");
        }
        #endregion

        #region to string
        public override string ToString() => $"{assignee} = {assignment}";
        #endregion

        #region implicit assignment expression set operator
        public static implicit operator AssignmentExpressionSet(AssignmentExpression a) => new AssignmentExpressionSet(a);
        #endregion
    }
    
}