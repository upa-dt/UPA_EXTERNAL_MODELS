using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Inventory
{
    public class InventoryTransactionRequest
    {
        /// <summary>
        /// Parent Transaction ID
        /// The transaction from which the Qty will be initiated
        /// </summary>
        [JsonProperty("parentTransactionId")]
        public int parentTransactionId { get; set; }

        /// <summary>
        /// Source Custdy Type
        /// </summary>
        [JsonProperty("srcCustodyType")]
        public CustodyTypeEnum srcCustodyType { get; set; }
        /// <summary>
        /// Transaction Type
        /// </summary>
        [JsonProperty("transcationType")]
        public TransactionTypeEnum transcationType { get; set; }

        /// <summary>
        /// Destination Warehouse ID
        /// </summary>
        [JsonProperty("destWarehouseId")]
        public int? destWarehouseId { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("qty")]
        public int qty { get; set; }
        /// <summary>
        /// Bonus If Any
        /// </summary>
        [JsonProperty("bonus")]
        public int? bonus { get; set; }
    }


    public class InventoryInspectionRequest
    {
        /// <summary>
        /// Parent Transaction ID
        /// The transaction from which the Qty will be initiated
        /// </summary>
        [JsonProperty("parentTransactionId")]
        public int parentTransactionId { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("cur_qty")]
        public int cur_qty { get; set; }
    }
}
