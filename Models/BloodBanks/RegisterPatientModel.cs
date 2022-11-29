using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class RegisterPatientModel : RegisterDonorModel
    {
        /// <summary>
        /// (Required For Patient) Blood Group (Obtain List Of Values By Calling GetBloodGroup Action), Can be null if from 
        /// oral investigation the donor is defered before analysing his blood group to safe money  
        /// Later if the donor accepted and get his blood analyzed you should call registerDonorBloodInfo to add his blood Group and Rh
        /// Overriding Base Class (RegisterDonorModel) bloodGroup property to make it Required
        /// </summary>
        [JsonProperty("bloodGroup")]
        [Required]
        public override int? bloodGroup { get; set; }
        /// <summary>
        /// (Required For Patient) Blood Group (Obtain List Of Values By Calling GetBloodRh Action)Can be null if from 
        /// oral investigation the donor is defered before analysing his blood Rh to safe money 
        /// Later if the donor accepted and get his blood analyzed you should call registerDonorBloodInfo to add his blood Group and Rh
        /// Overriding Base Class (RegisterDonorModel) bloodRh property to make it Required
        /// </summary>
        [JsonProperty("bloodRh")]
        [Required]
        public override int? bloodRh { get; set; }

        /// <summary>
        /// Date Blood Has been transfered for this Patient
        /// </summary>
        [JsonProperty("transfusionDate")]
        [Required]
        public DateTime transfusionDate { get; set; }
    }
}
