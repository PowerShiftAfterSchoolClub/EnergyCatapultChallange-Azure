using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Task2ForecastsPvandDemandRun1OptimiseByHand20210228
    {
        public DateTime? Datetime { get; set; }
        public float? ChargeMw { get; set; }
        public short? Task { get; set; }
        public short? RunId { get; set; }
        public DateTime? RunDateTime { get; set; }
        public short? D { get; set; }
        public short? K { get; set; }
        public float? TaskForecastDemandMw { get; set; }
        public float? TaskNetDemandMw { get; set; }
        public float? TaskForecsatPvmw { get; set; }
        public float? TaskBatteryNetMw { get; set; }
        public float? TaksSoCmwh { get; set; }
        public float? TaskBatteryDischargeMw { get; set; }
        public float? TaskBatteryChargeMw { get; set; }
        public float? TaskGridTopUpMw { get; set; }
        public float? TaskChargePv { get; set; }
        public float? TaskChargeGrid { get; set; }
    }
}
