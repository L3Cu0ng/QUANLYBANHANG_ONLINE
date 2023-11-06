using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG
{
    public partial class pageGIOHANG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOGIN"] != null)
            {
                DataTable tbLogin = (DataTable)Session["LOGIN"]; if (!IsPostBack && tbLogin.Rows.Count > 0)
                    loadCart();
            }
            else
                Response.Redirect("DANHSACHSANPHAM.aspx");
        }

        private void loadCart()
        {
            if (Session["CART"] != null)
            {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            this.grvCARD.DataSource = cart.LISTCARTS.Values.ToList();
            this.grvCARD.DataBind();
            this.grvCARD.FooterRow.Cells[0].Text = "Tổng tiền= ";
            this.grvCARD.FooterRow.Cells[4].Text = cart.totalBill().ToString();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void btnDELETE_Click(object sender, EventArgs e)
        {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            foreach(GridViewRow row in grvCARD.Rows)
            {
                CheckBox ckb = (CheckBox)row.FindControl("ckbREMOVEITEM");
                if (ckb.Checked)
                {
                    String masanpham = row.Cells[0].Text;
                    cart.removeCart(masanpham);
                }
            }
            Session["CART"] = cart;
            loadCart();
        }
    }
}