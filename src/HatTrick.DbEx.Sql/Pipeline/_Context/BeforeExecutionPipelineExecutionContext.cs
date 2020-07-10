﻿using HatTrick.DbEx.Sql.Expression;
using System;
using System.Data.Common;

namespace HatTrick.DbEx.Sql.Pipeline
{
    public class BeforeExecutionPipelineExecutionContext : PipelineExecutionContext, IPipelineExecutionContext
    {
        public SqlStatement Statement { get; set; }
        public DbCommand DbCommand { get; private set; }

        public BeforeExecutionPipelineExecutionContext(ExpressionSet expression, SqlStatement statement, DbCommand command)
            : base(expression)
        {
            Statement = statement ?? throw new ArgumentNullException($"{nameof(statement)} is required.");
            DbCommand = command ?? throw new ArgumentNullException($"{nameof(command)} is required.");
        }
    }
}