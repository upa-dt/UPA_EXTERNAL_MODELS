using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPA_EXTERNAL_MODELS.Models.Lookup;

namespace UPA_EXTERNAL_MODELS.Models.BloodBanks
{
    public class DistrictLookup : LookupBase
    {
        [JsonProperty("cityCode")]
        public int cityCode { get; set; }
    }
}
