using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong.database;

using System.Data;
namespace Pong.Module
{
    public class Validation
    {


        public bool checkcredentials(string uname, string password)
        {
            string query = "select * from usertbl where username='" + uname + "' and password='" + password + "'";
            data d = new data(query);
            try
            {
                DataTable dt = d.getdatatable();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }


        }

        public bool checkemail(String email)
        {
            if(email.Contains("@") && (email.Contains(".com")))
                {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
