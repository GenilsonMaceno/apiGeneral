using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dispatcher;

namespace source.Models
{
    public class HttpControllerTypeResolver : IHttpControllerTypeResolver
    {
        public HttpControllerTypeResolver() { }

        public ICollection<Type> GetControllerTypes(IAssembliesResolver assembliesResolver)
        {
            return new List<Type>();
        }
    }
}