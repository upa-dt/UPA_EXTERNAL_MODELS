using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class DonorSearchResult
    {
        /// <summary>
        /// Information About the Donor
        /// This List Length is either 1 in case Donor Found or Zero If Not Founs
        /// </summary>
        [JsonProperty("info")]
        public List<DonorInfo> info { get; set; }
        /// <summary>
        /// List of this Donor Deferrals
        /// This list Can be Null when no defer has been added for this Donor or a long list of all deferrals recorded about him
        /// </summary>
        [JsonProperty("deferral")]
        public List<DonorDeferInfo> deferral { get; set; }
        /// <summary>
        /// List Of All Previous Blood Analysis Results
        /// </summary>
        [JsonProperty("bloodInfo")]
        public List<DonorBloodInfo> bloodInfo { get; set; }

        /// <summary>
        /// List Of All Previous Blood Transfusions
        /// </summary>
        [JsonProperty("transfusionHistory")]
        public List<TransfusionHistory> transfusionHistory { get; set; }

    }
}
