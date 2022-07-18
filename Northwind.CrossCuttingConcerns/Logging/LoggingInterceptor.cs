using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Extensions.Interception;

namespace Northwind.CrossCuttingConcerns.Logging
{
    public class LoggingInterceptor:SimpleInterceptor
    {
        protected override void AfterInvoke(IInvocation invocation)
        {
            //loglama framework loglama işlemleri yapılacak
            //invocation.Request.Method.Name
            base.AfterInvoke(invocation);
        }

        protected override void BeforeInvoke(IInvocation invocation)
        {
            base.BeforeInvoke(invocation);
        }
    }
}
