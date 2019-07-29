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
    class CLS_Categories
    {
        DataAccessLayer dal = new DataAccessLayer();

        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            dt= dal.SelectData("GetAllCategories", null);
            return dt;
        }
    }
}
