//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class 客戶
    {
        [Required(ErrorMessage ="編號必填")]
        public string 編號 { get; set; }
        [Required(ErrorMessage = "姓名必填")]
        public string 姓名 { get; set; }
        [Required(ErrorMessage = "電話必填")]
        public string 電話 { get; set; }
        [Required(ErrorMessage = "地址必填")]
        public string 地址 { get; set; }
    }
}
