using prjFunShareMVC.ViewModels;
using prjFunShareMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace prjFunShareMVC.Controllers
{
    public partial class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult List()
        {
            return View();
        }

        public ActionResult UserInfo(int? id)
        {
            id = 8;
            if (id == null)
                return RedirectToAction("List");
            FUNShareEntities FUNShare = new FUNShareEntities();
            Customer_Infomation customer = FUNShare.Customer_Infomation.FirstOrDefault(c => c.Member_ID == id);
            if (customer == null)
                return RedirectToAction("List");
            return View(customer);
        }
        [HttpPost]
        //public ActionResult UserInfo(UserInfoViewModel user)
        //{
        //    FUNShareEntities FUNShare = new FUNShareEntities();
        //    Customer_Infomation customer = FUNShare.Customer_Infomation.FirstOrDefault(c => c.Member_ID == user.userID);
        //    if (customer != null)
        //    {
        //        customer.Name = user.txtName;
        //        //customer.Resident_ID = user.txtResidentID;
        //        //customer.Phone_Number = user.txtPhoneNumber;
        //        //customer.Gender = user.radioGender;
        //        //customer.Email = user.userEmail;
        //        //customer.Disctrict_ID = user.DisctrictID;
        //        //customer.Address = user.txtAddress;
        //        //customer.Birth_Date = user.BirthDate;
        //        //customer.Nickname = user.txtNickname;
        //        //customer.IsAllergy_ = user.radioIsAllergy_;
        //        //if (customer.IsAllergy_ == true)
        //        //    customer.AllergyDescription = user.AllergyDescription;
        //        customer.Photo = user.Photo;
        //        FUNShare.SaveChanges();
        //    }
        //    return View();
        //}
        public ActionResult UserInfo(Customer_Infomation x)
        {
            FUNShareEntities FUNShare = new FUNShareEntities();
            Customer_Infomation customer = FUNShare.Customer_Infomation.FirstOrDefault(c => c.Member_ID == x.Member_ID);
            if (customer != null)
            {
                //存進DB;
                return RedirectToAction("List");
            }
            return View();
        }
        public ActionResult myPocketList(int? Id)
        {
            FUNShareEntities FUNShare = new FUNShareEntities();
            IEnumerable<Product> datas = FUNShare.Products.Where(p => p.PocketLists.FirstOrDefault().Member_ID == Id);
            return View(datas);
        }
        
        public ActionResult myOrderList() 
        {
            return View();
        }

        public ActionResult myPoint() 
        {
            return View();
        }
        public ActionResult myCoupon() 
        {
            return View();
        }
    }
}