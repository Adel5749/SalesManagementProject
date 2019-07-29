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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();

            // الفكرة إنه ما تنفتح الشاشة تعطينا بيانات الاتصال بالسيرفر القديمة ، 
            // وهذه القيم مأخوذة من صفحة خصائص البروجكت
            // وكل ماعلينا فعله هو التأكد وتعديلها إذا لزم 
            // وعند الضغط على زر حفظ يقوم بتعديل القيم الجديدة في صفحة خصائص البروجكت
            txtServer.Text = Properties.Settings.Default.Server;
            txtDataBase.Text = Properties.Settings.Default.DataBase;
            if (Properties.Settings.Default.Mode == "Server")
            {
                rdoServerAuthentication.Checked = true;
                txtUserID.Text = Properties.Settings.Default.ID;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rdoWindowsAuthentication.Checked = true;
                txtUserID.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtUserID.Clear();
                txtPassword.Clear();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSaveSettings_Click(object sender, EventArgs e)
        {
            //  المفترض أول مانركب البرنامج عند أي عميل ندخل إلى هذه الشاشة 
            // ConnectionStringوندخل بيانات الاتصال بالسيرفر لحفظها في 
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.DataBase = txtDataBase.Text;
            Properties.Settings.Default.Mode =rdoServerAuthentication.Checked==true ? "Server" : "Windows";
            Properties.Settings.Default.ID= txtUserID.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings are saved successfulyy");
        }

        private void rdoServerAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtUserID.ReadOnly = false;
            txtPassword.ReadOnly = false;
        }

        private void rdoWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtUserID.ReadOnly = true;
            txtPassword.ReadOnly = true;
        }
    }
}
