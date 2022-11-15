
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UPA_EXTERNAL_MODELS.Models.Common
{
    public class RiItemsData
    {
        [Required(ErrorMessage = "Please input Reception Invoice ID")]
        [JsonProperty("riId")]
        public int InvoiceID { get; set; }

        [Description("List Reception Invoice Items That Has Been Refused, All Other Items which is not here will be considered accepted, Null value means all RI is Accepted")]
        [JsonProperty("refusedItems")]
        public List<int> RefusedItems { get; set; }

        //[Description("Delivery Client DateTime")]
        //[JsonProperty("deliveryDate")]
        //public DateTime? DeliveryDate { get; set; }

        //[Required(ErrorMessage = "Please upload RI file")]
        [JsonProperty("files")]
        //[RiFileValidationAttribute(2)]//   Minimum 2 FIles
        public IFormFile[] Files { get; set; }
    }
    public class RiBulkInitialReception
    {
        /// <summary>
        /// Flag for Either Accept (true) or Reject (false)
        /// </summary>
        [Required(ErrorMessage = "Please Proivede If Accepted (true) or Refused (false)")]
        [JsonProperty("isAccept")]
        public bool isAccept { get; set; }

        /// <summary>
        /// List of Reception Invoice ID for Either Full Accept or Reject
        /// List Maximum Length is 100 Item Per time
        /// </summary>
        public List<int> Items { get; set; }
    }
}
