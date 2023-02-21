using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baberShop.Controllers
{
    public class HomeBaberShopController : Controller
    {
        // GET: HomeBaberShop
        public ActionResult Index()
        {
            return View();
        }
    }
}