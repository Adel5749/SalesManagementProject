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
    public partial class FrmCustomers : Form
    {
        CLS_Customers customer = new CLS_Customers();
        int position = 0;

        /// <summary>
        /// نستدعي دالة جلب جميع البيانات لعرضها في القريد فيو مع مراعاة إخفاء عمود رقم المعرف وعمود صورة العميل
        /// </summary>
        public FrmCustomers()
        {
            InitializeComponent();
            dgvAllCustomers.DataSource= customer.GetAllCustomers();

            // نخفي عمود المعرف لأنه ليس له علاقة بمستخدم البرنامج ، ونخفي عمود الصورة لأننا لا نريد إظهارها في القريد فيو
            dgvAllCustomers.Columns[0].Visible = false;
            dgvAllCustomers.Columns[5].Visible = false;
        }

        /// <summary>
        /// عند الضغط على البيكشر بوكس يتم فتح نافذة لاختيار صورة للعميل
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.jpg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picCustomer.Image = Image.FromFile(ofd.FileName);
            }
        }

        /// <summary>
        /// عند تعبئة التكست بوكس ثم الضغط على زر إنتر يتم الانتقال إلى التكست بوكس التالية
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFamilyName.Focus();
            }
        }

        /// <summary>
        /// عند تعبئة التكست بوكس ثم الضغط على زر إنتر يتم الانتقال إلى التكست بوكس التالية
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFamilyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        /// <summary>
        /// عند تعبئة التكست بوكس ثم الضغط على زر إنتر يتم الانتقال إلى التكست بوكس التالية
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        /// <summary>
        /// عند تعبئة التكست بوكس ثم الضغط على زر إنتر يتم الانتقال إلى التكست بوكس التالية
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void txtSrch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvAllCustomers.DataSource = customer.SearchCustomers(txtSrch.Text);
            }
        }

        /// <summary>
        /// عند الضغط على زر جديد يتم تفريغ الحقول ووضع التركيز على التكست بوكس الأولى
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFamilyName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            picCustomer.Image = null;
            txtName.Focus();
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // مهم جدا جدا:: إذا حاولنا إضافة عميل بدون صورة سيعطينا خطأ لأن الداتا بيز تقبل فقط قيمة ثنائية لحقل الصورة
            // وعندما تكون الصورة قيمتها نل فهي ليست معروفة كقيمة ثنائية ، وبالتالي استخدمنا حيلة مهمة في ذلك
            try
            {

                byte[] myImage;

                if (picCustomer.Image == null)
                {
                    myImage = new byte[0];
                    customer.AddCustemer(txtName.Text, txtFamilyName.Text,
                                         txtPhone.Text, txtEmail.Text, myImage, "Without Image");

                    MessageBox.Show("Added Successfully", "Add Operation",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvAllCustomers.DataSource = customer.GetAllCustomers();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    picCustomer.Image.Save(ms, picCustomer.Image.RawFormat);
                    myImage = (byte[])ms.ToArray();

                    customer.AddCustemer(txtName.Text, txtFamilyName.Text,
                                         txtPhone.Text, txtEmail.Text, myImage, "With Image");

                    MessageBox.Show("Added Successfully", "Add Operation",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvAllCustomers.DataSource = customer.GetAllCustomers();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnNew.Enabled = true;
                btnAdd.Enabled = false; ;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            byte[] myImage;

            if (picCustomer.Image == null)
            {
                myImage = new byte[0];
                customer.UpdateCustomer(txtName.Text, txtFamilyName.Text, txtPhone.Text, txtEmail.Text, myImage, "Without Image",
                                        Convert.ToInt32(dgvAllCustomers.CurrentRow.Cells[0].Value));
                MessageBox.Show("Editted Successfully", "Edit Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAllCustomers.DataSource = customer.GetAllCustomers();
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                picCustomer.Image.Save(ms, picCustomer.Image.RawFormat);
                myImage = (byte[])ms.ToArray();

                customer.UpdateCustomer(txtName.Text, txtFamilyName.Text, txtPhone.Text, txtEmail.Text, myImage, "With Image",
                                        Convert.ToInt32(dgvAllCustomers.CurrentRow.Cells[0].Value));

                MessageBox.Show("Updated Successfully", "Edit Operateion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAllCustomers.DataSource = customer.GetAllCustomers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do U want to delete " + txtName.Text + " ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                customer.DeleteCustomer(Convert.ToInt32(dgvAllCustomers.CurrentRow.Cells[0].Value));
                dgvAllCustomers.DataSource = customer.GetAllCustomers();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            dgvAllCustomers.DataSource= customer.SearchCustomers(txtSrch.Text);
        }

        public void Navigate(int index)
        {
            try // عشان لو كان العميل ماعنده صورة ما يعطيني خطأ
            {
                txtName.Text = dgvAllCustomers.Rows[index].Cells[1].Value.ToString();
                txtFamilyName.Text = dgvAllCustomers.Rows[index].Cells[2].Value.ToString();
                txtPhone.Text = dgvAllCustomers.Rows[index].Cells[3].Value.ToString();
                txtEmail.Text = dgvAllCustomers.Rows[index].Cells[4].Value.ToString();

                picCustomer.Image = null;
                byte[] myImage = (byte[])dgvAllCustomers.Rows[index].Cells[5].Value;
                MemoryStream ms = new MemoryStream(myImage);
                picCustomer.Image = Image.FromStream(ms);

                dgvAllCustomers.ClearSelection();
                dgvAllCustomers.Rows[index].Selected = true;
            }
            catch 
            {
                return;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            position = 0;
            Navigate(0);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            position = customer.GetAllCustomers().Rows.Count -1;
            Navigate(position);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position -= 1;
                Navigate(position);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (position < customer.GetAllCustomers().Rows.Count-1)
            {
                position += 1;
                Navigate(position);
            }
        }

        /// <summary>
        /// عند الضغط على أي صف في القريد فيو ضغطتين متتاليتين يتم نقل بيانات الصف المحدد إلى خانات التكست بوكس
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAllCustomers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAllCustomers.CurrentRow.Index != -1)
            {
                position = dgvAllCustomers.CurrentRow.Index;
                Navigate(position);
            }
        }

        /// <summary>
        /// عند الضغط على القريد فيو يتم التأكد أنه تم الضغط على صف معين ، ثم ننقل بيانات الصف المحدد إلى خانات التكست بوكس
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAllCustomers_Click(object sender, EventArgs e)
        {
            if (dgvAllCustomers.CurrentRow.Index != -1)
            {
                position = dgvAllCustomers.CurrentRow.Index;
                Navigate(position);
            }
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            Navigate(position);
        }
    }
}
