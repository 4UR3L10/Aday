using System;
using System.Collections.Generic;
using System.Text;

namespace Aday_DA.Classes
{
    class Event
    {
        private string title;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private DateTime reminder;
        private string location;
        private string description;
        bool isHighImportance;
        bool isAllDay;
        

        // Constructor.
        public Event()
        {

        }

        // Getters.
        public string GetTitle()
        {
            return title;
        }

        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }

        public DateTime GetEndDateTime()
        {
            return endDateTime;
        }

        public DateTime GetReminder()
        {
            return reminder;
        }

        public string GetLlocation()
        {
            return location;
        }

        public string GetDescription()
        {
            return description;
        }

        // Setters.
        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetStartDateTime(DateTime startDateTime)
        {
            this.startDateTime = startDateTime;
        }

        public void SetEndDateTime(DateTime endDateTime)
        {
            this.endDateTime = endDateTime;
        }

        public void SetReminder(DateTime reminder)
        {
            this.reminder = reminder;
        }

        public void SetLocation(string location)
        {
            this.location = location;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }
}
