using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace _3_tier2
{
    public class DAL
    {

        public DataTable Dholdname(string name)
        {
            DataTable dTable = new DataTable();
            using (SqlConnection con = new SqlConnection("Data source=.;Intial catalog=System Databases;integrated security=SSPI"))
            {
                {
                    using (SqlCommand cmd = new SqlCommand("select * from employee where emp_id=101" + name + "'"))
                    {
                        SqlDataAdapter dt = new SqlDataAdapter();
                        try
                        {
                            cmd.Connection = con;
                            con.Open();
                            dt.SelectCommand = cmd;


                            dt.Fill(dTable);

                            return dTable;
                        }
                        catch (Exception)
                        {
                            //     
                        }
                    }
                }
            }
        }
    }
}

