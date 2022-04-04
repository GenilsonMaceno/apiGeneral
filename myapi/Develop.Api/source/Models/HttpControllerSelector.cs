using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace source.Models
{
    public class HttpControllerSelector : IHttpControllerSelector
    {
        public IDictionary<string, HttpControllerDescriptor> GetControllerMapping()
        {
            return new Dictionary<string, HttpControllerDescriptor>();
        }

        public HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            return new HttpControllerDescriptor();
        }
    }
}