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
using CanadaSalesManagement1.PL;

namespace CanadaSalesManagement1.PL
{
    public partial class frmUsersList : Form
    {
        CLS_User user = new CLS_User();

        public frmUsersList()
        {
            InitializeComponent();
            dgvAllUsersList.DataSource = user.SearchUsers("");
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.btnSaveUser.Text = "Add User";
            frm.ShowDialog();
            // بعد عملية الإضافة في شاشة الإضافة والرجوع إلى شاشة إدارة المستخدمين نجعل القريد فيو تستعرض جميع الجدول
            dgvAllUsersList.DataSource = user.SearchUsers("");
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.btnSaveUser.Text = "Edit User";
            frm.txtUserID.Text = dgvAllUsersList.CurrentRow.Cells[0].Value.ToString();
            frm.txtUserFullName.Text = dgvAllUsersList.CurrentRow.Cells[1].Value.ToString();
            frm.txtPassword.Text = dgvAllUsersList.CurrentRow.Cells[2].Value.ToString();
            frm.txtConfirmPassword.Text = dgvAllUsersList.CurrentRow.Cells[2].Value.ToString();
            frm.cmbUserType.Text = dgvAllUsersList.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
            // بعد عملية الإضافة في شاشة الإضافة والرجوع إلى شاشة إدارة المستخدمين نجعل القريد فيو تستعرض جميع الجدول
            dgvAllUsersList.DataSource = user.SearchUsers("");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Do U want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                user.DeleteUser(dgvAllUsersList.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted Successfully");
                dgvAllUsersList.DataSource = user.SearchUsers("");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAllUsersList.DataSource = user.SearchUsers(txtSearch.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
