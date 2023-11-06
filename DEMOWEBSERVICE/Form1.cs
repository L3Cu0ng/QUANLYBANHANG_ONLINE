using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOWEBSERVICE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ServiceReference1.Service1Client sv = new ServiceReference1.Service1Client();
            String sql = "select * from tbDANHMUC";
            this.dataGridView1.DataSource = sv.getTable(sql).Tables[0];
        }
    }
}
