using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class DonorBloodInfo
    {
        [JsonProperty("donorCentralId", Required = Required.Always)]
        public long DonorCentralId { get; set; }
        [JsonProperty("bloodGroup", Required = Required.Always)]
        public string BloodGroup { get; set; }

        [JsonProperty("bloodRh", Required = Required.Always)]
        public string BloodRh { get; set; }

        /// <summary>
        /// List Of All Phenotypes for the Donor
        /// </summary>
        [JsonProperty("bloodPhenotype")]
        public List<int> bloodPhenotype { get; set; }



        [JsonProperty("recordDate", Required = Required.Always)]
        public DateTime RecordDate { get; set; }
    }
}
