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
    
    public partial class tbKHANHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbKHANHHANG()
        {
            this.tbHOADON = new HashSet<tbHOADON>();
        }
    
        public decimal MAKHACHHANG { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string GIOITINH { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public string TAIKHOAN { get; set; }
        public string MATKHAU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHOADON> tbHOADON { get; set; }
    }
}
