using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjFunShareMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            FUNShareEntities db = new FUNShareEntities();
            
            return View();
        }
    }
}