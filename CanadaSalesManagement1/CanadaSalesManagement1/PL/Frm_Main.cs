using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanadaSalesManagement1.PL
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login(this);
            frm.ShowDialog();
            
        }

        private void إضافةمنتوججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddEditProduct frm = new Frm_AddEditProduct();
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void إدارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Products frm = new Frm_Products();
            frm.ShowDialog();
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.ShowDialog();
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomers frm = new FrmCustomers();
            frm.ShowDialog();
        }

        private void إضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrders frm = new FrmOrders();
            frm.ShowDialog();
        }

        private void إدارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllOrders frm = new FrmAllOrders();
            frm.ShowDialog();
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList();
            frm.ShowDialog();
        }

        private void إنشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackUp frm = new FrmBackUp();
            frm.ShowDialog();
        }

        private void استعادةنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestoreDataBase frm = new frmRestoreDataBase();
            frm.ShowDialog();
        }

        private void إعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }
    }
}
