using System;
using System.Linq.Expressions;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class Int32FieldExpression<TEntity> : 
        Int32FieldExpression,
        IEquatable<Int32FieldExpression<TEntity>>
        where TEntity : IDbEntity
    {
        #region constructors
        public Int32FieldExpression(object identifier, EntityExpression entity, Lazy<ISqlFieldMetadata> metadata) : base(identifier, entity, metadata)
        {

        }

        private Int32FieldExpression(object identifier, EntityExpression entity, Lazy<ISqlFieldMetadata> metadata, string alias) : base(identifier, entity, metadata, alias)
        {

        }
        #endregion
        
        #region as
        public new Int32FieldExpression<TEntity> As(string alias)
            => new Int32FieldExpression<TEntity>(base.Identifier, base.Entity, base.MetadataResolver, alias);
        #endregion

        #region equals
        public bool Equals(Int32FieldExpression<TEntity> obj)
            => obj is Int32FieldExpression<TEntity> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is Int32FieldExpression<TEntity> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
