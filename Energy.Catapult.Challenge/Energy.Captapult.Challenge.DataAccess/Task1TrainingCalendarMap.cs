using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Task1TrainingCalendarMap
    {
        public DateTime DateTimeUtc { get; set; }
        public string SummerWinter { get; set; }
        public DateTime DateTimeLocal { get; set; }
        public int Year { get; set; }
        public int MonthNum { get; set; }
        public string MonthName { get; set; }
        public int WeekNumber { get; set; }
        public string DayOfWeek { get; set; }
        public int DayOfWeekNumber { get; set; }
        public string HourText { get; set; }
        public int HourNumber { get; set; }
        public int SettlementPeriod { get; set; }
        public DateTime TimeOfDayLocal { get; set; }
        public string BankHoliday { get; set; }
        public string WorkingDay { get; set; }
    }
}
