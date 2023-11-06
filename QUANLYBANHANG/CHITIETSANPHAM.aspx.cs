using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYBANHANG
{
    public partial class CHITIETSANPHAM : System.Web.UI.Page
    {

        DataTable tbSanPham;
        protected void Page_Load(object sender, EventArgs e)
        {
            XULYDULIEU xuly = new XULYDULIEU();
            String masanpham = Request.QueryString.Get("MASANPHAM");
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MASANPHAM", masanpham);
            tbSanPham = xuly.getTable("psGetTableSANPHAM", pr);
            this.Repeater1.DataSource = tbSanPham;
            this.Repeater1.DataBind();
        }

        protected void Imagecart_Click(object source, ImageClickEventArgs e)
        {
            Session.Timeout = 2;
            App_Code.CART cart = new App_Code.CART();
            if(tbSanPham != null)
            {
                String masanpham = tbSanPham.Rows[0]["MASANPHAM"].ToString();
                String tensanpham = tbSanPham.Rows[0]["TENSANPHAM"].ToString();
                double dongia = Double.Parse(tbSanPham.Rows[0]["DONGIA"].ToString());
                String hinhanh = tbSanPham.Rows[0]["HINHANH"].ToString();
                if (Session["CART"] != null)
                    cart = (App_Code.CART)Session["CART"];
                cart.addCart(masanpham, tensanpham, hinhanh, 1, dongia);
                Session["CART"] = cart;
                Response.Redirect("/pageGIOHANG.aspx");
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}