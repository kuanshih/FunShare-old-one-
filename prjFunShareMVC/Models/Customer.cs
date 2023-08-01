using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using prjFunShareMVC.ViewModels;

namespace prjFunShareMVC.Models
{
    public class Customer
    {
        //public UserInfoViewModel user = new UserInfoViewModel();
        public Customer_Infomation customer { get; set; }
        public int Member_ID { get; set; }

        [Required(ErrorMessage = "姓名不可為空白")]
        [DisplayName("姓名")]
        public string Name
        {
            get { return "測試"; }
            set { }
        }

        [Required(ErrorMessage = "身分證字號不可為空白")]
        [DisplayName("身分證字號")]
        public string Resident_ID{ get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("電話")]
        public string Phone_Number { get; set; }

        [DisplayName("性別")]
        public string Gender { get; set; }

        [DisplayName("暱稱")]
        public string Nickname { get; set; }

        [DisplayName("行政區")]
        public Nullable<int> Disctrict_ID { get; set; }

        [DisplayName("生日")]
        public System.DateTime Birth_Date { get; set; }

        [DisplayName("地址")]
        public string Address { get; set; }

        [DisplayName("過敏")]
        public bool IsAllergy_ { get; set; }

        [DisplayName("過敏史")]
        public string AllergyDescription { get; set; }

        [DisplayName("照片")]
        public byte[] Photo { get; set; }
    }
}