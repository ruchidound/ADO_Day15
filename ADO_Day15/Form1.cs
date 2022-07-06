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
    public partial class Form1 : Form
    {
        private SqlConnection conObj = null;
        private SqlCommand cmdObj = null;
        private SqlDataReader reader = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (cmdObj = new SqlCommand("select distinct cCity from Employee", conObj))
                {
                    if (conObj.State == ConnectionState.Closed)
                    {
                        conObj.Open();
                    }
                    reader = cmdObj.ExecuteReader();
                    if (reader.HasRows)
                    {
                        ComboCity.Text = "--Select--";
                        while (reader.Read())
                        {
                            ComboCity.Items.Add(reader["cCity"].ToString());
                        }
                    }
                }
            }
        }

        private void ComboCity_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (cmdObj = new SqlCommand("usp_GetEmployeeAndDepartmentByCity", conObj))
                {
                    cmdObj.CommandType = CommandType.StoredProcedure;
                    cmdObj.Parameters.AddWithValue("@City", ComboCity.SelectedItem.ToString());
                    if (conObj.State == ConnectionState.Closed)
                    {
                        conObj.Open();
                    }
                    reader = cmdObj.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        GridEmployee.DataSource = dt;
                    }
                }
            }
        }
    }
}
