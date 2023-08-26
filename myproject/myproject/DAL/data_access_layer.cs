using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace myproject.DAL
{
    class data_access_layer
    {
        SqlConnection con2;
        //connected to database 
        public data_access_layer(){
            con2 = new SqlConnection("server= DESKTOP-4SE332T;database = pos_full DB; integrated security =true");

        }
        //method to open database
        public void opendata()
        {
            if(con2.State != ConnectionState.Open)
            {
                con2.Open();
            }
        }
        //method to close database connection
        public void closedata()
        {
            if(con2.State == ConnectionState.Open)
            {
                con2.Close();
            }
        }
        //method to read data from database
        public DataTable selectdata(string storage_procedure,SqlParameter[] parm)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.CommandText = storage_procedure;
            sqlcom.Connection = con2;
            if(parm != null)
            {
                for(int i=0; i < parm.Length; i++)
                {
                    sqlcom.Parameters.Add(parm[i]);

                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        ///method to insert update delete from database
        public void executecommand(string storage_procedure,SqlParameter[] param)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.CommandText = storage_procedure;
            sqlcom.Connection = con2;
            if (param != null)
            {
                sqlcom.Parameters.AddRange(param);
            }
            sqlcom.ExecuteNonQuery();
        }
    }
}
