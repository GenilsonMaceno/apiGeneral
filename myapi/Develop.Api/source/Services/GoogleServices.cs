using source.App_Config;
using source.Interfarce.Services;
using source.Models.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace source.Services
{

    public class GoogleServices : IGoogleServices
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

        public GoogleServices()
        {
            _googleManagerment = Config.GoogleManagerment;
            _googleAccounts = Config.GoogleAccounts;
            _googleRedirectUri = Config.GoogleRedirectUri;
            _clientId = Config.YoutubeClientId;
            _clientSecret = Config.YoutubeClientSecret;
        }

        public async Task<Google> GetURIAthorize()
        {
            var google = new Google();

            _acessType = "offline";
            _responseType = "code";

            var UrlGoogle = string.Concat(_googleAccounts, string.Format(_googleUrl, _clientId, _googleRedirectUri, _googleManagerment, _responseType, _acessType));

            google.Url = UrlGoogle;

            return google;
        }
    }
}