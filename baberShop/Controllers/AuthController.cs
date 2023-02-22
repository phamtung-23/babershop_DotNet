using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using baberShop.Models;
using System.Web.UI;
using System.Text;

namespace baberShop.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        BARBERSHOPEntities1 _db = new BARBERSHOPEntities1();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ACCOUNT_USER _user)
        {
            if (ModelState.IsValid)
            {
                if(_user.USERNAME == null || _user.PASSWORD_USER ==null) {
                    ViewBag.error = "Vui lòng điền username hoặc password!";
                    return View();
                }

                var f_password = GetMD5(_user.PASSWORD_USER);
                var data = _db.ACCOUNT_USER.Where(s => s.USERNAME.Equals(_user.USERNAME) && s.PASSWORD_USER.Equals(f_password)).ToList();
                
                if (data.Count() > 0)
                {
                    //add session
                    Session["USERNAME"] = data.FirstOrDefault().USERNAME ;
                    Session["ID"] = data.FirstOrDefault().ID_USER;
                    Session["CHECK_EMPLOYEE"] = data.FirstOrDefault().CHECK_EMPLOYEE;
                    return Redirect("/HomeBaberShop/Index");
                }
                else
                {
                    ViewBag.error = "Đã xảy ra lỗi username hoặc password!";
                    return View();
                }
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(ACCOUNT_USER _user)
        {
            if (ModelState.IsValid)
            {
                var check = _db.ACCOUNT_USER.FirstOrDefault(s => s.USERNAME == _user.USERNAME);
                if(_user.USERNAME == null || _user.PASSWORD_USER == null)
                {
                    ViewBag.error = "Vui lòng điền đầy đủ thông tin!!";
                    return View();
                }
                if (check == null)
                {
                    _user.PASSWORD_USER = GetMD5(_user.PASSWORD_USER);
                    _db.Configuration.ValidateOnSaveEnabled = false;
                    _db.ACCOUNT_USER.Add(_user);
                    _db.SaveChanges();
                    return RedirectToAction("/login");
                }
                else
                {
                    
                    ViewBag.error = "Username đã tồn tại!!!";

                    return View();
                }


            }
            return View();


        }

        //Logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return Redirect("/HomeBaberShop/Index");
        }
        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}