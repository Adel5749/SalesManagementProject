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
    public partial class FrmCustomersList : Form
    {
        CLS_Customers customer = new CLS_Customers();

        public FrmCustomersList()
        {
            InitializeComponent();
            
        }

        private void dgvCustomersList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomersList_Load(object sender, EventArgs e)
        {
            dgvCustomersList.DataSource= customer.GetAllCustomers();
            dgvCustomersList.Columns[0].Visible = false;
            dgvCustomersList.Columns[5].Visible = false;
        }
    }
}
