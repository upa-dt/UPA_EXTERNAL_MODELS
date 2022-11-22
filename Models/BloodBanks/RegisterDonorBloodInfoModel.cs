using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class RegisterDonorBloodInfoModel
    {
        /// <summary>
        /// (Mandatory) Central Id Of Blood Donor, Can be obtained after registering Donor 
        /// </summary>
        [JsonProperty("donorCentralId", Required = Required.Always)]
        [Required]
        [JsonRequired]
        public int donorCentralId { get; set; }
        /// <summary>
        /// (Mandatory) Blood Group (Obtain List Of Values By Calling GetBloodGroup Action)
        /// </summary>
        [JsonProperty("bloodGroup", Required = Required.Always)]
        [Required]
        [JsonRequired]
        public int bloodGroup { get; set; }
        /// <summary>
        /// (Mandatory) Blood Rh (Obtain List Of Values By Calling GetBloodRh Action) 
        /// </summary>
        [JsonProperty("bloodRh", Required = Required.Always)]
        [Required]
        [JsonRequired]
        public int bloodRh { get; set; }
    }
}
