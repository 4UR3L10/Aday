using System;
using System.Collections.Generic;
using System.Text;

namespace Aday_DA.Classes
{
    class Plan
    {         
        private string title;
        private DateTime planDate;
        public List<Event> arrLstEventProp = new List<Event>();

        // Constructor.
        public Plan(string title, DateTime planDate)
        {            
            this.title = title;
            this.planDate = planDate;
        }

        // Getters.
        public string GetTitle()
        {
            return title;
        }

        public DateTime GetPlanDate()
        {
            return planDate;
        }

        public String GetPlanDateString()
        {
            return planDate.Date.ToString();
        }

        public String GetPlanDateYearFormatString()
        {
            string[] dateFormats = planDate.Date.GetDateTimeFormats();          
            return dateFormats[5];
        }

        // Setters.
        public void SetTitle(string title)
        {
            this.title = title;
        }
            
        public void SetPlanDate(DateTime planDate)
        {
            this.planDate = planDate;
        }
    }
}