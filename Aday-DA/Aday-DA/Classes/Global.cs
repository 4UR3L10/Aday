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
        public static List<Plan> arrLstPlans = new List<Plan>();

        public static List<String> GetOrderedPlanDates()
        {
            List<String> dates = new List<String>();
            bool found = false;

            // Load all the Existing Plan Dates.
            foreach (Plan plan in arrLstPlans)
            {
                foreach (String strDate in dates)
                {
                    if (plan.GetPlanDateYearFormatString().Equals(strDate))
                    {
                        found = true;
                    }
                }

                if(!found)
                {
                    dates.Add(plan.GetPlanDateYearFormatString());
                }

                found = false;
            }

            dates.Sort();
            
            return dates;
        }

        public static int GetPlanByDate(String formattedDate)
        {
            int counter = 0;

            // Load all the Existing Plan Dates.
            foreach (Plan plan in arrLstPlans)
            {
                if (plan.GetPlanDateYearFormatString().Equals(formattedDate))
                {
                    counter++;
                }           
            }

            return counter;
        }
    }
}
