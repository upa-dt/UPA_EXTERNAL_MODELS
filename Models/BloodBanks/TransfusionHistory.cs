namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class TransfusionHistory
    {
        [JsonProperty("transfsion_id", Required = Required.Always)]
        public int TransfsionId { get; set; }

        [JsonProperty("donorCentralId", Required = Required.Always)]
        public int DonorCentralId { get; set; }

        [JsonProperty("bloodGroup", Required = Required.Always)]
        public string BloodGroup { get; set; }

        [JsonProperty("bloodRh", Required = Required.Always)]
        public string BloodRh { get; set; }

        [JsonProperty("transfusion_date", Required = Required.Always)]
        public DateTime TransfusionDate { get; set; }

        [JsonProperty("record_date", Required = Required.Always)]
        public DateTime RecordDate { get; set; }
    }
}
