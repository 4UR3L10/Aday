using System;
using System.Collections.Generic;
using System.Text;

namespace Aday_DA.Classes
{
    class Plan
    {
        Event[] Events;
        private string title;

        // Constructor.
        public Plan()
        {

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
    }
}
