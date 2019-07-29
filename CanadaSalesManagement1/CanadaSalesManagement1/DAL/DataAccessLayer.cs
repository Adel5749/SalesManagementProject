using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CanadaSalesManagement1.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;

        // constructor for initializing the object
        public DataAccessLayer()
        {

            if (Properties.Settings.Default.Mode == "Server")
            {
                con = new SqlConnection("Server=" + Properties.Settings.Default.Server + ";Database=" + Properties.Settings.Default.DataBase +
                                    ";Integrated Security=False;User ID=" + Properties.Settings.Default.ID +
                                    ";Password=" + Properties.Settings.Default.Password);
            }
            else
            {
                con = new SqlConnection("Server=" + Properties.Settings.Default.Server + ";Database=" + Properties.Settings.Default.DataBase +
                                    ";Integrated Security=True");
            }
        }

        // Method to open connectino
        public void Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        // Method to close the connection
        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Method to Select Data From Database
        public DataTable SelectData(string storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = storedProcedure;

            if (param != null)
            {
               for(int i = 0; i < param.Length; i++)
                {
                    sqlCmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Method to insert, Update, Delate Data From Database
        public void ExecuteCommand(string storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storedProcedure;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();

        }

    }
}
