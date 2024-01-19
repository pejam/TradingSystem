using BaseServices.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseServices.Models
{

    /// <summary>
	/// انبار
	/// </summary>
    public class StockRoom : BaseModel
    {
        /// <summary>
		/// شناسه
		/// </summary>
		[JsonProperty("Id")] public int Id
        {
            get;
            set;
        }


        /// <summary>
        /// کد
        /// </summary>
        [JsonProperty("Code")] public int Code
        {
            get;
            set;
        }


        /// <summary>
        /// نام
        /// </summary>
        //private string _Name;
        [CodePage(NeedsToConvert = true)]
        [JsonProperty("Name")]
        public string Name
        {
            get;
            set;
        }


        /// <summary>
        /// نام مسئول
        /// </summary>
        [CodePage(NeedsToConvert = true)]
        [JsonProperty("ManagerName")]
        public string ManagerName
        {
            get;
            set;
        }


        /// <summary>
        /// شرح
        /// </summary>
        
        [CodePage(NeedsToConvert = true)]
        [JsonProperty("SRDesc")]
        public string SRDesc
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع smallint
        /// </summary>
        /// <remarks>
        /// توضیح در کد: Used for serial grouping
        /// </remarks>
        [JsonProperty("LRes")] public int LRes
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع real
        /// </summary>
        [JsonProperty("DRes")] public double DRes
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع متن
        /// </summary>
        //private string _TRes;
        [CodePage(NeedsToConvert = true)]
        [JsonProperty("TRes")]
        public string TRes
        {
            get;
            set;
        }


        /// <summary>
        /// کد حساب
        /// </summary>
        [JsonProperty("AccountId")] 
        [CodePage(NeedsToConvert = false)]
        public string AccountId
        {
            get;
            set;
        }


        /// <summary>
        /// کد دوره مالی
        /// </summary>
        [JsonProperty("FPId")] public int FPId
        {
            get;
            set;
        }


        /// <summary>
        /// تفصیلی شناور
        /// </summary>
        [JsonProperty("FAccId")] public int FAccId
        {
            get;
            set;
        }


        /// <summary>
        /// مرکز هزینه
        /// </summary>
        [JsonProperty("CCId")] public int CCId
        {
            get;
            set;
        }


        /// <summary>
        /// پروژه
        /// </summary>
        [JsonProperty("PrjId")] public int PrjId
        {
            get;
            set;
        }
    }
}
