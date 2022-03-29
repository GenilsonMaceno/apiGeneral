using source.App_Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace source.Controllers
{
    [RoutePrefix("/api/google")]
    public class GoogleController : Controller
    {
        #region [Endpoint Google]

        private string _googleManagerment;
        private string _googleAccounts;
        private string _googleRedirect_uri;
        private string _oAuth2URL = "/o/oauth2/auth?";

        #endregion

        #region [Parameters Youtube]

        private string _clientId;
        private string _clientSecret;

        #endregion

        public GoogleController()
        {
            _googleManagerment = Config.GoogleManagerment;
            _googleAccounts = Config.GoogleAccounts;
            _googleRedirect_uri = Config.GoogleRedirect_uri;
            _clientId = Config.YoutubeClient_id;
            _clientSecret = Config.YoutubeClient_secret;
        }


        // GET: api/google/authorize
        [HttpGet]
        [Route("~/api/google/authorize")]
        public ActionResult UrlAuthorize()
        {
            var endpoint = string.Concat
                                        (   _googleAccounts, 
                                            _oAuth2URL, 
                                            "client_id=",
                                            _clientId, 
                                            "&redirect_uri=",
                                            _googleRedirect_uri,
                                            "&response_type=code&scope=",
                                            _googleManagerment,
                                            "access_type=offline"
                                        );

            return View(endpoint);
        }
    }
}