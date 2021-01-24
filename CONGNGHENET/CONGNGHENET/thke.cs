using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CONGNGHENET
{
    public class thke
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public DataSet dataset(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectString);
            DataSet ds = new DataSet("result");
            da.Fill(ds, "result");
            return ds;
        }
    }
}