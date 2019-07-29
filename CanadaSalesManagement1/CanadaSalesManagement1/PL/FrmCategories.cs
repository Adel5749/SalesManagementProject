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
//using Canada_KhaledSaadani_SalesManagement.Reports;


namespace CanadaSalesManagement1.PL
{
    public partial class FrmCategories : Form
    {
        SqlConnection con;
        SqlCommandBuilder builder;
        SqlDataAdapter da;
        DataTable dt;
        CurrencyManager cur;

        public FrmCategories()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server=.\SQL_Canada2017;DataBase=KhalidSaadani_SalesManagement;
                                              Integrated Security=false; User ID =sa; Password=5562404");

            da = new SqlDataAdapter("Select Cat_ID,CatName From Categories", con);
            dt = new DataTable();
            da.Fill(dt);
            dgvCategories.DataSource = dt;
            dgvCategories.Columns[0].Visible = false;

            txtCatID.DataBindings.Add("Text", dt, "Cat_ID");
            txtCatDesc.DataBindings.Add("Text", dt, "CatName");
            cur = (CurrencyManager)this.BindingContext[dt];
            lblPosition.Text = (cur.Position + 1) + "/" + cur.Count;

            btnAdd.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            cur.Position = 0;
            lblPosition.Text = (cur.Position + 1) + "/" + cur.Count;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            cur.Position -= 1;
            lblPosition.Text = (cur.Position + 1) + "/" + cur.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cur.Position += 1;
            lblPosition.Text = (cur.Position + 1) + "/" + cur.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            cur.Position = cur.Count;
            lblPosition.Text = (cur.Position + 1) + "/" + cur.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cur.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = Convert.ToInt16(dt.Rows[dt.Rows.Count - 1][0])+1;
            txtCatID.Text = id.ToString();
            txtCatDesc.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cur.EndCurrentEdit();
            builder = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Added successfully");
            btnAdd.Enabled = false;
            btnNew.Enabled = true; ;
            lblPosition.Text = (cur.Position - 1) + "/" + cur.Count;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cur.EndCurrentEdit();
            builder = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Editted Successfully");
            lblPosition.Text = (cur.Position + 1) + "/" + cur.Count;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cur.RemoveAt(cur.Position);
            cur.EndCurrentEdit();
            builder = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("deleted successfully");
            lblPosition.Text = (cur.Position - 1) + "/" + cur.Count;
       
        }

        private void btnPrintAllCategories_Click(object sender, EventArgs e)
        {

        }
    }
}
