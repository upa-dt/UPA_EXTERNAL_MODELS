using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class DonorDeferInfo
    {
        [JsonProperty("deferRecordDate", Required = Required.Always)]
        public DateTime DeferRecordDate { get; set; }

        [JsonProperty("deferringEntity", Required = Required.Always)]
        public string DeferringEntity { get; set; }

        [JsonProperty("donationDate")]
        public DateTime? DonationDate { get; set; }

        [JsonProperty("deferStartDate")]
        public DateTime? DeferStartDate { get; set; }

        [JsonProperty("deferEndDate")]
        public DateTime? DeferEndDate { get; set; }

        [JsonProperty("deferComment")]
        public string DeferComment { get; set; }

        [JsonProperty("deferCode")]
        public string DeferCode { get; set; }

        [JsonProperty("deferDescription")]
        public string DeferDescription { get; set; }

        [JsonProperty("deferStatus")]
        public string DeferStatus { get; set; }

        [JsonProperty("deferPeriodDays")]
        public int? DeferPeriodDays { get; set; }

        [JsonProperty("isPermanent")]
        public int IsPermanent { get; set; }

        [JsonProperty("deferLogActive")]
        public string DeferLogActive { get; set; }
    }
}