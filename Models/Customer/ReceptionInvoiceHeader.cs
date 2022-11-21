using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace UPA_EXTERNAL_MODELS.Models.Customer
{
    public partial class ReceptionInvoiceHeader
    {
        [JsonProperty("ri")]
        public int Ri { get; set; }

        [JsonProperty("creation_date")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("exec_status_code")]
        public int ExecStatusCode { get; set; }

        [JsonProperty("exec_status_name")]
        public string ExecStatusName { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorId { get; set; }

        [JsonProperty("vendor_name")]
        public string VendorName { get; set; }

        [JsonProperty("userId_confirmed_delivery")]
        public int? UserIdConfirmedDelivery { get; set; }

        [JsonProperty("userInfo_confirmed_delivery")]
        public string UserInfoConfirmedDelivery { get; set; }

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("entity_name")]
        public string EntityName { get; set; }

        [JsonProperty("vendor_ref")]
        public string VendorRef { get; set; }

        [JsonProperty("mob_vendor_pilot_upload_user")]
        public int? MobVendorPilotUploadUser { get; set; }

        [JsonProperty("pr")]
        public int Pr { get; set; }

        [JsonProperty("po")]
        public int Po { get; set; }

        [JsonProperty("inv_version")]
        public int? InvVersion { get; set; }
    }
}
