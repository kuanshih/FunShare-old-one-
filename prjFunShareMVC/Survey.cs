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
    
    public partial class Survey
    {
        public int Survey_ID { get; set; }
        public int Order_Detail_ID { get; set; }
        public int Member_ID { get; set; }
        public Nullable<int> General_Rank { get; set; }
        public string General_Suggestion { get; set; }
        public Nullable<int> Environment_Rank { get; set; }
        public string Environment_Suggestion { get; set; }
        public int Teacher_Rank { get; set; }
        public string Teacher_Suggestion { get; set; }
        public string Others { get; set; }
    
        public virtual Customer_Infomation Customer_Infomation { get; set; }
        public virtual Order_Detail Order_Detail { get; set; }
    }
}
