﻿using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public class EnumFieldExpression<TEntity, TEnum> : EnumFieldExpression<TEnum>,
        IEquatable<EnumFieldExpression<TEntity, TEnum>>
        where TEntity : class, IDbEntity
        where TEnum : struct, Enum, IComparable
    {
        #region constructors
        public EnumFieldExpression(string identifier, EntityExpression entity) : base(identifier, typeof(TEnum), entity)
        {
        }

        protected EnumFieldExpression(string identifier, EntityExpression entity, string alias) : base(identifier, typeof(TEnum), entity, alias)
        {

        }
        #endregion

        #region as
        public override EnumElement<TEnum> As(string alias)
            => new EnumFieldExpression<TEntity, TEnum>(base.identifier, base.entity, alias);
        #endregion

        #region in value set
        public override FilterExpressionSet In(params TEnum[] value) => value is object ? new FilterExpressionSet(new FilterExpression<bool>(new EnumExpressionMediator<TEnum>(this), new EnumExpressionMediator<TEnum>(new InExpression<TEnum>(value)), FilterExpressionOperator.None)) : null;
        public override FilterExpressionSet In(IEnumerable<TEnum> value) => value is object ? new FilterExpressionSet(new FilterExpression<bool>(new EnumExpressionMediator<TEnum>(this), new EnumExpressionMediator<TEnum>(new InExpression<TEnum>(value)), FilterExpressionOperator.None)) : null;
        #endregion

        #region set
        public override AssignmentExpression Set(TEnum value) => new AssignmentExpression(this, new EnumExpressionMediator<TEnum>(new LiteralExpression<TEnum>(value)));
        #endregion

        #region order
        public override OrderByExpression Asc => new OrderByExpression(new EnumExpressionMediator<TEnum>(this), OrderExpressionDirection.ASC);
        public override OrderByExpression Desc => new OrderByExpression(new EnumExpressionMediator<TEnum>(this), OrderExpressionDirection.DESC);
        #endregion

        #region equals
        public bool Equals(EnumFieldExpression<TEntity, TEnum> obj)
            => obj is EnumFieldExpression<TEntity, TEnum> && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is EnumFieldExpression<TEntity, TEnum> exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion

        #region implicit operators
        public static implicit operator EnumExpressionMediator<TEnum>(EnumFieldExpression<TEntity, TEnum> a) => new EnumExpressionMediator<TEnum>(a);
        public static implicit operator SelectExpression<TEnum>(EnumFieldExpression<TEntity, TEnum> a) => new SelectExpression<TEnum>(new EnumExpressionMediator<TEnum>(a));
        public static implicit operator OrderByExpression(EnumFieldExpression<TEntity, TEnum> a) => new OrderByExpression(new EnumExpressionMediator<TEnum>(a), OrderExpressionDirection.ASC);
        public static implicit operator GroupByExpression(EnumFieldExpression<TEntity, TEnum> a) => new GroupByExpression(new EnumExpressionMediator<TEnum>(a));
        #endregion

        #region filter operators
        #region TEnum
        public static FilterExpressionSet operator ==(EnumFieldExpression<TEntity, TEnum> a, TEnum b) => new FilterExpressionSet(new FilterExpression<TEnum>(new EnumExpressionMediator<TEnum>(a), new EnumExpressionMediator<TEnum>(new LiteralExpression<TEnum>(b)), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(EnumFieldExpression<TEntity, TEnum> a, TEnum b) => new FilterExpressionSet(new FilterExpression<TEnum>(new EnumExpressionMediator<TEnum>(a), new EnumExpressionMediator<TEnum>(new LiteralExpression<TEnum>(b)), FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(TEnum a, EnumFieldExpression<TEntity, TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum>(new EnumExpressionMediator<TEnum>(new LiteralExpression<TEnum>(a)), new EnumExpressionMediator<TEnum>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TEnum a, EnumFieldExpression<TEntity, TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum>(new EnumExpressionMediator<TEnum>(new LiteralExpression<TEnum>(a)), new EnumExpressionMediator<TEnum>(b), FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(EnumFieldExpression<TEntity, TEnum> a, TEnum? b) => new FilterExpressionSet(new FilterExpression<TEnum?>(new EnumExpressionMediator<TEnum>(a), new NullableEnumExpressionMediator<TEnum>(new LiteralExpression<TEnum?>(b)), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(EnumFieldExpression<TEntity, TEnum> a, TEnum? b) => new FilterExpressionSet(new FilterExpression<TEnum?>(new EnumExpressionMediator<TEnum>(a), new NullableEnumExpressionMediator<TEnum>(new LiteralExpression<TEnum?>(b)), FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(TEnum? a, EnumFieldExpression<TEntity, TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum?>(new NullableEnumExpressionMediator<TEnum>(new LiteralExpression<TEnum?>(a)), new EnumExpressionMediator<TEnum>(b), FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(TEnum? a, EnumFieldExpression<TEntity, TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum?>(new NullableEnumExpressionMediator<TEnum>(new LiteralExpression<TEnum?>(a)), new EnumExpressionMediator<TEnum>(b), FilterExpressionOperator.NotEqual));
        #endregion

        #region mediator
        public static FilterExpressionSet operator ==(EnumFieldExpression<TEntity, TEnum> a, EnumExpressionMediator<TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum>(new EnumExpressionMediator<TEnum>(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(EnumFieldExpression<TEntity, TEnum> a, EnumExpressionMediator<TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum>(new EnumExpressionMediator<TEnum>(a), b, FilterExpressionOperator.NotEqual));

        public static FilterExpressionSet operator ==(EnumFieldExpression<TEntity, TEnum> a, NullableEnumExpressionMediator<TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum?>(new EnumExpressionMediator<TEnum>(a), b, FilterExpressionOperator.Equal));
        public static FilterExpressionSet operator !=(EnumFieldExpression<TEntity, TEnum> a, NullableEnumExpressionMediator<TEnum> b) => new FilterExpressionSet(new FilterExpression<TEnum?>(new EnumExpressionMediator<TEnum>(a), b, FilterExpressionOperator.NotEqual));
        #endregion
        #endregion
    }
}
