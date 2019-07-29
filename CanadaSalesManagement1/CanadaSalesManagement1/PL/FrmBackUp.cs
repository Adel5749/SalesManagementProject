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
    public partial class FrmBackUp : Form
    {
        CLS_BackUpAndRestore backRestore = new CLS_BackUpAndRestore();

        public FrmBackUp()
        {
            InitializeComponent();
        }

        private void btnBrowseForlders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fbd.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFilePath.Text + "\\KhalidSaadani_SalesManagement_" + DateTime.Now.ToShortDateString().Replace('/', '-');
                backRestore.BackUpDataBase(fileName);
                MessageBox.Show("database was backed up successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
