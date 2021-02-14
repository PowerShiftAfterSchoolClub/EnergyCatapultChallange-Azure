using System;
using System.Collections.Generic;

#nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class PvTrainSet0
    {
        public DateTime DateTimeUtc { get; set; }
        public double? RawIrradianceWm2 { get; set; }
        public double? RawPvPowerMw { get; set; }
        public double? RawPanelTempC { get; set; }
    }
}
