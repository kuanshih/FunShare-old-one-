﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjFunShareMVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FUNShareEntities : DbContext
    {
        public FUNShareEntities()
            : base("name=FUNShareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<AchievementList> AchievementLists { get; set; }
        public virtual DbSet<Advertise_Order> Advertise_Order { get; set; }
        public virtual DbSet<Advertise_Product> Advertise_Product { get; set; }
        public virtual DbSet<Advertise_Product_Detail> Advertise_Product_Detail { get; set; }
        public virtual DbSet<Age> Ages { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Customer_Infomation> Customer_Infomation { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Image_List> Image_List { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<MemberAchievement> MemberAchievements { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Order_Detail> Order_Detail { get; set; }
        public virtual DbSet<PocketList> PocketLists { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Detail> Product_Detail { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
