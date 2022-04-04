using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace source.Models
{
    public class DefaultExceptionHandler : IExceptionHandler
    {
        public DefaultExceptionHandler() { }
        public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}