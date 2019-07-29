using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CanadaSalesManagement1.DAL;

namespace CanadaSalesManagement1.BL
{
    class CLS_User:DataAccessLayer
    {
        public DataTable Sp_Login(string id, string password)
        {
            DataAccessLayer dal = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@psw", SqlDbType.NVarChar, 50);
            param[1].Value = password;

            DataTable dt = new DataTable();
            dt=dal.SelectData("Sp_Login", param);
            return dt;
        }

        public DataTable SearchUsers(string srch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Srch", SqlDbType.NVarChar, 50);
            param[0].Value = srch;

            DataTable dt = SelectData("SearchUsers", param);
            return dt;
        }

        public void AddUser(string id, string fullName, string userPassword, string userType)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@FullName", SqlDbType.NVarChar, 50);
            param[1].Value = fullName;

            param[2] = new SqlParameter("@UserPassword", SqlDbType.VarChar, 50);
            param[2].Value = userPassword;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = userType;



            Open();
            ExecuteCommand("AddUser", param);
            Close();

        }

        public void UpdateUser(string id,string fullName,string userPassword,string userType)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@FullName", SqlDbType.NVarChar, 50);
            param[1].Value = fullName;

            param[2] = new SqlParameter("@UserPassword", SqlDbType.VarChar, 50);
            param[2].Value = userPassword;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = userType;

            Open();
            ExecuteCommand("UpdateUser", param);
            Close();
        }

        public void DeleteUser(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            Open();
            ExecuteCommand("DeleteUser", param);
            Close();
        }
    }
}
