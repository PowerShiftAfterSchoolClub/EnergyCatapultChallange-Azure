using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Task1ForecastsPvandDemandRun1
    {
        public DateTime DateTimeUtc { get; set; }
        public double DemandMwnewModel { get; set; }
        public double DemandMwoldModel { get; set; }
        public double PvmwnewModel { get; set; }
        public double PvmwoldModel { get; set; }
        public double? PvmwnewModelCorrected { get; set; }
    }
}
