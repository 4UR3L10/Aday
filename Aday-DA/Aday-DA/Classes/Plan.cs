using System;
using System.Collections.Generic;
using System.Text;

namespace Aday_DA.Classes
{
    class Plan
    {
        Event[] Events;
        public List<Event> arrLstEvent;
        private string title;

        // Constructor.
        public Plan(string title)
        {
            List<Event[]> arrLstEvent = new List<Event[]>();
            this.title = title;
        }

        // Getters.
        public string GetTitle()
        {
            return title;
        }

        // Setters.
        public void SetTitle(string title)
        {
            this.title = title;
        }

        // Testing.
        public List<Event> ListInit()
        {
            List<Event> arrLstEvent = new List<Event>();
            return arrLstEvent;
        }
    }
}
