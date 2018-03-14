using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace SpyStore.DAL.EF
{
    public class MyConnectionStrategy
    {
    }

    public class MyExecutionStrategy : ExecutionStrategy
    {
        public MyExecutionStrategy(ExecutionStrategyContext context) :
            base(context, ExecutionStrategy.DefaultMaxRetryCount,
                 ExecutionStrategy.DefaultMaxDelay)
        {
        }

        public MyExecutionStrategy(
            ExecutionStrategyContext context,
            int maxRetryCount,
            TimeSpan maxRetryDelay) : base(ContextBoundObject, maxRetryCount, maxRetryDelay)
        {
        }
        
        protected override bool ShouldRetryOn(Exception exception)
        {
            return true;
        }
    }
}
