//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYBANHANG
{
    using System;
    using System.Collections.Generic;
    
    public partial class APPLICATIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPLICATIONS()
        {
            this.MENU_FORM = new HashSet<MENU_FORM>();
        }
    
        public decimal ID_APPLICATION { get; set; }
        public string APPLICATION_NAME { get; set; }
        public string DESCRIPTION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENU_FORM> MENU_FORM { get; set; }
    }
}
