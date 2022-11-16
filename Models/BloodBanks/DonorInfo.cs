using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class DonorInfo
    {
        [JsonProperty("donorCentralId", Required = Required.Always)]
        public long DonorCentralId { get; set; }

        [JsonProperty("donerId", Required = Required.Always)]
        public string DonerId { get; set; }

        [JsonProperty("idType", Required = Required.Always)]
        public string IdType { get; set; }

        [JsonProperty("regestrationEntity", Required = Required.Always)]
        public string RegestrationEntity { get; set; }

        [JsonProperty("bloodGroup", Required = Required.Always)]
        public string BloodGroup { get; set; }

        [JsonProperty("bloodRh", Required = Required.Always)]
        public string BloodRh { get; set; }

        [JsonProperty("firstName", Required = Required.Always)]
        public string FirstName { get; set; }

        [JsonProperty("middleName", Required = Required.Always)]
        public string MiddleName { get; set; }

        [JsonProperty("thirdName", Required = Required.Always)]
        public string ThirdName { get; set; }

        [JsonProperty("familyName", Required = Required.Always)]
        public string FamilyName { get; set; }

        [JsonProperty("birthDate", Required = Required.Always)]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("comment", Required = Required.Always)]
        public string Comment { get; set; }

        [JsonProperty("regestrationDate", Required = Required.Always)]
        public DateTimeOffset RegestrationDate { get; set; }

        [JsonProperty("isPermenantDeferral")]
        public int? IsPermenantDeferral { get; set; }

        [JsonProperty("permenantDeferralComment")]
        public string PermenantDeferralComment { get; set; }

        [JsonProperty("address", Required = Required.Always)]
        public string Address { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("gender", Required = Required.Always)]
        public string Gender { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("districtName")]
        public string DistrictName { get; set; }
    }
}