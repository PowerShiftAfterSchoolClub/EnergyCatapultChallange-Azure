using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Assets
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
