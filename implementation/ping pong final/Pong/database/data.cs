using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Pong.database
{
    public class data
       {
		SqlConnection con;
        string query = null;

        public data(string qry)
        {
            query = qry;
            con = new SqlConnection("Data Source=DESKTOP-BHJFQRT;Initial Catalog=SUDOKO;Integrated Security=True");

        }

        public DataTable getdatatable()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {

                    return ds.Tables[0];
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int executequery()
        {
            SqlCommand sc = new SqlCommand(query, con);
            try
            {
                sc.Connection = con;
                sc.Connection.Open();
                return sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sc.Connection.State != ConnectionState.Closed)
                    sc.Connection.Close();
            }
        }
    }
}

