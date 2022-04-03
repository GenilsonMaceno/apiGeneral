using source.App_Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web;

namespace source.Controllers
{
    [RoutePrefix("/api/google")]
    public class GoogleController : ApiController
    {
        #region [Endpoint Google]

        private string _googleManagerment;
        private string _googleAccounts;
        private string _googleRedirectUri;
        private string _googleUrl = "/o/oauth2/auth?client_id={0}&redirect_uri={1}&scope={2}&response_type={3}&access_type={4}";
        private string _acessType; // offline
        private string _responseType; // code

        #endregion

        #region [Parameters Youtube]

        private string _clientId;
        private string _clientSecret;

        #endregion

        public GoogleController()
        {
            _googleManagerment = Config.GoogleManagerment;
            _googleAccounts = Config.GoogleAccounts;
            _googleRedirectUri = Config.GoogleRedirectUri;
            _clientId = Config.YoutubeClientId;
            _clientSecret = Config.YoutubeClientSecret;
        }


        // GET: api/google/authorize
        [HttpGet]
        [Route("~/api/google/authorize")]
        public async Task<HttpResponseMessage> UrlAuthorize()
        {
            _acessType = "offline";
            _responseType = "code";

            var endpoint = string.Concat(_googleAccounts, string.Format(_googleUrl,_clientId, _googleRedirectUri, _googleManagerment, _responseType, _acessType));

            var output = new
            {
                Url = endpoint,
                Status = "Sucesso"
            };

            return Request.CreateResponse(HttpStatusCode.OK, output);
        }
    }
}