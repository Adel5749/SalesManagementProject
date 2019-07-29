using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CanadaSalesManagement1.BL;
using System.IO;
using Microsoft.Reporting.WinForms;
using CanadaSalesManagement1.Reports;

namespace CanadaSalesManagement1.PL
{
    public partial class Frm_Products : Form
    {
        CLS_Product product = new CLS_Product();

        public Frm_Products()
        {
            InitializeComponent();
            dgvProducts.DataSource = product.GetAllProducts();
            dgvProducts.Columns[5].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddEditProduct frm = new Frm_AddEditProduct();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSrchProduct_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= product.SearchProducts(txtSrchProduct.Text);
            dgvProducts.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete it?","Delete Operation", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                product.DeleteProduct(dgvProducts.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted Successfully");
                dgvProducts.DataSource= product.GetAllProducts();
            }
            
        }

        /// <summary>
        /// بعد ما نروح من شاشة ادارة المنتجات إلى شاشة الاضافة ونضيف منتج ونضغط إغلاق
        /// نريد أن نرى تأثير الاضافة على القريد فيو في شاشة ادارة المنتجات
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Products_Activated(object sender, EventArgs e)
        {
            dgvProducts.DataSource = product.GetAllProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Frm_AddEditProduct frm = new Frm_AddEditProduct();
            frm.txtProductID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            frm.txtProductDescription.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            frm.txtQuantity.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "Edit Product";
            frm.btnAddEdit.Text = "Edit";
            frm.state = "edit";
            frm.txtProductID.ReadOnly = true;

            // كيفية جلب ضورة المنتج من الداتابيز وعرضها في البيكتشر بوكس
            byte[] img = (byte[])product.GetProductImage(dgvProducts.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            frm.ImgProduct.Image = Image.FromStream(ms);

            frm.ShowDialog();
        }

        private void btnProdImage_Click(object sender, EventArgs e)
        {
            FrmPreviewImage frm = new FrmPreviewImage();

            // كيفية جلب ضورة المنتج من الداتابيز وعرضها في البيكتشر بوكس
            byte[] img = (byte[])product.GetProductImage(dgvProducts.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            frm.picProdImage.Image = Image.FromStream(ms);

            frm.ShowDialog();
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt;
            dt = product.GetSingleProduct(dgvProducts.CurrentRow.Cells[0].Value.ToString());
            ds.Tables.Add(dt);

            BindingSource bs = new BindingSource(ds, "Table1");  // الاسم الافتراضي للجدول
            ReportDataSource rd = new ReportDataSource("DataSet1", bs);

            FrmViewReport frm = new FrmViewReport();
            frm.reptName = "CanadaSalesManagement1.Reports.ReptSingleProduct.rdlc";
            frm.reptSource = rd;
            frm.ShowDialog();
        }

        private void btnPrintAllProducts_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = product.GetAllProducts();
            ds.Tables.Add(dt);

            BindingSource bs = new BindingSource(ds, "Table1");
            ReportDataSource rd = new ReportDataSource("DataSet1", bs);

            FrmViewReport frm = new FrmViewReport();
            frm.reptName = "CanadaSalesManagement1.Reports.ReptAllProducts.rdlc";
            frm.reptSource = rd;
            frm.ShowDialog();
        }

        private void btnSaveInExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
