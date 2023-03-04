using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Aday_DA.Classes
{
    class Global
    {
        public static MainController MainCntrllr;
        public static SqlConnection connectionVar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aurelio\Documents\GitHub\Aday\Aday-DA\Aday-DA\AdayDB.mdf;Integrated Security=True");

    }
}
