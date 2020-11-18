using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract partial class NullableInt16FieldExpression : 
        NullableFieldExpression<short,short?>,
        NullInt16Element,
        AnyInt16Element,
        IEquatable<NullableInt16FieldExpression>
    {
        #region constructors
        protected NullableInt16FieldExpression(string identifier, EntityExpression entity) : base(identifier, entity)
        {

        }

        protected NullableInt16FieldExpression(string identifier, EntityExpression entity, string alias) : base(identifier, entity, alias)
        {

        }
        #endregion

        #region as
        public abstract NullInt16Element As(string alias);
        #endregion

        #region equals
        public bool Equals(NullableInt16FieldExpression obj)
            => obj is NullableInt16FieldExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableInt16FieldExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
