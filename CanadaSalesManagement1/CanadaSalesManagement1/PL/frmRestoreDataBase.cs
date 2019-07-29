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
using CanadaSalesManagement1.BL;

namespace CanadaSalesManagement1.PL
{
    public partial class frmRestoreDataBase : Form
    {
        CLS_BackUpAndRestore restoreDataBase = new CLS_BackUpAndRestore();

        public frmRestoreDataBase()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseRestoreFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileRestore.Text = ofd.FileName;
                btnRestoreDataBase.Enabled = true;
            }
        }

        private void btnRestoreDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileRestore.Text != string.Empty)
                {
                    restoreDataBase.RestoreDataBase(txtFileRestore.Text);
                    MessageBox.Show("DataBase has been restored successfully");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
