//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYBANHANG_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDANHMUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbDANHMUC()
        {
            this.tbSANPHAM = new HashSet<tbSANPHAM>();
        }
    
        public int MADANHMUC { get; set; }
        public string TENDANHMUC { get; set; }
        public Nullable<int> DANHMUCCHA { get; set; }
        public string MOTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSANPHAM> tbSANPHAM { get; set; }
    }
}
