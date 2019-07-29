using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanadaSalesManagement1.BL;
using System.IO;

namespace CanadaSalesManagement1.PL
{
    public partial class Frm_AddEditProduct : Form
    {
        CLS_Categories cat = new CLS_Categories();
        CLS_Product product = new CLS_Product();

        public string state = "add";

        public Frm_AddEditProduct()
        {
            InitializeComponent();
            cmbCategories.DataSource = cat.GetAllCategories();
            cmbCategories.DisplayMember = "CatName";
            cmbCategories.ValueMember = "Cat_ID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg;*.bnp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImgProduct.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                ImgProduct.Image.Save(ms, ImgProduct.Image.RawFormat);
                byte[] byteImg = ms.ToArray();

                product.AddProduct(txtProductID.Text, txtProductDescription.Text, Convert.ToInt32(txtQuantity.Text), txtPrice.Text,
                                   byteImg, Convert.ToInt32(cmbCategories.SelectedValue));

                MessageBox.Show("Added Successfully !!", "Add Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                ImgProduct.Image.Save(ms, ImgProduct.Image.RawFormat);
                byte[] byteImg = ms.ToArray();

                product.UpdateProduct(txtProductID.Text,txtProductDescription.Text,Convert.ToInt32(txtQuantity.Text),
                                      txtPrice.Text,byteImg,Convert.ToInt32(cmbCategories.SelectedValue));
                MessageBox.Show("Editted Successfully","Edit Operation");
            }
        }

        private void txtProductID_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = product.VerifyProductID(txtProductID.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This Product exist already", "Warning",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProductID.Focus();
                    txtProductID.SelectAll();
                }
            }
        }

    }
}
