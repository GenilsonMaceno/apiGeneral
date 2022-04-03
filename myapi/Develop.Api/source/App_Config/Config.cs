using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace source.App_Config
{
    public static class Config
    {
        public static string GoogleManagerment
        {
            get { return ConfigurationManager.AppSettings["GoogleManagerment"].ToString(); }
        }

        public static string GoogleAccounts
        {
            get { return ConfigurationManager.AppSettings["GoogleAccounts"].ToString(); }
        }

        public static string GoogleRedirectUri
        {
            get { return ConfigurationManager.AppSettings["GoogleRedirect_uri"].ToString(); }
        }

        public static string YoutubeClientId
        {
            get { return ConfigurationManager.AppSettings["YoutubeClient_id"].ToString(); }
        }

        public static string YoutubeClientSecret
        {
            get { return ConfigurationManager.AppSettings["YoutubeClient_secret"].ToString(); }
        }
    }
}