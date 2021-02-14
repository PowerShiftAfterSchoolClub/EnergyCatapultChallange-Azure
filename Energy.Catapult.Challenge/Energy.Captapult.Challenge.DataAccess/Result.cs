using System;
using System.Collections.Generic;

#nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Result
    {
        public DateTime Datetime { get; set; }
        public double ChargeMw { get; set; }
        public int Task { get; set; }
        public int RunId { get; set; }
        public DateTime RunDateTime { get; set; }
        public int D { get; set; }
        public int K { get; set; }
        public double TaskForecastDemandMw { get; set; }
        public double TaskNetDemandMw { get; set; }
        public double TaskForecsatPvmw { get; set; }
        public double TaskBatteryNetMw { get; set; }
        public double TaksSoCmwh { get; set; }
        public double TaskBatteryDischargeMw { get; set; }
        public double TaskBatteryChargeMw { get; set; }
        public double TaskGridTopUpMw { get; set; }
        public double TaskChargePv { get; set; }
        public double TaskChargeGrid { get; set; }
    }
}
