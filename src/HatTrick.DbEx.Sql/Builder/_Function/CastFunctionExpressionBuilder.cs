﻿using HatTrick.DbEx.Sql.Builder.Syntax;
using HatTrick.DbEx.Sql.Expression;
using System;
using System.Data;

namespace HatTrick.DbEx.Sql.Builder
{
    public class CastFunctionExpressionBuilder : ICastFunctionExpressionBuilder
    {
        #region internals
        public ExpressionContainer Expression { get; private set; }
        #endregion

        #region constructors
        public CastFunctionExpressionBuilder(ExpressionContainer expression)
        {
            Expression = expression;
        }
        #endregion

        #region methods
        BooleanCastFunctionExpression ICastFunctionExpressionBuilder.AsBit()
            => new BooleanCastFunctionExpression(Expression, new ExpressionContainer(DbType.Boolean));

        ByteCastFunctionExpression ICastFunctionExpressionBuilder.AsTinyInt()
            => new ByteCastFunctionExpression(Expression, new ExpressionContainer(DbType.Byte));

        DateTimeCastFunctionExpression ICastFunctionExpressionBuilder.AsDateTime()
            => new DateTimeCastFunctionExpression(Expression, new ExpressionContainer(DbType.DateTime));

        DateTimeOffsetCastFunctionExpression ICastFunctionExpressionBuilder.AsDateTimeOffset()
            => new DateTimeOffsetCastFunctionExpression(Expression, new ExpressionContainer(DbType.DateTimeOffset));

        DecimalCastFunctionExpression ICastFunctionExpressionBuilder.AsDecimal(int precision, int scale)
            => new DecimalCastFunctionExpression(Expression, new ExpressionContainer(DbType.Decimal));

        SingleCastFunctionExpression ICastFunctionExpressionBuilder.AsFloat()
            => new SingleCastFunctionExpression(Expression, new ExpressionContainer(DbType.Single));

        GuidCastFunctionExpression ICastFunctionExpressionBuilder.AsUniqueIdentifier()
            => new GuidCastFunctionExpression(Expression, new ExpressionContainer(DbType.Guid));

        Int16CastFunctionExpression ICastFunctionExpressionBuilder.AsSmallInt()
            => new Int16CastFunctionExpression(Expression, new ExpressionContainer(DbType.Int16));

        Int32CastFunctionExpression ICastFunctionExpressionBuilder.AsInt()
            => new Int32CastFunctionExpression(Expression, new ExpressionContainer(DbType.Int32));

        Int64CastFunctionExpression ICastFunctionExpressionBuilder.AsBigInt()
            => new Int64CastFunctionExpression(Expression, new ExpressionContainer(DbType.Int64));

        StringCastFunctionExpression ICastFunctionExpressionBuilder.AsVarChar(int size)
        {
            var exp = new StringCastFunctionExpression(Expression, new ExpressionContainer(DbType.String))
            {
                Size = size
            };
            return exp;
        }

        StringCastFunctionExpression ICastFunctionExpressionBuilder.AsChar(int size)
        {
            var exp = new StringCastFunctionExpression(Expression, new ExpressionContainer(DbType.String))
            {
                Size = size
            };
            return exp;
        }

        StringCastFunctionExpression ICastFunctionExpressionBuilder.AsNVarChar(int size)
        {
            var exp = new StringCastFunctionExpression(Expression, new ExpressionContainer(DbType.AnsiString))
            {
                Size = size
            };
            return exp;
        }

        StringCastFunctionExpression ICastFunctionExpressionBuilder.AsNChar(int size)
        {
            var exp = new StringCastFunctionExpression(Expression, new ExpressionContainer(DbType.AnsiString))
            {
                Size = size
            };
            return exp;
        }
        #endregion
    }
}
