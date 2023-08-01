using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjFunShareMVC.ViewModels
{
    public class UserInfoViewModel
    {
        public int userID { get; set; }
        public string txtName { get; set; }
        public string txtResidentID { get; set; }        
        public string userEmail { get; set; }
        public string txtPhoneNumber { get; set; }
        public string radioGender { get; set; }
        public string txtNickname { get; set; }

        public int DisctrictID { get; set; }
        public DateTime BirthDate { get; set; }
        public string txtAddress { get; set; }
        public bool radioIsAllergy_ { get; set; }
        public string AllergyDescription { get; set; }
        public byte[] Photo { get; set; }
    }
}