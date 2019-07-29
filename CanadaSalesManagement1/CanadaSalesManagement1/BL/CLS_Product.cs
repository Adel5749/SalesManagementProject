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
    class CLS_Product : DataAccessLayer
    {
        public DataTable GetAllProducts()
        {
            DataTable dt= SelectData("GetAllProducts", null);
            return dt;
        }

        public DataTable SearchProducts(string srch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@srch", SqlDbType.NVarChar, 25);
            param[0].Value = srch;

            DataTable dt = SelectData("SearchProducts", param);
            return dt;
        }

        public DataTable VerifyProductID(string productID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = productID;

            DataTable dt = SelectData("VerifyProductID", param);
            return dt;
        }

        public void AddProduct(string Product_ID, string productName, int quantity, string price, byte[] img, int catID)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Product_ID", SqlDbType.VarChar, 25);
            param[0].Value = Product_ID;

            param[1] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50);
            param[1].Value = productName;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 25);
            param[3].Value = price;

            param[4] = new SqlParameter("@ProductImage", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@CatID", SqlDbType.Int);
            param[5].Value = catID;

            Open();
            ExecuteCommand("AddProduct", param);
            Close();
        }

        public void UpdateProduct(string Product_ID, string productName, int quantity, string price, byte[] img, int catID)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ProdID", SqlDbType.VarChar, 25);
            param[0].Value = Product_ID;

            param[1] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50);
            param[1].Value = productName;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 25);
            param[3].Value = price;

            param[4] = new SqlParameter("@ProductImage", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@CatID", SqlDbType.Int);
            param[5].Value = catID;

            Open();
            ExecuteCommand("UpdateProduct", param);
            Close();
        }

        public void DeleteProduct(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = id;

            Open();
            ExecuteCommand("DeleteProduct", param);
            Close();
        }

        public DataTable GetProductImage(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = id;

            DataTable dt= SelectData("GetProductImage", param);
            return dt;

        }

        public DataTable GetSingleProduct(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = id;

            DataTable dt = SelectData("GetSingleProduct", param);
            return dt;
        }

        
    }
}