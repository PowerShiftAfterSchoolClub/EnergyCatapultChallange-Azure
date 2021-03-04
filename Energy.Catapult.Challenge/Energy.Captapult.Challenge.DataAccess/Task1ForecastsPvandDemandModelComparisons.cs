using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Task1ForecastsPvandDemandModelComparisons
    {
        public DateTime DateTimeUtc { get; set; }
        public double ForeDemandMwtask1Model { get; set; }
        public double ForeDemandMwtask0Model { get; set; }
        public double ForeDemandMwtask2Model { get; set; }
        public double ForePvmwtask1Model { get; set; }
        public double ForePvmwtask0Model { get; set; }
        public double ForePvmwtask2Model { get; set; }
    }
}
