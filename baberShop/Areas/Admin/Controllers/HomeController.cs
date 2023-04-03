using baberShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baberShop.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        BARBERSHOPEntities4 _db = new BARBERSHOPEntities4();

        public object ID_USER { get; private set; }

        // GET: Admin/Home
        public ActionResult Index()
        {
            var v = from t in _db.ACCOUNT_USER
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult User()
        {
            var v = from t in _db.ACCOUNT_USER
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult Service()
        {
            var v = from t in _db.SERVICE_SHOP
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult Booking()
        {
            var v = from t in _db.BOOKINGs
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult Menu()
        {
            var v = from t in _db.MENUs
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult Employee()
        {
            var v = from t in _db.NHANVIENs
                    select t;
            return PartialView(v.ToList());
        }

        
        
      
    }
}