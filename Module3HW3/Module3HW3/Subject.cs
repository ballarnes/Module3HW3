using System;

namespace Module3HW3
{
    public class Subject
    {
        public event EventHandler EventHandler;
        public void Notify()
        {
            if (EventHandler != null)
            {
                EventHandler(this, EventArgs.Empty);
            }
        }
    }
}
