using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class DonorSearchModel
    {
        /// <summary>
        /// (Required) ID Type (National ID =1 or Passport =2)
        /// </summary>
        [JsonProperty("idType", Required = Required.Always)]
        public IDTypeEnum idType { get; set; }
        /// <summary>
        /// (Required) Donor ID , Either National ID number of Passport Number 
        /// </summary>
        [JsonProperty("donerId", Required = Required.Always)]
        public string donerId { get; set; }

    }
}
