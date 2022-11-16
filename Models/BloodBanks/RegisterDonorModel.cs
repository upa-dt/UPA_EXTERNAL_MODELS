using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class RegisterDonorModel
    {
        /// <summary>
        /// (Required) ID Type (National ID =1 or Passport =2)
        /// </summary>
        [JsonProperty("idType", Required = Required.Always)]
        [Required]
        public IDTypeEnum idType { get; set; }
        /// <summary>
        /// (Required) Donor ID , Either National ID number of Passport Number 
        /// </summary>
        [JsonProperty("donerId", Required = Required.Always)]
        [Required]
        public string donerId { get; set; }
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
        /// (Required) First Name
        /// </summary>
        [JsonProperty("firstName", Required = Required.Always)]
        [Required]
        public string firstName { get; set; }
        /// <summary>
        /// (Required) Middle Name
        /// </summary>
        [JsonProperty("middleName", Required = Required.Always)]
        [Required]
        public string middleName { get; set; }
        /// <summary>
        /// Third Name
        /// </summary>
        [JsonProperty("thirdName")]
        public string thirdName { get; set; }
        /// <summary>
        /// (Required) Family Name
        /// </summary>
        [JsonProperty("familyName", Required = Required.Always)]
        [Required]
        public string familyName { get; set; }
        /// <summary>
        /// (Required) Birth Date
        /// </summary>
        [JsonProperty("birthDate", Required = Required.Always)]
        [Required]
        public DateTime birthDate { get; set; }
        /// <summary>
        /// (Required) Address
        /// </summary>
        [JsonProperty("address", Required = Required.Always)]
        [Required]
        public string address { get; set; }
        /// <summary>
        /// Phone Number
        /// </summary>
        [JsonProperty("phone")]
        [Required]
        //[StringLength(4, ErrorMessage = "The ThumbnailPhotoFileName value cannot exceed 4 characters. ")]
        public string phone { get; set; }
        /// <summary>
        /// (Required) Gender (Male = 1, Female = 2)
        /// </summary>
        [JsonProperty("gender", Required = Required.Always)]
        [Required]
        public GenderEnum gender { get; set; }
        /// <summary>
        /// (Required) Donor Profession (Obtain List Of Values By Calling GetProfessions Action)
        /// </summary>
        [JsonProperty("profession", Required = Required.Always)]
        [Required]
        public int profession { get; set; }
        /// <summary>
        /// (Required) Country ID (Obtain List Of Values By Calling GetCountries Action)
        /// </summary>
        [JsonProperty("countryId", Required = Required.Always)]
        [Required]
        public int countryId { get; set; }
        /// <summary>
        /// State ID (Obtain List Of Values By Calling GetCities Action)
        /// State (If Provided) Must Belong to its Country
        /// </summary>
        [JsonProperty("cityId")]
        public int? cityId { get; set; }
        /// <summary>
        /// City ID (Obtain List Of Values By Calling GetDestricts Action)
        /// City (If Provided) Must Belong to its State which Must Belong to its Country
        /// </summary>
        [JsonProperty("districtId")]
        public int? districtId { get; set; }
        /// <summary>
        /// Optional Comment about the donor
        /// </summary>
        [JsonProperty("comment")]
        public string comment { get; set; }
    }
}
