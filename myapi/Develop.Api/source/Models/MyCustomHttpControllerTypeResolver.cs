using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace source.Models
{
    public class MyCustomHttpControllerTypeResolver : IHttpControllerTypeResolver
    {
        public MyCustomHttpControllerTypeResolver() 
        {
        }

        public ICollection<Type> GetControllerTypes(IAssembliesResolver assembliesResolver)
        {

            var types = assembliesResolver.GetType();

            return (ICollection<Type>)assembliesResolver.GetAssemblies();
        }
    }
}