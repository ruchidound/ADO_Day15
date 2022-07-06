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
    public partial class DML : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        
        public DML()
        {
            InitializeComponent();
        }
        public void RefreshTable()
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Department", con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    GridDepartment.DataSource = ds.Tables["Department"];
                }
            }
        }

        private void DML_Load(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    DataRow dr = ds.Tables["Department"].NewRow();
                    dr["cDepartmentCode"] = txtCode.Text;
                    dr["vDepartmentName"] = txtName.Text;
                    dr["vDepartmentHead"] = txtHead.Text;
                    dr["vLocation"] = txtLocation.Text;
                    ds.Tables["Department"].Rows.Add(dr);
                    adapter.Update(ds, "Department");
                    adapter.Fill(ds, "Department");
                }
            }
        }

       
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Department where cDepartmentCode like '" + txtCode.Text + "%'", con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridDepartment.DataSource = dt;

                    ds = new DataSet();
                    adapter.Fill(ds, "Depart");
                    txtName.Text = ds.Tables["Depart"].Rows[0]["vDepartmentName"].ToString();
                    txtHead.Text = ds.Tables["Depart"].Rows[0]["vDepartmentHead"].ToString();
                    txtLocation.Text = ds.Tables["Depart"].Rows[0]["vLocation"].ToString();
                    adapter.Update(ds, "Depart");
                    //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    //ds = new DataSet();
                    //adapter.Fill(ds, "Depart");
                    //DataColumn[] dc = new DataColumn[1];
                    //dc[0] = ds.Tables["Depart"].Columns["cDepartmentCode"];
                    //ds.Tables["Depart"].PrimaryKey = dc;
                    //DataRow dr = ds.Tables["Depart"].Rows.Find(txtCode.Text);
                    //txtName.Text = ds.Tables["Depart"].Rows[0]["vDepartmentName"].ToString();
                    //txtHead.Text = ds.Tables["Depart"].Rows[0]["vDepartmentHead"].ToString();
                    //txtLocation.Text = ds.Tables["Depart"].Rows[0]["vLocation"].ToString();
                    //GridDepartment.DataSource = ds.Tables["Depart"];
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");

                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;

                    //DataRow dr = ds.Tables[0].Rows[sindex];
                    DataRow dr = ds.Tables[0].NewRow();
                    dr[0] = txtCode.Text;
                    dr[1] = txtName.Text;
                    dr[2] = txtHead.Text;
                    dr[3] = txtLocation.Text;
                    ds.Tables[0].Rows.Add(dr);
                    adapter.Update(ds, "Department");
                    //GridDepartment.DataSource = ds.Tables[0];
                    adapter.Fill(ds, "Department");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Depart");

                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Depart"].Columns["cDepartmentCode"];
                    ds.Tables["Depart"].PrimaryKey = dc;

                    DataRow dr = ds.Tables["Depart"].Rows.Find(txtCode.Text);
                    ds.Tables["Depart"].Rows.Remove(dr);
                    adapter.Update(ds, "Depart");
                }
            }
        }
    }
}
