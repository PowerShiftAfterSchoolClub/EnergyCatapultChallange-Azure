using System;
using System.Collections.Generic;

#nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Asset
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public string AssetType { get; set; }
        public string LocationName { get; set; }
        public decimal? LocationLatitude { get; set; }
        public decimal? LocationLongitude { get; set; }
        public decimal? CapacityMwh { get; set; }
        public decimal? PowerMw { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
