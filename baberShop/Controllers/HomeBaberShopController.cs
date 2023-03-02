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
        BARBERSHOPEntities4 _db = new BARBERSHOPEntities4();
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

        public ActionResult getFormBookSeat()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookSeat()
        {
            String name = Request.Form["bb-name"];
            String phone = Request.Form["bb-phone"];
            ViewBag.Success = name;
            return View();
        }

        public ActionResult profile()
        {
            if (Session["USERNAME"] != null)
            {
                var id = Int32.Parse(Session["ID"].ToString());
                
                
                var bookingList = from t in _db.BOOKINGs
                                    where t.ID_USER == id
                                    select t;
                return View(bookingList.ToList());
            }
            else
            {
                return Redirect("/auth/Login");
            }
        }

        public ActionResult EmployeeDetail(int id)
        {
            
            var profileEmployee = from t in _db.NHANVIENs
                                  where t.ID_NHANVIEN == id
                                  select t;
            return View(profileEmployee);
        }

        public ActionResult ServiceDetail(int id)
        {

            var serviceDetail = from t in _db.SERVICE_SHOP
                                  where t.ID_SERVICE == id
                                  select t;
            return View(serviceDetail);
        }


    }
}