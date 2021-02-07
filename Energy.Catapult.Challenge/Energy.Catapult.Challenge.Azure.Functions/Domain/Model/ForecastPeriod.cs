using System;
using System.Collections.Generic;
using System.Text;

namespace Energy.Catapult.Challenge.Azure.Functions.Domain.Model
{
    public class ForecastPeriod
    {
        public string dataTimeUtc { get;  set; }
        public double value { get; set; }
    }
}
