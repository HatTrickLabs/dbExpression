using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableBooleanFieldExpression<TEntity> : 
        NullableBooleanFieldExpression,
        IEquatable<NullableBooleanFieldExpression<TEntity>>
        where TEntity : IDbEntity
    {
        #region constructors
        public NullableBooleanFieldExpression(string identifier, EntityExpression entity) : base(identifier, entity)
        {

        }

        private NullableBooleanFieldExpression(string identifier, EntityExpression entity, string alias) : base(identifier, entity, alias)
        {

        }
        #endregion
        
        #region as
        public NullableBooleanFieldExpression<TEntity> As(string alias)
            => new NullableBooleanFieldExpression<TEntity>(base.identifier, base.entity, alias);
        #endregion

        #region equals
        public bool Equals(NullableBooleanFieldExpression<TEntity> obj)
            => obj is NullableBooleanFieldExpression<TEntity> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableBooleanFieldExpression<TEntity> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}