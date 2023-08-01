using prjFunShareMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjFunShareMVC.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Home()
        {
            if (Session[CDictionary.SK_LOGINED_USER] == null)
                return RedirectToAction("Login");
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Login(CLoginViewModel vm)
        //{
        //    Customer customer = (new CustomerFactory()).queryByEmail(vm.txtAccount);
        //    if (customer != null && customer.fPassword.Equals(vm.txtPassword))
        //    {
        //        Session[CDictionary.SK_LOGINED_USER] = customer;
        //        return RedirectToAction("Home");
        //    }
        //    return View();
        //}
    }
}