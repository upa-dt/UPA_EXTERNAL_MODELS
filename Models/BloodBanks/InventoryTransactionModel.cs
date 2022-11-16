using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class InventoryTransactionModel
    {
        /// <summary>
        /// (Required) Transaction Type
        /// </summary>
        [JsonProperty("transactionType", Required = Required.Always)]
        [Required]
        public BloodTransactionTypeEnum transactionType { get; set; }
        /// <summary>
        /// (Required) Inventory Type
        /// </summary>
        [JsonProperty("inventoryType", Required = Required.Always)]
        [Required]
        public BloodInventoryTypeEnum inventoryType { get; set; }
        /// <summary>
        /// (Required) Blood Group (Obtain List Of Values By Calling GetBloodGroup Action)
        /// </summary>
        [JsonProperty("bloodGroup", Required = Required.Always)]
        [Required]
        public int bloodGroup { get; set; }
        /// <summary>
        /// (Required) Blood Group (Obtain List Of Values By Calling GetBloodRh Action)
        /// </summary>
        [JsonProperty("bloodRh", Required = Required.Always)]
        [Required]
        public int bloodRh { get; set; }
        /// <summary>
        /// (Required) Blood Form Type (Obtain List Of Values By Calling GetBloodFormTypes Action)
        /// </summary>
        [JsonProperty("bloodFormType", Required = Required.Always)]
        [Required]
        public int bloodFormType { get; set; }
        /// <summary>
        /// (Required) Bag Quantity
        /// </summary>
        [JsonProperty("bagQty", Required = Required.Always)]
        [Required]
        public uint bagQty { get; set; }
        /// <summary>
        /// (Required) Expire Date For This Transaction
        /// </summary>
        [JsonProperty("expireDate", Required = Required.Always)]
        [Required]
        public DateTime expireDate { get; set; }
        public bool IsValid()
        {
            return true;
        }
    }
}
