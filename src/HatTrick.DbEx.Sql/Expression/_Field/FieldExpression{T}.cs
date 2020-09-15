﻿using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract class FieldExpression<TValue> : FieldExpression
    {
        #region constructors
        protected FieldExpression(string identifier, Type declaredType, EntityExpression entity) : base(identifier, declaredType, entity)
        {

        }

        protected FieldExpression(string identifier, Type declaredType, EntityExpression entity, string alias) : base(identifier, declaredType, entity, alias)
        {
        }
        #endregion

        #region order
        public override abstract OrderByExpression Asc { get; }
        public override abstract OrderByExpression Desc { get; }
        #endregion

        #region in value set
        public abstract FilterExpression In(params TValue[] value);
        #endregion

        #region set
        public abstract AssignmentExpression Set(TValue value);
        public abstract AssignmentExpression Set(ExpressionMediator<TValue> value);
        #endregion

        #region insert value
        public abstract InsertExpression Insert(TValue value);
        #endregion
    }
}
