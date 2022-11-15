using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.Vendor
{
    public class RiReceiveResponse
    {
        [JsonProperty("accepted")]
        public List<long> Accepted { get; set; }

        [JsonProperty("refused")]
        public List<long> Refused { get; set; }
    }
}
