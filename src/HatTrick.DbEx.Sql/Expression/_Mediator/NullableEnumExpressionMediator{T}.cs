using System;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class NullableEnumExpressionMediator<TEnum> :
        NullableExpressionMediator<TEnum>,
        IEquatable<NullableEnumExpressionMediator<TEnum>>
        where TEnum : struct, Enum, IComparable
    {
        #region constructors
        private NullableEnumExpressionMediator()
        {
        }

        public NullableEnumExpressionMediator(IExpression expression) : base(expression, typeof(TEnum?))
        {
        }

        protected NullableEnumExpressionMediator(IExpression expression, string alias) : base(expression, typeof(TEnum?), alias)
        {
        }
        #endregion

        #region as
        public new NullableEnumExpressionMediator<TEnum> As(string alias)
            => new NullableEnumExpressionMediator<TEnum>(this.Expression, alias);
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new NullableEnumExpressionMediator<TEnum>(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new NullableEnumExpressionMediator<TEnum>(this), OrderExpressionDirection.DESC);
        #endregion

        #region equals
        public bool Equals(NullableEnumExpressionMediator<TEnum> obj)
            => obj is NullableEnumExpressionMediator<TEnum> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is NullableEnumExpressionMediator<TEnum> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        public static implicit operator SelectExpression<TEnum>(NullableEnumExpressionMediator<TEnum> a) => new SelectExpression<TEnum>(new NullableEnumExpressionMediator<TEnum>(a));
        public static implicit operator OrderByExpression(NullableEnumExpressionMediator<TEnum> a) => new OrderByExpression(new NullableEnumExpressionMediator<TEnum>(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(NullableEnumExpressionMediator<TEnum> a) => new GroupByExpression(new NullableEnumExpressionMediator<TEnum>(a));
        #endregion
    }
}