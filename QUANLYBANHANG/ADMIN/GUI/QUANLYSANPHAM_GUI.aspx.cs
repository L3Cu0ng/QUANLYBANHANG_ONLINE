using QUANLYBANHANG.ADMIN.BUSINESSLOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG.ADMIN.GUI
{
    public partial class QUANLYSANPHAM_GUI : System.Web.UI.Page
    {
        QUANLYSANPHAM_BUSINESSLOGIC businesslogic;
        protected void Page_Load(object sender, EventArgs e)
        {
            businesslogic = new QUANLYSANPHAM_BUSINESSLOGIC(this);
            businesslogic.SetValueDropdownlistDanhMuc();
            businesslogic.SetValueGridViewSanPham();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int k = businesslogic.InsertRecordSanPham();
            businesslogic.SetValueGridViewSanPham();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int k = businesslogic.DeleteRecordSanPham();
            businesslogic.SetValueGridViewSanPham();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int k = businesslogic.UpdateRecordSanPham();
            businesslogic.SetValueGridViewSanPham();
        }
    }
}