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
    class CLS_BackUpAndRestore:DataAccessLayer
    {
        public void BackUpDataBase(string fileName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FileName", SqlDbType.NVarChar, 100);
            param[0].Value = fileName;

            Open();
            ExecuteCommand("BackUpDataBase", param);
            Close();
        }

        public void RestoreDataBase(string fileName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FileName", SqlDbType.NVarChar, 100);
            param[0].Value = fileName;

            Open();
            ExecuteCommand("RestoreDataBase", param);
            Close();
        }

    }
}
