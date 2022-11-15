using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Inventory
{

    public class InventorySearchRequest : RequestBase
    {
        /// <summary>
        /// warehouse ID 
        /// </summary>
        [JsonProperty("warehouseId")]
        public int warehouseId { get; set; }
        /// <summary>
        /// GTIN        
        /// </summary>
        [JsonProperty("gtin")]
        public string gtin { get; set; }
        /// <summary>
        /// Product Type (Drug, Device, Lab, Supply)
        /// </summary>
        [JsonProperty("productType")]
        public ProductTypeEnum productType { get; set; }

        /// <summary>
        /// نوع العهدة
        /// </summary>
        [JsonProperty("custodyType")]
        public CustodyTypeEnum? custdyType { get; set; }
    }
}
