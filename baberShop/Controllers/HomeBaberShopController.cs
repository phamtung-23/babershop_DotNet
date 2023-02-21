using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baberShop.Models;

namespace baberShop.Controllers
{
    public class HomeBaberShopController : Controller

    {
        BARBERSHOPEntities1 _db = new BARBERSHOPEntities1();
        // GET: HomeBaberShop
        public ActionResult Index()
        {
            return View();
        }
    
        public ActionResult getMenu()
        {
            var v = from t in _db.MENUs
                    where t.STATUS_MENU == true
                    select t;
            return PartialView(v.ToList());
        }
     
        public ActionResult getPrice()
        {
            var v = from t in _db.SERVICE_SHOP
                    where t.STATUS_SERVICE == true
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult getContact()
        {
            var v = from t in _db.INFOR_SHOP
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult getContactAddress()
        {
            var v = from t in _db.INFOR_SHOP
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult getEmployee()
        {
            var v = from t in _db.NHANVIENs
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult getService()
        {
            var v = from t in _db.SERVICE_SHOP
                    where t.STATUS_SERVICE == true
                    select t;
            return PartialView(v.ToList());
        }

    }
}