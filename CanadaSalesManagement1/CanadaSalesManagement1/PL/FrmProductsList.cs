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
    public partial class FrmProductsList : Form
    {
        CLS_Product product = new CLS_Product();

        public FrmProductsList()
        {
            InitializeComponent();
            dgvProductsList.DataSource = product.GetAllProducts();
            dgvProductsList.Columns[4].Visible = false;
        }

        private void dgvProductsList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
