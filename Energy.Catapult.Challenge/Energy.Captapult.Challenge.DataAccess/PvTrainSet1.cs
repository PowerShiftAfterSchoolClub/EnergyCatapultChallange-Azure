﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class PvTrainSet1
    {
        public DateTime Datetime { get; set; }
        public double? IrradianceWm2 { get; set; }
        public double? PvPowerMw { get; set; }
        public double? PanelTempC { get; set; }
    }
}
