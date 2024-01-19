using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class FiscalPeriod : BaseModel
    {
        /// <summary>
        /// شناسه
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public int Id { get; set; }

        /// <summary>
        /// شماره دوره مالی
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public short FPNo { get; set; }

        /// <summary>
        /// نام دوره مالی
        /// </summary>
        [CodePage(NeedsToConvert = true)] 
        public string Name { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// تاریخ پایان
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// توضیحات دوره مالی
        /// </summary>
        [CodePage(NeedsToConvert = true)] 
        public string FPDesc { get; set; }

        /// <summary>
        /// نوع سرویس
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public short SType { get; set; }

        /// <summary>
        /// لاگ رزرو
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public short LRes { get; set; }

        /// <summary>
        /// دیتا رزرو
        /// </summary>
        [CodePage(NeedsToConvert = false)] 
        public float DRes { get; set; }

        /// <summary>
        /// زمان رزرو
        /// </summary>
        [CodePage(NeedsToConvert = true)] 
        public string TRes { get; set; }
    }

}
