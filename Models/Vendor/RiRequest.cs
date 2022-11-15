namespace UPAExternalAPI.Models.Vendor
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class RiRequest
    {
        [JsonProperty("po", NullValueHandling = NullValueHandling.Ignore, Required = Required.Always)]
        public int po { get; set; }

        [JsonProperty("pr", NullValueHandling = NullValueHandling.Ignore, Required = Required.Always)]
        public int pr { get; set; }

        //[JsonProperty("customer_soc_id", Required = Required.Always)]
        //public int customer_soc_id { get; set; }

        //[JsonProperty("vendor_soc_id", Required = Required.Always)]
        //public int vendor_soc_id { get; set; }

        [JsonProperty("vendor_ref", Required = Required.Always)]
        public string vendor_ref { get; set; }

        [JsonProperty("vendor_date", Required = Required.Always)]
        public DateTime vendor_date { get; set; }
        [JsonProperty("theItems", Required = Required.Always)]
        public virtual List<List<RecInvoiceItemRequest>> theItems { get; set; }
    }


    public partial class RecInvoiceItemRequest
    {
        /// <summary>
        /// Purchase Request Detail
        /// </summary>
        [JsonProperty("prdet", Required = Required.Always)]
        public int prdet { get; set; }/**************************************/
        /// <summary>
        /// Purchase Order Detail
        /// </summary>
        [JsonProperty("podet", Required = Required.Always)]
        public int podet { get; set; }/*************************/
        /// <summary>
        /// Global Trade Item Number (GTIN)
        /// </summary>
        [JsonProperty("gtin", Required = Required.Always)]
        public string gtin { get; set; }/**************************/

        /// <summary>
        ///  التشغيله (Batch)
        /// </summary>
        [JsonProperty("batchNumber", Required = Required.Always)]
        public string batchNumber { get; set; }/*************************/

        /// <summary>
        ///  تاريخ الإنتاج  (Unix Time)
        /// </summary>
        [JsonProperty("manDate", Required = Required.Always)]
        public long manDate { get; set; }/*******************************/

        /// <summary>
        ///  تاريخ إنتهاء الصلاحية (Unix Time)
        /// </summary>
        [JsonProperty("expDate", Required = Required.Always)]
        public long expDate { get; set; }/***************************/

        /// <summary>
        ///  مدة الإرتجاع (قبل إنتهاء الصلاحية) طبقا للعقد
        /// </summary>
        [JsonProperty("warningPeriod", Required = Required.DisallowNull)]
        public int warningPeriod { get; set; }/*************************/

        /// <summary>
        ///  الكمية الاساسية (بالعبوة ) 
        /// </summary>
        [JsonProperty("mainQtyByUnit", Required = Required.Always)]
        public int mainQtyByUnit { get; set; }/********************************/

        /// <summary>
        ///  كمية البونص (بالعبوة)
        /// </summary>
        [JsonProperty("bonusQtyByUnit", Required = Required.Always)]
        public int bonusQtyByUnit { get; set; }/*******************************/
        /// <summary>
        /// Auxiliary Items List
        /// </summary>
        [JsonProperty("auxGtinList", Required = Required.Default)]
        public List<AuxGtinListRequest> auxGtinList { get; set; }/******************************/

    }
    public class AuxGtinListRequestService : AuxGtinListRequest
    {
        [JsonProperty("name")]
        public string name { get; set; }
    }
    public class AuxGtinListRequest
    {
        /// <summary>
        /// Global Trade Item Name (GTIN)
        /// </summary>
        [JsonProperty("gtin", Required = Required.Always)]
        public string gtin { get; set; }
    }

    public class RecInvoiceItemToService : RecInvoiceItemRequest
    {
        /// <summary>
        /// كود المورد
        /// </summary>
        [JsonProperty("vendorId")]
        public int vendorId { get; set; }
        /*SOKSOK TO BE FILLED WITH TRADE NAME*/
        /// <summary>
        /// Product Name
        /// </summary>
        [JsonProperty("product")]
        public string product { get; set; }/******************************/

        /*SOKSOK TO BE FILLED WITH TRADE NAME*/
        [JsonProperty("trade_name_id")]
        public int trade_name_id { get; set; }/*****************************/


        /// <summary>
        /// Dosage Form, From Dosage Form List
        /// </summary>
        [JsonProperty("dosageForm")]
        public int dosageForm { get; set; }/***************************/

        /// <summary>
        /// Is Local , 1 Means Local, 0 Means Imported
        /// </summary>
        [JsonProperty("is_local")]/*********************/
        public int is_local { get; set; }

        /// <summary>
        ///  عدد الوحدات الصغرى بالعبوة  
        /// </summary>
        [JsonProperty("itemCountPerUnit")]
        public int itemCountPerUnit { get; set; }/****************************/

        /// <summary>
        ///  السعر الجبري للعبوة (أدوية) 
        /// </summary>
        [JsonProperty("forcedPrice")]
        public double forcedPrice { get; set; }/************************/

        /// <summary>
        ///  السعر الصيدلي للعبوة (أدوية) 
        /// </summary>
        [JsonProperty("pharmaPrice")]
        public double pharmaPrice { get; set; }/*****************************/

        /*SOKSOK TO BE CALCULATED*/
        [JsonProperty("mainQtyByTenderUnit")]
        public int mainQtyByTenderUnit
        {
            get
            {
                return itemCountPerUnit * mainQtyByUnit;
            }
        }/******/
        /*SOKSOK TO BE CALCULATED*/
        [JsonProperty("bonusQtyByTenderUnit")]
        public int bonusQtyByTenderUnit
        {
            get
            {
                return itemCountPerUnit * bonusQtyByUnit;
            }
        }/***********************/
        [JsonProperty("p_cat", NullValueHandling = NullValueHandling.Ignore)]

        public int p_cat { get; set; }

        [JsonProperty("auxGtinList", Required = Required.Default)]
        public new List<AuxGtinListRequestService> auxGtinList { get; set; }/******************************/
    }
    public partial class RiServiceRequest : RiRequest
    {
        [JsonProperty("theItems", Required = Required.Always)]
        public new List<List<RecInvoiceItemToService>> theItems { get; set; }
    }

    public class WebServiceMessage
    {
        public int code { get; set; }
        public string msg { get; set; }
        public int inv_id { get; set; }
    }

    public class WebServiceResult
    {
        public WebServiceMessage d { get; set; }
    }
}
