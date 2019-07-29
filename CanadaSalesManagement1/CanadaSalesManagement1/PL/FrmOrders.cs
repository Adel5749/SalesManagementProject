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
using System.Globalization;
using Microsoft.Reporting.WinForms;
using CanadaSalesManagement1.Reports;

namespace CanadaSalesManagement1.PL
{
    public partial class FrmOrders : Form
    {
        CLS_Orders order = new CLS_Orders();

        public string state = "Add";  // لمعرفة العملية التي نريد القيام بها في تلك الشاشة هل هي إضافة فاتورة أو تعديل فاتورة

        DataTable dt = new DataTable();

        public void CreateTable()
        {
            dt.Columns.Add("Pord ID");
            dt.Columns.Add("Prod Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Discount %");
            dt.Columns.Add("Net Amount");

            dgvProducts.DataSource = dt;
        }

        public void ResizeDGV()
        {
            dgvProducts.Columns[0].Width = 80;
            dgvProducts.Columns[1].Width = 140;
            dgvProducts.Columns[2].Width = 106;
            dgvProducts.Columns[3].Width = 102;
            dgvProducts.Columns[4].Width = 102;
            dgvProducts.Columns[5].Width = 105;
        }

        public void CalculateAmount()
        {
            if(txtProdQty.Text!=string.Empty && txtProdPrice.Text != string.Empty)
            {
                txtProdAmount.Text = (Convert.ToDouble(txtProdQty.Text) * Convert.ToDouble(txtProdPrice.Text)).ToString();
            }
        }

        public void CalculateNetAmount()
        {
            if(txtProdDiscount.Text!=string.Empty && txtProdAmount.Text != string.Empty)
            {
                double amount = Convert.ToDouble(txtProdAmount.Text);
                double discount = Convert.ToDouble(txtProdDiscount.Text);
                double netAmount = amount - (amount * discount / 100);
                txtPrdNetAmount.Text = netAmount.ToString();
            }
        }

        public void ClearBoxes()
        {
            txtProdID.Clear();
            txtProdName.Clear();
            txtProdQty.Clear();
            txtProdPrice.Clear();
            txtProdAmount.Clear();
            txtProdDiscount.Clear();
            txtPrdNetAmount.Clear();

            btnBrowsProducts.Focus();
        }

        public void ClearAllBoxes()
        {
            txtOrderID.Clear();
            txtOrderDesc.Clear();
            dtpOrderDate.ResetText();
            txtSalesMan.Clear();
            txtCustID.Clear();
            txtCustName.Clear();
            txtCustFamilyName.Clear();
            txtCustPhone.Clear();
            txtEmail.Clear();
            ClearBoxes();
            picCust.Image = null;
            dt.Clear();
            dgvProducts.Refresh();
            btnNewOrder.Enabled = true;
            btnSaveInvoice.Enabled = false;
            btnNewOrder.Focus();
        }

        public FrmOrders()
        {
            InitializeComponent();
            CreateTable();
            txtSalesMan.Text = Program.salesMan;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            btnSaveInvoice.Enabled = true;
            btnNewOrder.Enabled = false;
            btnDeleteRow.Enabled = true;

            txtOrderID.Text = order.GetNewOrderID().Rows[0][0].ToString();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            // Check the orderID, CustomerID, OrderDetails, OrderDescription
            if(txtOrderID.Text==string.Empty || txtCustID.Text==string.Empty||
               txtOrderDesc.Text==string.Empty|| dgvProducts.Rows.Count == 0)
            {
                MessageBox.Show("Please fill importants Boxes", "Warning");
                return;
            }

            // insert into Orders Table
            order.AddOrder(Convert.ToInt32(txtOrderID.Text), dtpOrderDate.Value, 
                           Convert.ToInt32(txtCustID.Text), txtOrderDesc.Text, txtSalesMan.Text);

            // insert into OrderDetails Table
            for(int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                order.AddOrderDetails(Convert.ToInt32(txtOrderID.Text),
                                      dgvProducts.Rows[i].Cells[0].Value.ToString(),
                                      Convert.ToInt32(dgvProducts.Rows[i].Cells[3].Value),
                                      dgvProducts.Rows[i].Cells[2].Value.ToString(),
                                      Convert.ToDouble(dgvProducts.Rows[i].Cells[4].Value),
                                      dgvProducts.Rows[i].Cells[5].Value.ToString(),
                                      dgvProducts.Rows[i].Cells[6].Value.ToString());
            }

            MessageBox.Show("Saved Successfully", "Save Operation");

            // Clear and reset all values
            ClearAllBoxes();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomersList frm = new FrmCustomersList();
            frm.ShowDialog();

            picCust.Image = null; // عشان لا تنتقل صورة العميل السابق إلى العميل التالي
            txtCustID.Text = frm.dgvCustomersList.CurrentRow.Cells[0].Value.ToString();
            txtCustName.Text = frm.dgvCustomersList.CurrentRow.Cells[1].Value.ToString();
            txtCustFamilyName.Text = frm.dgvCustomersList.CurrentRow.Cells[2].Value.ToString();
            txtCustPhone.Text = frm.dgvCustomersList.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = frm.dgvCustomersList.CurrentRow.Cells[4].Value.ToString();

            try  // عشان ما يعطيني خطأ لو كان مافي صورة وحاول يحولها إلى قيمة ثنائية
            {
                byte[] img = (byte[])frm.dgvCustomersList.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                picCust.Image = Image.FromStream(ms);
            }
            catch
            {

            }
       }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            ResizeDGV();
        }

