﻿using System;
using System.Transactions;

namespace ArquiteturaDDD.Infra.Data.Command.Base
{
    public abstract class BaseCommand
    {
        public BaseCommand() { }

        public void Execute()
        {
            Execute(new TransactionScope(TransactionScopeOption.Required, new TimeSpan(0)));
        }

        public void ExecuteNewTransaction()
        {
            Execute(new TransactionScope(TransactionScopeOption.RequiresNew, new TimeSpan(0)));
        }

        public void ExecuteNULLTransaction()
        {
            Execute(null);
        }

        protected void Execute(TransactionScope _scope)
        {
            if (_scope == null)
                Action();
            else
            {
                using (_scope)
                {
                    Action();
                    _scope.Complete();
                }
            }
        }

        protected void Action()
        {
            if (PreConditional())
            {
                Semantic();
                PosConditional();
            }
        }

        protected virtual bool PreConditional()
        {
            return true;
        }

        protected virtual void Semantic() { }

        protected virtual void PosConditional() => Dispose();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}