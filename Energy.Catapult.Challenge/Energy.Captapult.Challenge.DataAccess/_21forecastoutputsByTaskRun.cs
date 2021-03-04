using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class _21forecastoutputsByTaskRun
    {
        public int Id { get; set; }
        public DateTime DateTimeUtc { get; set; }
        public double ForecastDemandMw { get; set; }
        public double ForecastPv { get; set; }
        public string TaskName { get; set; }
        public int? Task { get; set; }
        public int? RunId { get; set; }
        public DateTime? RunTimeStamp { get; set; }
        public string PvforecastModelName { get; set; }
        public string DemandForecastModelName { get; set; }
        public string PvmodelGuid { get; set; }
        public string DemandModelGuid { get; set; }
    }
}
