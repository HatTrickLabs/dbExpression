﻿using HatTrick.DbEx.MsSql.Expression;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Builder;
using HatTrick.DbEx.Sql.Builder.Syntax;
using HatTrick.DbEx.Sql.Expression;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace HatTrick.DbEx.MsSql.Builder
{
    public partial class MsSqlExpressionBuilder : SqlExpressionBuilder
    {
        #region constructors
        public MsSqlExpressionBuilder(ExpressionSet expression) : base(expression)
        { }

        protected MsSqlExpressionBuilder()
        { }
        #endregion

        #region select one
        public static IFromExpressionBuilder<TEntity, ITypeContinuationExpressionBuilder<TEntity>, ITypeContinuationBuilder<TEntity, ITypeContinuationExpressionBuilder<TEntity>>> SelectOne<TEntity>()
            where TEntity : class, IDbEntity
        {
            return new MsSqlExpressionBuilder<TEntity, ITypeContinuationExpressionBuilder<TEntity>, ITypeContinuationBuilder<TEntity, ITypeContinuationExpressionBuilder<TEntity>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectOneType, Select = new SelectExpressionSet().Top(1) })
                as IFromExpressionBuilder<TEntity, ITypeContinuationExpressionBuilder<TEntity>, ITypeContinuationBuilder<TEntity, ITypeContinuationExpressionBuilder<TEntity>>>;
        }

        public static IFromExpressionBuilder<TEnum, IValueContinuationExpressionBuilder<TEnum>, IValueContinuationExpressionBuilder<TEnum, IValueContinuationExpressionBuilder<TEnum>>> SelectOne<TEnum>(ISupportedForSelectFieldExpression<TEnum> field)
            where TEnum : struct, Enum, IComparable
        {
            var builder = new MsSqlExpressionBuilder<TEnum, IValueContinuationExpressionBuilder<TEnum>, IValueContinuationExpressionBuilder<TEnum, IValueContinuationExpressionBuilder<TEnum>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectOneValue, Select = new SelectExpressionSet().Top(1) });
            builder.Expression.Select.Expressions.Add((field.GetType(), field));
            return builder as IFromExpressionBuilder<TEnum, IValueContinuationExpressionBuilder<TEnum>, IValueContinuationExpressionBuilder<TEnum, IValueContinuationExpressionBuilder<TEnum>>>;
        }
        
        public static IFromExpressionBuilder<byte, IValueContinuationExpressionBuilder<byte>, IValueContinuationExpressionBuilder<byte, IValueContinuationExpressionBuilder<byte>>> SelectOne(ISupportedForSelectFieldExpression<byte> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<byte?, IValueContinuationExpressionBuilder<byte?>, IValueContinuationExpressionBuilder<byte?, IValueContinuationExpressionBuilder<byte?>>> SelectOne(ISupportedForSelectFieldExpression<byte?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<short, IValueContinuationExpressionBuilder<short>, IValueContinuationExpressionBuilder<short, IValueContinuationExpressionBuilder<short>>> SelectOne(ISupportedForSelectFieldExpression<short> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<short?, IValueContinuationExpressionBuilder<short?>, IValueContinuationExpressionBuilder<short?, IValueContinuationExpressionBuilder<short?>>> SelectOne(ISupportedForSelectFieldExpression<short?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<int, IValueContinuationExpressionBuilder<int>, IValueContinuationExpressionBuilder<int, IValueContinuationExpressionBuilder<int>>> SelectOne(ISupportedForSelectFieldExpression<int> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<int?, IValueContinuationExpressionBuilder<int?>, IValueContinuationExpressionBuilder<int?, IValueContinuationExpressionBuilder<int?>>> SelectOne(ISupportedForSelectFieldExpression<int?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<long, IValueContinuationExpressionBuilder<long>, IValueContinuationExpressionBuilder<long, IValueContinuationExpressionBuilder<long>>> SelectOne(ISupportedForSelectFieldExpression<long> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<long?, IValueContinuationExpressionBuilder<long?>, IValueContinuationExpressionBuilder<long?, IValueContinuationExpressionBuilder<long?>>> SelectOne(ISupportedForSelectFieldExpression<long?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<decimal, IValueContinuationExpressionBuilder<decimal>, IValueContinuationExpressionBuilder<decimal, IValueContinuationExpressionBuilder<decimal>>> SelectOne(ISupportedForSelectFieldExpression<decimal> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<decimal?, IValueContinuationExpressionBuilder<decimal?>, IValueContinuationExpressionBuilder<decimal?, IValueContinuationExpressionBuilder<decimal?>>> SelectOne(ISupportedForSelectFieldExpression<decimal?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<double, IValueContinuationExpressionBuilder<double>, IValueContinuationExpressionBuilder<double, IValueContinuationExpressionBuilder<double>>> SelectOne(ISupportedForSelectFieldExpression<double> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<double?, IValueContinuationExpressionBuilder<double?>, IValueContinuationExpressionBuilder<double?, IValueContinuationExpressionBuilder<double?>>> SelectOne(ISupportedForSelectFieldExpression<double?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<float, IValueContinuationExpressionBuilder<float>, IValueContinuationExpressionBuilder<float, IValueContinuationExpressionBuilder<float>>> SelectOne(ISupportedForSelectFieldExpression<float> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<float?, IValueContinuationExpressionBuilder<float?>, IValueContinuationExpressionBuilder<float?, IValueContinuationExpressionBuilder<float?>>> SelectOne(ISupportedForSelectFieldExpression<float?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<bool, IValueContinuationExpressionBuilder<bool>, IValueContinuationExpressionBuilder<bool, IValueContinuationExpressionBuilder<bool>>> SelectOne(ISupportedForSelectFieldExpression<bool> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<bool?, IValueContinuationExpressionBuilder<bool?>, IValueContinuationExpressionBuilder<bool?, IValueContinuationExpressionBuilder<bool?>>> SelectOne(ISupportedForSelectFieldExpression<bool?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<string, IValueContinuationExpressionBuilder<string>, IValueContinuationExpressionBuilder<string, IValueContinuationExpressionBuilder<string>>> SelectOne(ISupportedForSelectFieldExpression<string> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<DateTime, IValueContinuationExpressionBuilder<DateTime>, IValueContinuationExpressionBuilder<DateTime, IValueContinuationExpressionBuilder<DateTime>>> SelectOne(ISupportedForSelectFieldExpression<DateTime> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<DateTime?, IValueContinuationExpressionBuilder<DateTime?>, IValueContinuationExpressionBuilder<DateTime?, IValueContinuationExpressionBuilder<DateTime?>>> SelectOne(ISupportedForSelectFieldExpression<DateTime?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<DateTimeOffset, IValueContinuationExpressionBuilder<DateTimeOffset>, IValueContinuationExpressionBuilder<DateTimeOffset, IValueContinuationExpressionBuilder<DateTimeOffset>>> SelectOne(ISupportedForSelectFieldExpression<DateTimeOffset> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<DateTimeOffset?, IValueContinuationExpressionBuilder<DateTimeOffset?>, IValueContinuationExpressionBuilder<DateTimeOffset?, IValueContinuationExpressionBuilder<DateTimeOffset?>>> SelectOne(ISupportedForSelectFieldExpression<DateTimeOffset?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<Guid, IValueContinuationExpressionBuilder<Guid>, IValueContinuationExpressionBuilder<Guid, IValueContinuationExpressionBuilder<Guid>>> SelectOne(ISupportedForSelectFieldExpression<Guid> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<Guid?, IValueContinuationExpressionBuilder<Guid?>, IValueContinuationExpressionBuilder<Guid?, IValueContinuationExpressionBuilder<Guid?>>> SelectOne(ISupportedForSelectFieldExpression<Guid?> field)
            => CreateSelectOne(field);

        public static IFromExpressionBuilder<ExpandoObject, IValueContinuationExpressionBuilder<ExpandoObject>, IValueContinuationExpressionBuilder<ExpandoObject, IValueContinuationExpressionBuilder<ExpandoObject>>> SelectOne(ISupportedForExpression<SelectExpression> field1, ISupportedForExpression<SelectExpression> field2, params ISupportedForExpression<SelectExpression>[] fields)
        {
            var builder = new MsSqlExpressionBuilder<ExpandoObject, IValueContinuationExpressionBuilder<ExpandoObject>, IValueContinuationExpressionBuilder<ExpandoObject, IValueContinuationExpressionBuilder<ExpandoObject>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectOneDynamic, Select = new SelectExpressionSet().Top(1) });
            builder.Expression.Select.Expressions.Add((field1.GetType(), field1));
            builder.Expression.Select.Expressions.Add((field2.GetType(), field2));
            foreach (var field in fields)
                builder.Expression.Select.Expressions.Add((field.GetType(), field));
            return builder as IFromExpressionBuilder<ExpandoObject, IValueContinuationExpressionBuilder<ExpandoObject>, IValueContinuationExpressionBuilder<ExpandoObject, IValueContinuationExpressionBuilder<ExpandoObject>>>;
        }

        private static IFromExpressionBuilder<TValue, IValueContinuationExpressionBuilder<TValue>, IValueContinuationExpressionBuilder<TValue, IValueContinuationExpressionBuilder<TValue>>> CreateSelectOne<TValue>(ISupportedForSelectFieldExpression<TValue> field)
        {
            var builder = new MsSqlExpressionBuilder<TValue, IValueContinuationExpressionBuilder<TValue>, IValueContinuationExpressionBuilder<TValue, IValueContinuationExpressionBuilder<TValue>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectOneValue, Select = new SelectExpressionSet().Top(1) });
            builder.Expression.Select.Expressions.Add((field.GetType(), field));
            return builder as IFromExpressionBuilder<TValue, IValueContinuationExpressionBuilder<TValue>, IValueContinuationExpressionBuilder<TValue, IValueContinuationExpressionBuilder<TValue>>>;
        }
        #endregion

        #region select many
        public static IListFromExpressionBuilder<TEntity, ITypeListContinuationExpressionBuilder<TEntity>, ITypeListContinuationExpressionBuilder<TEntity, ITypeListContinuationExpressionBuilder<TEntity>>> SelectMany<TEntity>()
            where TEntity : IDbEntity
        {
            return new MsSqlExpressionBuilder<TEntity, ITypeListContinuationExpressionBuilder<TEntity>, ITypeListContinuationExpressionBuilder<TEntity, ITypeListContinuationExpressionBuilder<TEntity>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectManyType })
                as IListFromExpressionBuilder<TEntity, ITypeListContinuationExpressionBuilder<TEntity>, ITypeListContinuationExpressionBuilder<TEntity, ITypeListContinuationExpressionBuilder<TEntity>>>;
        }

        public static IListFromExpressionBuilder<TEnum, IValueListContinuationExpressionBuilder<TEnum>, IValueListContinuationExpressionBuilder<TEnum, IValueListContinuationExpressionBuilder<TEnum>>> SelectMany<TEnum>(ISupportedForSelectFieldExpression<TEnum> field)
            where TEnum : struct, Enum, IComparable
        {
            var builder = new MsSqlExpressionBuilder<TEnum, IValueListContinuationExpressionBuilder<TEnum>, IValueListContinuationExpressionBuilder<TEnum, IValueListContinuationExpressionBuilder<TEnum>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectManyValue });
            builder.Expression.Select.Expressions.Add((field.GetType(), field));
            return builder as IListFromExpressionBuilder<TEnum, IValueListContinuationExpressionBuilder<TEnum>, IValueListContinuationExpressionBuilder<TEnum, IValueListContinuationExpressionBuilder<TEnum>>>;
        }

        public static IListFromExpressionBuilder<byte, IValueListContinuationExpressionBuilder<byte>, IValueListContinuationExpressionBuilder<byte, IValueListContinuationExpressionBuilder<byte>>> SelectMany(ISupportedForSelectFieldExpression<byte> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<byte?, IValueListContinuationExpressionBuilder<byte?>, IValueListContinuationExpressionBuilder<byte?, IValueListContinuationExpressionBuilder<byte?>>> SelectMany(ISupportedForSelectFieldExpression<byte?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<short, IValueListContinuationExpressionBuilder<short>, IValueListContinuationExpressionBuilder<short, IValueListContinuationExpressionBuilder<short>>> SelectMany(ISupportedForSelectFieldExpression<short> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<short?, IValueListContinuationExpressionBuilder<short?>, IValueListContinuationExpressionBuilder<short?, IValueListContinuationExpressionBuilder<short?>>> SelectMany(ISupportedForSelectFieldExpression<short?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<int, IValueListContinuationExpressionBuilder<int>, IValueListContinuationExpressionBuilder<int, IValueListContinuationExpressionBuilder<int>>> SelectMany(ISupportedForSelectFieldExpression<int> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<int?, IValueListContinuationExpressionBuilder<int?>, IValueListContinuationExpressionBuilder<int?, IValueListContinuationExpressionBuilder<int?>>> SelectMany(ISupportedForSelectFieldExpression<int?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<long, IValueListContinuationExpressionBuilder<long>, IValueListContinuationExpressionBuilder<long, IValueListContinuationExpressionBuilder<long>>> SelectMany(ISupportedForSelectFieldExpression<long> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<long?, IValueListContinuationExpressionBuilder<long?>, IValueListContinuationExpressionBuilder<long?, IValueListContinuationExpressionBuilder<long?>>> SelectMany(ISupportedForSelectFieldExpression<long?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<decimal, IValueListContinuationExpressionBuilder<decimal>, IValueListContinuationExpressionBuilder<decimal, IValueListContinuationExpressionBuilder<decimal>>> SelectMany(ISupportedForSelectFieldExpression<decimal> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<decimal?, IValueListContinuationExpressionBuilder<decimal?>, IValueListContinuationExpressionBuilder<decimal?, IValueListContinuationExpressionBuilder<decimal?>>> SelectMany(ISupportedForSelectFieldExpression<decimal?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<double, IValueListContinuationExpressionBuilder<double>, IValueListContinuationExpressionBuilder<double, IValueListContinuationExpressionBuilder<double>>> SelectMany(ISupportedForSelectFieldExpression<double> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<double?, IValueListContinuationExpressionBuilder<double?>, IValueListContinuationExpressionBuilder<double?, IValueListContinuationExpressionBuilder<double?>>> SelectMany(ISupportedForSelectFieldExpression<double?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<float, IValueListContinuationExpressionBuilder<float>, IValueListContinuationExpressionBuilder<float, IValueListContinuationExpressionBuilder<float>>> SelectMany(ISupportedForSelectFieldExpression<float> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<float?, IValueListContinuationExpressionBuilder<float?>, IValueListContinuationExpressionBuilder<float?, IValueListContinuationExpressionBuilder<float?>>> SelectMany(ISupportedForSelectFieldExpression<float?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<bool, IValueListContinuationExpressionBuilder<bool>, IValueListContinuationExpressionBuilder<bool, IValueListContinuationExpressionBuilder<bool>>> SelectMany(ISupportedForSelectFieldExpression<bool> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<bool?, IValueListContinuationExpressionBuilder<bool?>, IValueListContinuationExpressionBuilder<bool?, IValueListContinuationExpressionBuilder<bool?>>> SelectMany(ISupportedForSelectFieldExpression<bool?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<string, IValueListContinuationExpressionBuilder<string>, IValueListContinuationExpressionBuilder<string, IValueListContinuationExpressionBuilder<string>>> SelectMany(ISupportedForSelectFieldExpression<string> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<DateTime, IValueListContinuationExpressionBuilder<DateTime>, IValueListContinuationExpressionBuilder<DateTime, IValueListContinuationExpressionBuilder<DateTime>>> SelectMany(ISupportedForSelectFieldExpression<DateTime> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<DateTime?, IValueListContinuationExpressionBuilder<DateTime?>, IValueListContinuationExpressionBuilder<DateTime?, IValueListContinuationExpressionBuilder<DateTime?>>> SelectMany(ISupportedForSelectFieldExpression<DateTime?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<DateTimeOffset, IValueListContinuationExpressionBuilder<DateTimeOffset>, IValueListContinuationExpressionBuilder<DateTimeOffset, IValueListContinuationExpressionBuilder<DateTimeOffset>>> SelectMany(ISupportedForSelectFieldExpression<DateTimeOffset> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<DateTimeOffset?, IValueListContinuationExpressionBuilder<DateTimeOffset?>, IValueListContinuationExpressionBuilder<DateTimeOffset?, IValueListContinuationExpressionBuilder<DateTimeOffset?>>> SelectMany(ISupportedForSelectFieldExpression<DateTimeOffset?> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<Guid, IValueListContinuationExpressionBuilder<Guid>, IValueListContinuationExpressionBuilder<Guid, IValueListContinuationExpressionBuilder<Guid>>> SelectMany(ISupportedForSelectFieldExpression<Guid> field)
            => CreateSelectMany(field);

        public static IListFromExpressionBuilder<Guid?, IValueListContinuationExpressionBuilder<Guid?>, IValueListContinuationExpressionBuilder<Guid?, IValueListContinuationExpressionBuilder<Guid?>>> SelectMany(ISupportedForSelectFieldExpression<Guid?> field)
            => CreateSelectMany(field);


        public static IListFromExpressionBuilder<ExpandoObject, IValueListContinuationExpressionBuilder<ExpandoObject>, IValueListContinuationExpressionBuilder<ExpandoObject, IValueListContinuationExpressionBuilder<ExpandoObject>>> SelectMany(ISupportedForExpression<SelectExpression> field1, ISupportedForExpression<SelectExpression> field2, params ISupportedForExpression<SelectExpression>[] fields)
        {
            var builder = new MsSqlExpressionBuilder<ExpandoObject, IValueListContinuationExpressionBuilder<ExpandoObject>, IValueListContinuationExpressionBuilder<ExpandoObject, IValueListContinuationExpressionBuilder<ExpandoObject>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectManyDynamic });
            builder.Expression.Select.Expressions.Add((field1.GetType(), field1));
            builder.Expression.Select.Expressions.Add((field2.GetType(), field2));
            foreach (var field in fields)
                builder.Expression.Select.Expressions.Add((field.GetType(), field));
            return builder as IListFromExpressionBuilder<ExpandoObject, IValueListContinuationExpressionBuilder<ExpandoObject>, IValueListContinuationExpressionBuilder<ExpandoObject, IValueListContinuationExpressionBuilder<ExpandoObject>>>;
        }

        private static IListFromExpressionBuilder<TValue, IValueListContinuationExpressionBuilder<TValue>, IValueListContinuationExpressionBuilder<TValue, IValueListContinuationExpressionBuilder<TValue>>> CreateSelectMany<TValue>(ISupportedForSelectFieldExpression<TValue> field)
        {
            var builder = new MsSqlExpressionBuilder<TValue, IValueListContinuationExpressionBuilder<TValue>, IValueListContinuationExpressionBuilder<TValue, IValueListContinuationExpressionBuilder<TValue>>>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.SelectManyValue });
            builder.Expression.Select.Expressions.Add((field.GetType(), field));
            return builder as IListFromExpressionBuilder<TValue, IValueListContinuationExpressionBuilder<TValue>, IValueListContinuationExpressionBuilder<TValue, IValueListContinuationExpressionBuilder<TValue>>>;
        }
        #endregion

        public static IUpdateFromExpressionBuilder Update(params AssignmentExpression[] fields)
        {
            var builder = new MsSqlExpressionBuilder(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.Update });
            foreach (var field in fields)
                builder.Expression.Assign.Expressions.Add(field);
            return builder as IUpdateFromExpressionBuilder;
        }

        public static IDeleteFromExpressionBuilder Delete()
        {
            return new MsSqlExpressionBuilder(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.Delete })
                as IDeleteFromExpressionBuilder;
        }

        public static IInsertExpressionBuilder<T> Insert<T>(T instance)
            where T : class, IDbEntity
        {
            return new MsSqlInsertBuilder<T>(new ExpressionSet { StatementExecutionType = SqlStatementExecutionType.Insert, Instance = instance })
                as IInsertExpressionBuilder<T>;
        }

#pragma warning disable CA1034 // Nested types should not be visible
        public class fx : MsSqlFunctionExpressionBuilder
#pragma warning restore CA1034 // Nested types should not be visible
        {

        }
    }
}
