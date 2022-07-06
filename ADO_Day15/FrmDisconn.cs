using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace ADO_Day15
{
    public partial class FrmDisconn : Form
    {
        private SqlConnection conObj = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public FrmDisconn()
        {
            InitializeComponent();
        }

        private void FrmDisconn_Load(object sender, EventArgs e)
        {
            using (conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Department where cDepartmentCode=0002", conObj))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Depart");
                    txtCode.Text = ds.Tables["Depart"].Rows[0]["cDepartmentCode"].ToString();
                    txtName.Text = ds.Tables["Depart"].Rows[0]["vDepartmentName"].ToString();
                    txtHead.Text = ds.Tables["Depart"].Rows[0]["vDepartmentHead"].ToString();
                    txtLocation.Text = ds.Tables["Depart"].Rows[0]["vLocation"].ToString();

                }

            }
        }
    }
}
