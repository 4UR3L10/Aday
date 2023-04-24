using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

using Microsoft.Toolkit.Uwp.Notifications;

namespace Aday_DA.Classes
{
    class Global
    {
        public static MainController MainCntrllr;
        public static SqlConnection connectionVar;
        public static bool flagLogin;
        public static bool flagMain;       
        public static List<Plan> arrLstPlans = new List<Plan>();
        public static List<Event> arrLstEventConflict = new List<Event>();

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

        public static void CheckEventStart()
        {
            // CHeck Every Second for an event begin time notification.
            if (Global.arrLstPlans.Count > 0)
            {
                foreach (Plan plan in Global.arrLstPlans)
                {
                    if (plan.GetPlanDate().Date == DateTime.Now.Date)
                    { 
                        if (plan.arrLstEventProp.Count > 0)
                        {
                            foreach (Event evnt in plan.arrLstEventProp)
                            {
                                DateTime eventStartTime = evnt.GetStartDateTime();
                                DateTime currentTime = DateTime.Now;
                                TimeSpan ts = currentTime - eventStartTime;
                                //Console.WriteLine("No. of Minutes (Difference) = {0}", ts.TotalMinutes);
                                //if (evnt.GetStartDateTime().ToString() == DateTime.Now.ToString())
                                Console.WriteLine("No. of Minutes (Difference) = {0}", ts.TotalMinutes);
                                if (ts.TotalMinutes <= 1 && ts.TotalMinutes > 0)
                                {
                                    string dirName = AppDomain.CurrentDomain.BaseDirectory; // Starting Dir
                                    FileInfo fileInfo = new FileInfo(dirName);
                                    DirectoryInfo parentDir = fileInfo.Directory.Parent;
                                    string parentDirName = parentDir.FullName; // Parent of Starting Dir
                                    string dirName2 = parentDirName;
                                    FileInfo fileInfo2 = new FileInfo(dirName2);
                                    DirectoryInfo parentDir2 = fileInfo2.Directory.Parent;
                                    string parentDirName2 = parentDir2.FullName;
                                    string path = parentDirName2 + @"\Resources\Aday.ico";

                                    new ToastContentBuilder()
                                    .AddArgument("action", "viewConversation")
                                    .AddArgument("conversationId", 9813)    
                                    .AddText("Event Started")
                                    .AddText("The following event:" + evnt.GetTitle() + " for today " + DateTime.Now.ToString() + " on plan " + plan.GetTitle() + " just started.")
                                    .AddAppLogoOverride(new Uri("file:///" + path, UriKind.Absolute), ToastGenericAppLogoCrop.Circle)
                                    .AddInputTextBox("tbReply", placeHolderContent: "Type a response")
                                    .AddButton(new ToastButton()
                                    .SetContent("Dismiss")
                                    .AddArgument("action", "like")
                                    .SetBackgroundActivation())
                                    .Show();
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void CheckEventConflict()
        {
            // CHeck Every Second for an event begin time notification.
            if (Global.arrLstPlans.Count > 0)
            {
                foreach (Plan plan in Global.arrLstPlans)
                {
                    if (plan.GetPlanDate().Date == DateTime.Now.Date)
                    {
                        if (plan.arrLstEventProp.Count > 0)
                        {
                            foreach (Event evnt in plan.arrLstEventProp)
                            {
                                if (evnt.GetStartDateTime() <= DateTime.Now && DateTime.Now <= evnt.GetEndDateTime())
                                {
                                    bool found = false;
                                    foreach (Event evntt in arrLstEventConflict)
                                    {
                                        if(evntt.GetTitle().Equals(evnt.GetTitle()))
                                        {
                                            found = true;
                                        }
                                    }
                                    if(!found)
                                    {
                                        arrLstEventConflict.Add(evnt);
                                    }                                    
                                }
                            }
                        }
                    }
                }
            }

            if(arrLstEventConflict.Count > 1)
            {
                string dirName = AppDomain.CurrentDomain.BaseDirectory; // Starting Dir
                FileInfo fileInfo = new FileInfo(dirName);
                DirectoryInfo parentDir = fileInfo.Directory.Parent;
                string parentDirName = parentDir.FullName; // Parent of Starting Dir
                string dirName2 = parentDirName;
                FileInfo fileInfo2 = new FileInfo(dirName2);
                DirectoryInfo parentDir2 = fileInfo2.Directory.Parent;
                string parentDirName2 = parentDir2.FullName;
                string path = parentDirName2 + @"\Resources\clipart684108.png";

                new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Event Started")
                .AddText("There are events that conflicts one another at this time.")
                .AddAppLogoOverride(new Uri("file:///" + path, UriKind.Absolute), ToastGenericAppLogoCrop.Circle)
                .AddInputTextBox("tbReply", placeHolderContent: "Type a response")
                .AddButton(new ToastButton()
                .SetContent("Dismiss")
                .AddArgument("action", "like")
                .SetBackgroundActivation())
                .Show();

                Form_Conflict conflict = new Form_Conflict();
                conflict.Show();
            }
        }

        public static void WriteToDataFile()
        {
            // Open the text file and write the data to it
            using (StreamWriter writer = new StreamWriter("data.txt", false))
            {
                // If plans exists.
                if (Global.arrLstPlans.Count > 0)
                {
                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        writer.WriteLine("@P@" + plan.GetTitle() + "&&&" + plan.GetPlanDate());

                        if (plan.arrLstEventProp.Count > 0)
                        {
                            foreach (Event evnt in plan.arrLstEventProp)
                            {
                                writer.WriteLine("@E@" + evnt.GetTitle() + "&&&" + evnt.GetStartDateTime() + "&&&" + evnt.GetEndDateTime() + "&&&" + evnt.GetLlocation() + "&&&" + evnt.GetDescription() + "&&&" + evnt.isHighImportance + "&&&" + evnt.isAllDay);
                            }
                        }
                    }
                }
            }
        }

        public static void ReadDataFromFile()
        {
            // Open the text file using a StreamReader
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                // Read the contents of the text file line by line
                string line;
                DateTime varDateTime;
                DateTime startDateTime;
                DateTime endDateTime;
                bool isHighImportance;
                bool isAllDay;

                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into components based on the space character
                    string[] components = line.Split("&&&");

                    // Reading a plan.
                    if (components[0].Contains("@P@"))
                    {
                        components[0] = components[0].Replace("@P@", "");

                        // Parse the second component of the line as a DateTime and call the GetStartDateTime method of the evnt class.        
                        if (DateTime.TryParse(components[1], out varDateTime))
                        {
                            /*Create a new plan - CHANGE THE PARAMETERS TO THE ONES YOU ARE READING FROM THE FILE*/
                            Plan planobj = new Plan(components[0], varDateTime);

                            /*Add a plan to the list of plans. */
                            Global.arrLstPlans.Add(planobj);
                        }
                    }

                    // Reading a Event.
                    if (components[0].Contains("@E@"))
                    {
                        components[0] = components[0].Replace("@E@", ""); // Event Title.
                        if (DateTime.TryParse(components[1], out startDateTime))
                        {
                            if (DateTime.TryParse(components[2], out endDateTime))
                            {
                                isHighImportance = Convert.ToBoolean(components[5]);
                                isAllDay = Convert.ToBoolean(components[6]);

                                Event userEventObj = new Event(components[0], startDateTime, endDateTime, components[3], components[4]);
                                userEventObj.isHighImportance = isHighImportance;
                                userEventObj.isAllDay = isAllDay;
                                Global.arrLstPlans[Global.arrLstPlans.Count - 1].arrLstEventProp.Add(userEventObj);
                            }
                        }
                    }
                }
            }

        }
    }
}
