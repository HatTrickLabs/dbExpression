﻿using HatTrick.DbEx.Sql.Expression;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace HatTrick.DbEx.Sql.Assembler
{
    public class InsertSqlStatementAssembler : SqlStatementAssembler
    {
        #region methods
        public override void AssembleStatement(ExpressionSet expression, ISqlStatementBuilder builder, AssemblerContext context)
        {
            builder.Appender.Write("INSERT INTO ");
            builder.AppendPart<EntityExpression>(expression.BaseEntity, context);
            builder.Appender.Write(" (");
            builder.Appender.Indentation++;

            for (var i = 0; i < expression.Insert.Expressions.Count; i++)
            {
                builder.Appender.Indent();
                builder.AppendPart(expression.Insert.Expressions[i].Expression.LeftPart, context);
                if (i < expression.Insert.Expressions.Count - 1)
                    builder.Appender.Write(", ").LineBreak();
            }

            builder.Appender.LineBreak()
                .Indentation--.Write(") VALUES (").LineBreak()
                .Indentation++;

            for (var i = 0; i < expression.Insert.Expressions.Count; i++)
            {
                builder.Appender.Indent();
                builder.Appender.Write(builder.Parameters.Add(expression.Insert.Expressions[i].Expression.RightPart).ParameterName);
                if (i < expression.Insert.Expressions.Count - 1)
                    builder.Appender.Write(", ").LineBreak();
            }

            builder.Appender.Write(")");
        }
        #endregion
    }
}