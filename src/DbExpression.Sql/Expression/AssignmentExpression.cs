#region license
// Copyright (c) dbExpression.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/dbexpression-team/dbexpression
#endregion

﻿using System;

namespace DbExpression.Sql.Expression
{
    public class AssignmentExpression :
        EntityFieldAssignment,
        IAssignmentExpressionProvider,
        IEquatable<AssignmentExpression>
    {
        #region internals
        private readonly FieldExpression assignee;
        private IExpressionElement assignment;
        #endregion

        #region interface
        FieldExpression IAssignmentExpressionProvider.Assignee => assignee;
        IExpressionElement IAssignmentExpressionProvider.Assignment { get => assignment; set => assignment = value; }
        #endregion

        #region constructors
        public AssignmentExpression(FieldExpression assignee, IExpressionElement assignment)
        {
            this.assignee = assignee ?? throw new ArgumentNullException(nameof(assignee));
            this.assignment = assignment ?? throw new ArgumentNullException(nameof(assignment));
        }
        #endregion

        #region to string
        public override string? ToString() => $"{assignee} = {assignment}";
        #endregion

        #region equals
        public bool Equals(AssignmentExpression? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            if (!assignee.Equals(obj.assignee)) return false;

            if (!assignment.Equals(obj.assignment)) return false;

            return true;
        }

        public override bool Equals(object? obj)
            => obj is AssignmentExpression exp && Equals(exp);

        public override int GetHashCode()
        {
            unchecked
            {
                const int @base = (int)2166136261;
                const int multiplier = 16777619;

                int hash = @base;
                hash = (hash * multiplier) ^ (assignee is not null ? assignee.GetHashCode() : 0);
                hash = (hash * multiplier) ^ (assignment is not null ? assignment.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion

        #region implicit assignment expression set operator
        public static implicit operator AssignmentExpressionSet(AssignmentExpression a) => new(a);
        #endregion
    }    
}
