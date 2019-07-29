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
    public partial class FrmAddUser : Form
    {
        CLS_User user = new CLS_User();

        public void ClearBoxes()
        {
            txtUserID.Clear();
            txtUserFullName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbUserType.SelectedIndex = -1;
            txtUserID.Focus();
        }

        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == string.Empty && txtPassword.Text == string.Empty && 
                txtUserFullName.Text == string.Empty|| cmbUserType.Text==string.Empty)
            {
                MessageBox.Show("Fill all the boxes please");
                return;
            }

            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password are not copatible ");
                return;
            }

            if(btnSaveUser.Text=="Add User")
            {
                user.AddUser(txtUserID.Text, txtUserFullName.Text, txtPassword.Text, cmbUserType.Text);
                MessageBox.Show("Added Successfully");
            }

            else if(btnSaveUser.Text=="Edit User")
            {
                user.UpdateUser(txtUserID.Text, txtUserFullName.Text, txtPassword.Text, cmbUserType.Text);
                MessageBox.Show("Editted Successfully");
            }
            
            ClearBoxes();
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password are not copatible ");
                return;
            }
        }

        private void txtUserID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUserFullName.Focus();
            }
        }

        private void txtUserFullName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConfirmPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbUserType.Focus();
            }
        }
    }
}
