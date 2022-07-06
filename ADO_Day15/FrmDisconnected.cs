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
    public partial class FrmDisconnected : Form
    {
        private SqlConnection conObj = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public FrmDisconnected()
        {
            InitializeComponent();
        }

        private void FrmDisconnected_Load(object sender, EventArgs e)
        {
            using (conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Department", conObj))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    gridDepartment.DataSource = ds.Tables["Department"];

                }
            }
        }
    }
}
