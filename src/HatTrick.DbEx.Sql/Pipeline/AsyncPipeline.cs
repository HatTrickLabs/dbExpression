﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Sql.Pipeline
{
    public class AsyncPipeline<TContext>
         where TContext : class, IPipelineExecutionContext
    {
        private IEnumerable<Func<TContext, CancellationToken, Task>> Actions { get; set; }

        public async Task InvokeAsync(Lazy<TContext> context, CancellationToken cancellationToken)
        {
            foreach (var action in Actions)
                await action.Invoke(context.Value, cancellationToken);
        }

        public AsyncPipeline(IEnumerable<Func<TContext, CancellationToken, Task>> actions)
        {
            Actions = actions;
        }
    }
}