        private void btnBrowsProducts_Click(object sender, EventArgs e)
        {
            ClearBoxes();

            FrmProductsList frm = new FrmProductsList();
            frm.ShowDialog();

            txtProdID.Text = frm.dgvProductsList.CurrentRow.Cells[0].Value.ToString();
            txtProdName.Text = frm.dgvProductsList.CurrentRow.Cells[1].Value.ToString();
            txtProdPrice.Text = frm.dgvProductsList.CurrentRow.Cells[3].Value.ToString();
            txtProdQty.Focus();
        }

        private void txtProdQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!=decimalChar )
            {
                e.Handled = true;
            }
        }

        private void txtProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalChar)
            {
                e.Handled = true;
            }
        }

        private void txtProdPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtProdPrice.Text != string.Empty)
            {
                txtProdQty.Focus();
            }
        }

        private void txtProdQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtProdQty.Text != string.Empty)
            {
                txtProdDiscount.Focus();
            }
        }

        private void txtProdQty_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateNetAmount();
        }

        private void txtProdPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void txtProdDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalDigit = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!=decimalDigit)
            {
                e.Handled = true;
            }
        }

        private void txtProdDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateNetAmount();
            CalculateNetAmount();
        }

        private void txtProdDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            // يقوم بالتشييك هل الكمية المدخلة متوفرة في المخزن
            if (order.VerifyProdQuantity(txtProdID.Text, Convert.ToInt32(txtProdQty.Text)).Rows.Count<1)
            {
                MessageBox.Show("This quantity is not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // يقوم بالتشييك هل تم إدخال هذا المنتج في القريد فيو من قبل
            for(int i =0; i < dgvProducts.Rows.Count; i++)
            {
                if(dgvProducts.Rows[i].Cells[0].Value.ToString() == txtProdID.Text)
                {
                    MessageBox.Show("This product is already exist");
                    return;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                DataRow row = dt.NewRow();
                row[0] = txtProdID.Text;
                row[1] = txtProdName.Text;
                row[2] = txtProdPrice.Text;
                row[3] = txtProdQty.Text;
                row[4] = txtProdAmount.Text;
                row[5] = txtProdDiscount.Text;
                row[6] = txtPrdNetAmount.Text;

                dt.Rows.Add(row);

                dgvProducts.DataSource = dt;
                ClearBoxes();

                // حساب المجموع في القريد فيو
                double total = 0;
                foreach (DataGridViewRow myRow in dgvProducts.Rows)
                {
                    total += Convert.ToDouble(myRow.Cells[6].Value);
                }
                txtTotal.Text = total.ToString();
            }
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtProdID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                txtProdName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtProdPrice.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                txtProdQty.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                txtProdAmount.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                txtProdDiscount.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
                txtPrdNetAmount.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();

                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // حساب المجموع في القريد فيو
            double total = 0;
            foreach (DataGridViewRow myRow in dgvProducts.Rows)
            {
                total += Convert.ToDouble(myRow.Cells[6].Value);
            }
            txtTotal.Text = total.ToString();

            // يقوم بالتشييك لو كان في صفوف في القريد يظل زر حذف السطر مفعل
            if (dgvProducts.Rows.Count > 0)
            {
                btnDeleteRow.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts_DoubleClick(null, null);
        }

        private void حذفالصفالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void حذفجميعالصفوفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgvProducts.Refresh();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;  // عشان يفهم المستخدم إن التقرير في وضع التحميل وبعد مايفتح التقرير نرجع شكل الماوس

            // GetLastOrderID_ForPrint أولا نجلب رقم آخر فاتورة تم تخزينها ، عن طريق الاجراء المخزن 
            int orderID = Convert.ToInt16(order.GetLastOrderID().Rows[0][0]);

            DataSet ds = new DataSet();
            DataTable dt = order.GetOrderDetailsByOrderID(orderID);
            ds.Tables.Add(dt);

            BindingSource bs = new BindingSource(ds, "Table1");
            ReportDataSource rd = new ReportDataSource("DataSet1", bs);

            FrmViewReport frm = new FrmViewReport();
            frm.reptName = "CanadaSalesManagement1.Reports.ReptOrderDetailsByOrderID.rdlc";
            frm.reptSource = rd;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;  // نرجع شكل الماوس للشكل الافتراضي
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvProducts.Rows.Count > 0)
            {
                btnDeleteRow.Enabled = true;
            }
        }
    }
}
