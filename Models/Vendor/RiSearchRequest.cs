namespace UPAExternalAPI.Models.Vendor
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class RiSearchRequest : RequestBase
    {
        /// <summary>
        /// 1 Means New or not delivered Reception Invoices
        /// 0 Means All Status
        /// </summary>
        [JsonProperty("isNew")]
        public int isNew { get; set; }
    }

}