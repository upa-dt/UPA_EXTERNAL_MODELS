using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class BloodDeferTypes
    {
        [JsonProperty("code", Required = Required.Always)]
        public int Code { get; set; }

        [JsonProperty("deferCode", Required = Required.Always)]
        public string DeferCode { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("deferStatus", Required = Required.Always)]
        public string DeferStatus { get; set; }

        [JsonProperty("deferDays")]
        public int? DeferDays { get; set; }

        [JsonProperty("isPermanent")]
        public int? IsPermanent { get; set; }

        [JsonProperty("logActive")]
        public string LogActive { get; set; }
    }
}
