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
    public partial class Danhsachsanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XULYDULIEU xuly = new XULYDULIEU();
            String madanhmuc = Request.QueryString.Get("MADANHMUC");
            String SQL;
            if(madanhmuc != null)
            { SQL= "select * from tbSANPHAM where MADANHMUC =" + madanhmuc;
            }
            else
            {SQL = "select * from tbSANPHAM";
            }

            this.DataList1.RepeatColumns = 3;
            this.DataList1.DataSource = xuly.getTable(SQL);
            this.DataList1.DataBind();
        }
    }
}