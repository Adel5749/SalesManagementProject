using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanadaSalesManagement1.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CanadaSalesManagement1.BL
{
    class CLS_Orders:DataAccessLayer
    {
        public DataTable GetNewOrderID()
        {
            DataTable dt= SelectData("GetNewOrderID", null);
            return dt;
        }

        public DataTable GetLastOrderID()
        {
            DataTable dt = SelectData("GetLastOrderID", null);
            return dt;
        }

        public void AddOrder(int orderID, DateTime orderDate, int customerID, string orderDescription,string SalesMan)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = orderID;

            param[1] = new SqlParameter("@OrderDate", SqlDbType.DateTime);
            param[1].Value = orderDate;

            param[2] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[2].Value = customerID;

            param[3] = new SqlParameter("@OrderDescription", SqlDbType.NVarChar, 250);
            param[3].Value = orderDescription;

            param[4] = new SqlParameter("@SalesMan", SqlDbType.VarChar, 50);
            param[4].Value = SalesMan;

            Open();
            ExecuteCommand("AddOrder", param);
            Close();
        }

        public void AddOrderDetails(int orderID,string productID, int quantity, string price,
                                    double discount, string amount, string totalAmount)

        {
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = orderID;

            param[1] = new SqlParameter("@ProductID", SqlDbType.VarChar,25);
            param[1].Value = productID;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@Discount", SqlDbType.Float);
            param[4].Value = discount;


            param[5] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            param[5].Value = amount;

            param[6] = new SqlParameter("@TotalAmount", SqlDbType.VarChar, 50);
            param[6].Value = totalAmount;

            Open();
            ExecuteCommand("AddOrderDetails", param);
            Close();
        }

        public DataTable VerifyProdQuantity(string productID, int quantityEntered)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ProdID", SqlDbType.VarChar, 25);
            param[0].Value = productID;

            param[1] = new SqlParameter("@QuantityEntered", SqlDbType.Int);
            param[1].Value = quantityEntered;

            DataTable dt = SelectData("VerifyProdQuantity", param);
            return dt;
        }

        public DataTable GetOrderDetailsByOrderID(int orderID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = orderID;

            DataTable dt = SelectData("GetOrderDetailsByOrderID", param);
            return dt;
        }

        public DataTable SearchOrders(string srch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Srch", SqlDbType.NVarChar, 50);
            param[0].Value = srch;

            DataTable dt = SelectData("SearchOrders", param);
            return dt;
        }

        // Get client information who made the invoice
        public DataTable GetCustomerInfoByOrderID(int orderId)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@OrderID", SqlDbType.SmallInt);
            param[0].Value = orderId;
            DataTable dt = SelectData("GetCustomerInfoByOrderID", param);
            return dt;
        }

    }
}
