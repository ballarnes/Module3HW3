using System;

namespace Module3HW3
{
    public class Starter
    {
        public void Run()
        {
            Subject subject = new Subject();

            var observer1 = new HolidayObserver("Ivan", subject);
            var observer2 = new HolidayObserver("Kate", subject);
            var observer3 = new HolidayObserver("Maria", subject);

            observer1.Attach();
            observer2.Attach();

            var date = DateTime.Now;

            for (var currentDate = date; currentDate < date.AddYears(1); currentDate = currentDate.AddDays(1))
            {
                Holidays currentHoliday = GetHoliday(currentDate.ToString("dd.MM"));
                if (currentHoliday != Holidays.TypicalDay)
                {
                    HolidayObserver.CurrentHoliday = currentHoliday;
                    HolidayObserver.CurrentDate = currentDate.ToString("dd.MM.yyyy");
                    if (currentHoliday == Holidays.NewYearsDay)
                    {
                        observer3.Attach();
                    }

                    subject.Notify();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"[EMPTY] {currentDate.ToString("dd.MM.yyyy")}");
                    Console.ResetColor();
                }
            }

            observer1.Detach();
            observer2.Detach();
            observer3.Detach();
        }

        private Holidays GetHoliday(string currentDate)
        {
            switch (currentDate)
            {
                case "01.01":
                    return Holidays.NewYearsDay;
                case "07.01":
                    return Holidays.OrthodoxChristmasDay;
                case "08.03":
                    return Holidays.InternationalWomensDay;
                case "02.05":
                    return Holidays.OrthodoxEaster;
                case "03.05":
                    return Holidays.LabourDay;
                case "09.05":
                    return Holidays.VictoryDay;
                case "20.06":
                    return Holidays.TrinityDay;
                case "28.06":
                    return Holidays.ConstitutionDay;
                case "24.08":
                    return Holidays.IndependenceDayofUkraine;
                case "14.10":
                    return Holidays.UkraineDefenderDay;
                default:
                    return Holidays.TypicalDay;
            }
        }
    }
}
