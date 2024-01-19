

using kashka.Business_Logic_Layer.Models;

namespace kashka.Business_Logic_Layer
{

    /// <summary>
	/// انبار
	/// </summary>
    public class StockRoom : BaseModel
    {
        /// <summary>
		/// شناسه
		/// </summary>
		[CodePage(NeedsToConvert = false)] 
        public int Id
        {
            get;
            set;
        }


        /// <summary>
        /// کد
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public int Code
        {
            get;
            set;
        }


        /// <summary>
        /// نام
        /// </summary>
        //private string _Name;
        [CodePage(NeedsToConvert = true)]
        public string Name
        {
            get;
            set;
        }


        /// <summary>
        /// نام مسئول
        /// </summary>
        [CodePage(NeedsToConvert = true)]
        public string ManagerName
        {
            get;
            set;
        }


        /// <summary>
        /// شرح
        /// </summary>
        
        [CodePage(NeedsToConvert = true)]
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
        [CodePage(NeedsToConvert = false)]
        public int LRes
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع real
        /// </summary>
        [CodePage(NeedsToConvert = false)] 
        public double DRes
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع متن
        /// </summary>
        //private string _TRes;
        [CodePage(NeedsToConvert = true)]
        public string TRes
        {
            get;
            set;
        }


        /// <summary>
        /// کد حساب
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public string AccountId
        {
            get;
            set;
        }


        /// <summary>
        /// کد دوره مالی
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public int FPId
        {
            get;
            set;
        }


        /// <summary>
        /// تفصیلی شناور
        /// </summary>
        [CodePage(NeedsToConvert = false)] public int FAccId
        {
            get;
            set;
        }


        /// <summary>
        /// مرکز هزینه
        /// </summary>
        [CodePage(NeedsToConvert = false)] public int CCId
        {
            get;
            set;
        }


        /// <summary>
        /// پروژه
        /// </summary>
        [CodePage(NeedsToConvert = false)] public int PrjId
        {
            get;
            set;
        }
    }
}
