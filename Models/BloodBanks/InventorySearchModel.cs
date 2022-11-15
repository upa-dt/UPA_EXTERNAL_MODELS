using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPAExternalAPI.Models.BloodBanks
{
    public class InventorySearchModel
    {
        /// <summary>
        /// Inventory Type Filter, Null Means Don't Care About this Filter
        /// </summary>
        [JsonProperty("inventoryType")]
        public BloodInventoryTypeEnum? inventoryType { get; set; }
        /// <summary>
        /// Blood Group Filter (Obtain List Of Values By Calling GetBloodGroup Action)
        ///  Null Means Don't Care About this Filter
        /// </summary>
        [JsonProperty("bloodGroup")]
        public int? bloodGroup { get; set; }
        /// <summary>
        /// Blood Group Filter (Obtain List Of Values By Calling GetBloodRh Action)
        ///  Null Means Don't Care About this Filter
        /// </summary>
        [JsonProperty("bloodRh")]
        public int? bloodRh { get; set; }
        /// <summary>
        /// Blood Form Type Filter (Obtain List Of Values By Calling GetBloodFormTypes Action)
        ///  Null Means Don't Care About this Filter
        /// </summary>
        [JsonProperty("bloodFormType")]
        public int? bloodFormType { get; set; }

        /// <summary>
        /// Search For Inventory Before Or Equal this Date, Null Means Don't Care About this Filter
        /// </summary>
        [JsonProperty("fromExpireDate")]
        public DateTime? fromExpireDate { get; set; }
        /// <summary>
        /// Search For Inventory After Or Equal this Date, Null Means Don't Care About this Filter
        /// </summary>
        [JsonProperty("toExpireDate")]
        public DateTime? toExpireDate { get; set; }

    }
}
