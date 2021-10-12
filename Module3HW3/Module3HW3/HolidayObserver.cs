using System;

namespace Module3HW3
{
    public class HolidayObserver
    {
        private Subject _subject;
        private string _name;
        public HolidayObserver(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
        }

        public static Holidays CurrentHoliday { get; set; }
        public static string CurrentDate { get; set; }

        public void Attach()
        {
            _subject.EventHandler += Holidays;
        }

        public void Detach()
        {
            _subject.EventHandler -= Holidays;
        }

        private void Holidays(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[NEW MESSAGE] {CurrentDate} Dear {_name}, happy {CurrentHoliday}!");
            Console.ResetColor();
        }
    }
}
