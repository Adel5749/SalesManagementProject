using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CanadaSalesManagement1.DAL;

namespace CanadaSalesManagement1.BL
{
    class CLS_Customers:DataAccessLayer
    {
        public DataTable GetAllCustomers()
        {
            DataTable dt = SelectData("GetAllCustomers", null);
            return dt;
        }

        public void AddCustemer(string firstName,string lastName,string tel,string email,byte[] img,string checkImage)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
            param[0].Value = firstName;

            param[1] = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
            param[1].Value = lastName;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("Email", SqlDbType.NVarChar, 50);
            param[3].Value = email;

            param[4] = new SqlParameter("@CustomerImage", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@CheckImage", SqlDbType.VarChar, 25);
            param[5].Value = checkImage;

            Open();
            ExecuteCommand("AddCustomer", param);
            Close();
        }

        public void UpdateCustomer(string firstName,string lastName,string tel,string email,byte[] img,string checkImage,int customerID)
        {
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
            param[0].Value = firstName;

            param[1] = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
            param[1].Value = lastName;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("Email", SqlDbType.NVarChar, 50);
            param[3].Value = email;

            param[4] = new SqlParameter("@CustomerImage", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@CheckImage", SqlDbType.VarChar, 25);
            param[5].Value = checkImage;

            param[6] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[6].Value = customerID;

            Open();
            ExecuteCommand("UpdateCustomer", param);
            Close();
        }

        public void DeleteCustomer(int customerID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[0].Value = customerID;

            Open();
            ExecuteCommand("DeleteCustomer", param);
            Close();
        }

        public DataTable SearchCustomers(string search)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@srch", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            DataTable dt = SelectData("SearchCustomers", param);
            return dt;
        }

    }
}
