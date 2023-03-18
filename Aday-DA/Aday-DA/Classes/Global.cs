using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Aday_DA.Classes
{
    class Global
    {
        public static MainController MainCntrllr;
        public static SqlConnection connectionVar;
        public static bool flagLogin;
        public static bool flagMain;
        public static List<string[]> arrLstPlan = new List<string[]>();
    }
}
