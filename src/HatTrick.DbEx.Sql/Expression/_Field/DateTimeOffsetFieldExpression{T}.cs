using System;
using System.Linq.Expressions;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class DateTimeOffsetFieldExpression<TEntity> : 
        DateTimeOffsetFieldExpression,
        IEquatable<DateTimeOffsetFieldExpression<TEntity>>
        where TEntity : IDbEntity
    {
        #region constructors
        public DateTimeOffsetFieldExpression(object identifier, EntityExpression entity, Lazy<ISqlFieldMetadata> metadata) : base(identifier, entity, metadata)
        {

        }

        private DateTimeOffsetFieldExpression(object identifier, EntityExpression entity, Lazy<ISqlFieldMetadata> metadata, string alias) : base(identifier, entity, metadata, alias)
        {

        }
        #endregion
        
        #region as
        public new DateTimeOffsetFieldExpression<TEntity> As(string alias)
            => new DateTimeOffsetFieldExpression<TEntity>(base.Identifier, base.Entity, base.MetadataResolver, alias);
        #endregion

        #region equals
        public bool Equals(DateTimeOffsetFieldExpression<TEntity> obj)
            => obj is DateTimeOffsetFieldExpression<TEntity> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is DateTimeOffsetFieldExpression<TEntity> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
