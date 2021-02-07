namespace Energy.Catapult.Challenge.Azure.Functions.Domain.Model
{
    public class PvForecastRequestItem
    {
        public string dateTimeUTC { get; set; }
        public double temp_location3 { get; set; }
        public double temp_location6 { get; set; }
        public double temp_location2 { get; set; }
        public double temp_location4 { get; set; }
        public double temp_location5 { get; set; }
        public double temp_location1 { get; set; }
        public int solar_location3 { get; set; }
        public int solar_location6 { get; set; }
        public int solar_location2 { get; set; }
        public int solar_location4 { get; set; }
        public int solar_location5 { get; set; }
        public int solar_location1 { get; set; }
        public string summerWinter { get; set; }
        public string dateTimeLocal { get; set; }
        public int year { get; set; }
        public int monthNum { get; set; }
        public string monthName { get; set; }
        public int weekNumber { get; set; }
        public string dayOfWeek { get; set; }
        public int dayOfWeekNumber { get; set; }
        public int hourText { get; set; }
        public int hourNumber { get; set; }
        public int settlementPeriod { get; set; }
        public string bankHoliday { get; set; }
        public string workingDay { get; set; }
    }
}