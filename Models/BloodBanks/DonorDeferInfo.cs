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
        public DateTimeOffset DeferRecordDate { get; set; }

        [JsonProperty("deferringEntity", Required = Required.Always)]
        public string DeferringEntity { get; set; }

        [JsonProperty("donationDate", Required = Required.Always)]
        public DateTimeOffset DonationDate { get; set; }

        [JsonProperty("deferStartDate", Required = Required.Always)]
        public DateTimeOffset DeferStartDate { get; set; }

        [JsonProperty("deferEndDate", Required = Required.Always)]
        public DateTimeOffset DeferEndDate { get; set; }

        [JsonProperty("deferComment", Required = Required.Always)]
        public string DeferComment { get; set; }

        [JsonProperty("deferCode", Required = Required.Always)]
        public string DeferCode { get; set; }

        [JsonProperty("deferDescription", Required = Required.Always)]
        public string DeferDescription { get; set; }

        [JsonProperty("deferStatus", Required = Required.Always)]
        public string DeferStatus { get; set; }

        [JsonProperty("deferPeriodDays", Required = Required.AllowNull)]
        public object DeferPeriodDays { get; set; }

        [JsonProperty("isPermanent", Required = Required.Always)]
        public long IsPermanent { get; set; }

        [JsonProperty("deferLogActive", Required = Required.Always)]
        public string DeferLogActive { get; set; }
    }
}