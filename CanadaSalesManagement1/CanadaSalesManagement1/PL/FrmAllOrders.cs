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
using CanadaSalesManagement1.Reports;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace CanadaSalesManagement1.PL
{
    public partial class FrmAllOrders : Form
    {
        CLS_Orders order = new CLS_Orders();

        public FrmAllOrders()
        {
            InitializeComponent();
            dgvAllOrdersList.DataSource = order.SearchOrders("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            dgvAllOrdersList.DataSource = order.SearchOrders(txtSearchOrder.Text);
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            FrmOrders frm = new FrmOrders();
            frm.Text = "Add New Invoice Form";
            frm.txtOrderID.Text = order.GetNewOrderID().Rows[0][0].ToString();
            frm.btnSaveInvoice.Enabled = true;
            frm.btnNewOrder.Enabled = false;
            frm.state = "Add";
            frm.ShowDialog();
            dgvAllOrdersList.DataSource = order.SearchOrders("");
        }

        private void btnPrintDetailsOfSelectedOrder_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;  // عشان يفهم المستخدم إن التقرير في وضع التحميل وبعد مايفتح التقرير نرجع شكل الماوس

            int orderID = Convert.ToInt32(dgvAllOrdersList.CurrentRow.Cells[0].Value);

            this.Cursor = Cursors.WaitCursor;  // عشان يفهم المستخدم إن التقرير في وضع التحميل وبعد مايفتح التقرير نرجع شكل الماوس

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

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            FrmOrders frm = new FrmOrders();
            frm.Text = "Edit Order No: " + dgvAllOrdersList.CurrentRow.Cells[0].Value.ToString();
            frm.btnSaveInvoice.Enabled = true;
            frm.btnNewOrder.Enabled = false;
            frm.btnSaveInvoice.Text = "Edit Order";

            // جلب معلومات الفاتورة من القريد فيو في الشاشة الأولى 
            frm.txtOrderID.Text = this.dgvAllOrdersList.CurrentRow.Cells[0].Value.ToString();
            frm.txtOrderDesc.Text = this.dgvAllOrdersList.CurrentRow.Cells[3].Value.ToString();
            frm.dtpOrderDate.Value = Convert.ToDateTime(this.dgvAllOrdersList.CurrentRow.Cells[1].Value);
            frm.txtCustName.Text = this.dgvAllOrdersList.CurrentRow.Cells[2].Value.ToString();

            // GetCustomerInfoByOrderID جلب معلومات العميل الذي عمل الفاتورة من خلال الاجراء المخزن
            frm.txtCustID.Text = order.GetCustomerInfoByOrderID(Convert.ToInt16(dgvAllOrdersList.CurrentRow.Cells[0].Value)).Rows[0][0].ToString();
            frm.txtCustPhone.Text = order.GetCustomerInfoByOrderID(Convert.ToInt16(dgvAllOrdersList.CurrentRow.Cells[0].Value)).Rows[0][3].ToString();
            frm.txtEmail.Text = order.GetCustomerInfoByOrderID(Convert.ToInt16(dgvAllOrdersList.CurrentRow.Cells[0].Value)).Rows[0][4].ToString();

            // جلب صورة العميل اللي عمل الفاتورة
            try  // عشان مايعطيني خطأ في حالة لم يكن للعميل صورة مخزنة في الداتابيز
            {
                byte[] img = (byte[])order.GetCustomerInfoByOrderID(Convert.ToInt16(dgvAllOrdersList.CurrentRow.Cells[0].Value)).Rows[0][3];
                MemoryStream ms = new MemoryStream(img);
                frm.picCust.Image = Image.FromStream(ms);
            }
            catch
            {

            }

            // وتعبئة القريدفيو GetOrderDetailsByOrderID  جلب تفاصيل المنتجات في الفاتورة بدلالة رقم الفاتورة من خلال الاجراء المخزن 
            frm.dgvProducts.DataSource = order.GetOrderDetailsByOrderID(Convert.ToInt16(this.dgvAllOrdersList.CurrentRow.Cells[0].Value));

            frm.state = "Edit";
            frm.ShowDialog();

            dgvAllOrdersList.DataSource = order.SearchOrders("");
        }
    }
}
