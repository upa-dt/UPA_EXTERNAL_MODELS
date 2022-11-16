using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPAExternalAPI.Models.BloodBanks
{
    public class DeferralModel
    {
        /// <summary>
        /// (Required) Central Id Of Blood Donor
        /// </summary>
        [JsonProperty("donorCentralId", Required = Required.Always)]
        [Required]
        public int donorCentralId { get; set; }
        /// <summary>
        /// (Required) Deferral ID  (Obtain List Of Values By Calling GetDeferral Action)
        /// </summary>
        [JsonProperty("deferId", Required = Required.Always)]
        [Required]
        public int deferId { get; set; }
        /// <summary>
        /// (Required) Latest Donation Date
        /// </summary>
        [JsonProperty("donationDate", Required = Required.Always)]
        public DateTime? donationDate { get; set; }
        /// <summary>
        /// (Required) Deferral Starting Date
        /// </summary>
        [JsonProperty("deferStartDate", Required = Required.Always)]
        [Required]
        public DateTime deferStartDate { get; set; }
        /// <summary>
        /// Deferral Ending Date, Null value Means Forever (Permanent)
        /// </summary>
        [JsonProperty("deferEndDate")]
        public DateTime? deferEndDate { get; set; }

        /// <summary>
        /// Optional Comment about the deferral
        /// </summary>
        [JsonProperty("comment")]
        public string comment { get; set; }
        public bool IsValid()
        {
            if (deferEndDate != null && deferEndDate < deferStartDate)
                return false;
            return true;
        }
    }
}
