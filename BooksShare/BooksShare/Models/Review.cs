//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BooksShare.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int Review_Id { get; set; }
        public int User_Id_Buyer { get; set; }
        public int User_Id_Seller { get; set; }
        public int Point { get; set; }
        public string Comment { get; set; }
        public System.DateTime Makedate { get; set; }
    
        public virtual User_Information User_Information { get; set; }
        public virtual User_Information User_Information1 { get; set; }
    }
}
