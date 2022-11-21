using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace UPA_EXTERNAL_MODELS.Models.Customer
{
    public partial class PrPoData
    {
        /// <summary>
        /// Purchase Request
        /// </summary>
        [JsonProperty("pr")]
        public int Pr { get; set; }
        /// <summary>
        /// Purchase order
        /// </summary>
        [JsonProperty("po")]
        public int Po { get; set; }

        [JsonProperty("po_date")]
        public DateTimeOffset PoDate { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorId { get; set; }

        [JsonProperty("vendor_name")]
        public string VendorName { get; set; }
    }
}
