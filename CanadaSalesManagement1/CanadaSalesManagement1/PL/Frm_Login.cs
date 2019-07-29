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

namespace CanadaSalesManagement1.PL
{
    public partial class Frm_Login : Form
    {
        CLS_User user = new CLS_User();

        public Frm_Login()
        {
            InitializeComponent();
        }

        Frm_Main myFrm;
        public Frm_Login(Frm_Main frmMain)
        {
            InitializeComponent();
            myFrm = frmMain;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= user.Sp_Login(txtID.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][3].ToString() == "Manager")
                {
                    myFrm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    myFrm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    myFrm.الأصنافToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالأصنافToolStripMenuItem.Enabled = true;
                    myFrm.إضافةصنفجديدToolStripMenuItem.Enabled = true;
                    myFrm.إضافةمنتوججديدToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالمنتوجاتToolStripMenuItem.Enabled = true;
                    myFrm.إضافةبيعجديدToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالمبيعاتToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالعملاءToolStripMenuItem.Enabled = true;
                    myFrm.إضافةعميلجديدToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالمستخدمينToolStripMenuItem.Enabled = true;
                    myFrm.إضافةمستخدمجديدToolStripMenuItem.Enabled = true;
                    Program.salesMan = dt.Rows[0]["FullName"].ToString();
                    this.Close();
                }
                if (dt.Rows[0][3].ToString() == "User")
                {
                    myFrm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    myFrm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    myFrm.الأصنافToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالأصنافToolStripMenuItem.Enabled = true;
                    myFrm.إضافةصنفجديدToolStripMenuItem.Enabled = true;
                    myFrm.إضافةمنتوججديدToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالمنتوجاتToolStripMenuItem.Enabled = true;
                    myFrm.إضافةبيعجديدToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالمبيعاتToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالعملاءToolStripMenuItem.Enabled = true;
                    myFrm.إضافةعميلجديدToolStripMenuItem.Enabled = true;
                    myFrm.إدارةالمستخدمينToolStripMenuItem.Enabled = false;
                    myFrm.إضافةمستخدمجديدToolStripMenuItem.Enabled = false;
                    Program.salesMan = dt.Rows[0]["FullName"].ToString();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtID.Text = "Adel";
            txtPassword.Text = "123";
        }
    }
}
