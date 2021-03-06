﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
