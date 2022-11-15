using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPAExternalAPI.Models.BloodBanks
{
    public class InventoryRecord
    {
        [JsonProperty("inventoryTypeNameCode", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public int InventoryTypeNameCode { get; set; }

        [JsonProperty("inventoryTypeName", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public string InventoryTypeName { get; set; }

        [JsonProperty("bloodFormTypeCode", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public int BloodFormTypeCode { get; set; }

        [JsonProperty("bloodFormTypeName", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public string BloodFormTypeName { get; set; }

        [JsonProperty("bloodGroup", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public string BloodGroup { get; set; }

        [JsonProperty("bloodRh", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public string BloodRh { get; set; }

        [JsonProperty("bag_qty", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public int BagQty { get; set; }

        [JsonProperty("expiry_date", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public DateTimeOffset? ExpiryDate { get; set; }

        [JsonProperty("last_update_date", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        public DateTimeOffset? LastUpdateDate { get; set; }
    }
}