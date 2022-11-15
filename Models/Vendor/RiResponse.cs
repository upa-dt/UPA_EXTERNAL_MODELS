namespace UPAExternalAPI.Models.Vendor
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class RiResponse
    {
        [JsonProperty("code", Required = Required.DisallowNull)]
        public int Code { get; set; }

        [JsonProperty("msg", Required = Required.DisallowNull)]
        public string Msg { get; set; }

        [JsonProperty("inv_id", Required = Required.DisallowNull)]
        public int InvId { get; set; }
    }

}