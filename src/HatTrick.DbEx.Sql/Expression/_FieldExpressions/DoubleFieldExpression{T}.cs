﻿using System;
using System.Linq.Expressions;

namespace HatTrick.DbEx.Sql.Expression
{
    [Serializable]
    public class DoubleFieldExpression<TEntity> : FieldExpression<TEntity, double>,
        ISupportedForSelectExpression<TEntity, double>,
        ISupportedForExpression<AssignmentExpression, TEntity, double>,
        ISupportedForFunctionExpression<IsNullFunctionExpression, double>,
        ISupportedForFunctionExpression<CoalesceFunctionExpression, double>,
        ISupportedForFunctionExpression<CountFunctionExpression, double>,
        ISupportedForFunctionExpression<MinimumFunctionExpression, double>,
        ISupportedForFunctionExpression<MaximumFunctionExpression, double>,
        ISupportedForFunctionExpression<AverageFunctionExpression, double>,
        ISupportedForFunctionExpression<SumFunctionExpression, double>,
        ISupportedForFunctionExpression<StandardDeviationFunctionExpression, double>,
        ISupportedForFunctionExpression<PopulationStandardDeviationFunctionExpression, double>,
        ISupportedForFunctionExpression<VarianceFunctionExpression, double>,
        ISupportedForFunctionExpression<PopulationVarianceFunctionExpression, double>
        where TEntity : IDbEntity
    {
        public DoubleFieldExpression(EntityExpression entity, ISqlFieldMetadata metadata, Expression<Func<TEntity, double>> mapExpression) : base(entity, metadata, mapExpression)
        {
        }

        protected DoubleFieldExpression(EntityExpression entity, ISqlFieldMetadata metadata, Lazy<Action<TEntity, double>> mapExpression, string alias) : base(entity, metadata, mapExpression, alias)
        {

        }

        #region as
        public virtual DoubleFieldExpression<TEntity> As(string alias) => new DoubleFieldExpression<TEntity>(base.Entity, base.Metadata, Mapper, alias);
        #endregion
    }
}
