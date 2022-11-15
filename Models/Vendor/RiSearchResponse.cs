namespace UPAExternalAPI.Models.Vendor
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class RiSearchResponse
    {
        [JsonProperty("ri", Required = Required.Always)]
        public int Ri { get; set; }

        [JsonProperty("creation_date", Required = Required.Always)]
        public DateTimeOffset? CreationDate { get; set; }

        [JsonProperty("po", Required = Required.Always)]
        public int Po { get; set; }

        [JsonProperty("pr", Required = Required.Always)]
        public int Pr { get; set; }

        [JsonProperty("entity_id", Required = Required.Always)]
        public int EntityId { get; set; }

        [JsonProperty("entity_name", Required = Required.Always)]
        public string EntityName { get; set; }

        [JsonProperty("warehouse_id", Required = Required.Always)]
        public int WarehouseId { get; set; }

        [JsonProperty("warehouse_name", Required = Required.Always)]
        public string WarehouseName { get; set; }

        [JsonProperty("warehouse_address", Required = Required.Always)]
        public string WarehouseAddress { get; set; }
    }

}