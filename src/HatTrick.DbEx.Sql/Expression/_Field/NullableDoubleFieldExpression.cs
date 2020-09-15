using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public abstract partial class NullableDoubleFieldExpression : 
        NullableFieldExpression<double>,
        IEquatable<NullableDoubleFieldExpression>
    {
        #region constructors
        protected NullableDoubleFieldExpression(string identifier, EntityExpression entity) : base(identifier, typeof(double), entity)
        {

        }

        protected NullableDoubleFieldExpression(string identifier, EntityExpression entity, string alias) : base(identifier, typeof(double), entity, alias)
        {

        }
        #endregion

        #region equals
        public bool Equals(NullableDoubleFieldExpression obj)
            => obj is NullableDoubleFieldExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableDoubleFieldExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
