using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Energy.Catapult.Challenge.Azure.Functions.Domain.Model
{

    public class PvForecastRequest
    {
        public IList<PvForecastRequestItem> data { get; set; }
    }
}