//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLIBANHANG_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PARTY()
        {
            this.GROUP_USER_RELATIONSHIP_USER = new HashSet<GROUP_USER_RELATIONSHIP_USER>();
            this.tbHOADON = new HashSet<tbHOADON>();
        }
    
        public decimal PARTY_ID { get; set; }
        public string TYPE_OF_PARTY { get; set; }
        public Nullable<int> DEPARTMENT_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string USERNAME_H { get; set; }
        public string PASSWORD_H { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GROUP_USER_RELATIONSHIP_USER> GROUP_USER_RELATIONSHIP_USER { get; set; }
        public virtual PERSON PERSON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHOADON> tbHOADON { get; set; }
    }
}
