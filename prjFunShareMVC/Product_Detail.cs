//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Product_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product_Detail()
        {
            this.Order_Detail = new HashSet<Order_Detail>();
        }
    
        public int Product_Detail_ID { get; set; }
        public int Product_ID { get; set; }
        public Nullable<System.DateTime> Begin_Time { get; set; }
        public Nullable<System.DateTime> End_Time { get; set; }
        public Nullable<int> District_ID { get; set; }
        public int Status_ID { get; set; }
        public string Address { get; set; }
        public decimal UnitPrice { get; set; }
    
        public virtual District District { get; set; }
        public virtual District District1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Detail> Order_Detail { get; set; }
        public virtual Product Product { get; set; }
        public virtual Status Status { get; set; }
    }
}
