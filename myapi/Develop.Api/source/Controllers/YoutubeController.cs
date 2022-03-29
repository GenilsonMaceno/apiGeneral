using source.App_Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace source.Controllers
{
    public class YoutubeController : Controller
    {
        

        public YoutubeController()
        {

        }

        // GET: Youtube
        public ActionResult Index()
        {
            return View();
        }
    }
}