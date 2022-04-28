using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Hosting;
using System.Web.Http.WebHost;

namespace source.App_Config
{
    public class HostBufferPolicySelector : WebHostBufferPolicySelector
    {
        public override bool UseBufferedInputStream(object hostContext)
        {
            var context = hostContext as HttpContextBase;

            if (context != null)
            {
                var controller = context.Request.RequestContext.RouteData?.Values?["Controller"]?.ToString();

                if (string.Equals(controller, "uploading", StringComparison.InvariantCultureIgnoreCase))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool UseBufferedOutputStream(HttpResponseMessage response)
        {
            return base.UseBufferedOutputStream(response);
        }
    }
}