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

        public static string GoogleRedirect_uri
        {
            get { return ConfigurationManager.AppSettings["GoogleRedirect_uri"].ToString(); }
        }

        public static string YoutubeClient_id
        {
            get { return ConfigurationManager.AppSettings["YoutubeClient_id"].ToString(); }
        }

        public static string YoutubeClient_secret
        {
            get { return ConfigurationManager.AppSettings["YoutubeClient_secret"].ToString(); }
        }
    }
}