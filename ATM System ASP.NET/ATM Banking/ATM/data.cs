using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ATM
{
    class data
    {
        public static string con = "data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;";
        SqlConnection con1 = new SqlConnection(con);
    }
}
