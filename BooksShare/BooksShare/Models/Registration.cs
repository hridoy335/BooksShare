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
    
    public partial class Registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registration()
        {
            this.User_Information = new HashSet<User_Information>();
        }
    
        public int Registration_Id { get; set; }
        public string Registration_Email { get; set; }
        public string Registration_Contact { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public System.DateTime Makedate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Information> User_Information { get; set; }
    }
}
