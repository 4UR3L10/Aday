using System;
using System.Collections.Generic;
using System.Text;

namespace Aday_DA.Classes
{
    class Plan
    {
        //Event[] Events;
         
        private string title;
        public List<Event> arrLstEventProp = new List<Event>();

        // Constructor.
        public Plan(string title)
        {            
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
        /*
        public List<Event> ListInit()
        {
            //List<Event> arrLstEvent = new List<Event>();
            //return arrLstEvent;
        }
        */

        public void ListInitt()
        {
            //List<Event> arrLstEvent = new List<Event>();
        }
    }
}
