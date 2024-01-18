using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class StuffIn
    {
        /// <summary>
        /// شناسه کالا*
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// تعداد/مقدار*
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// (مبلغ واحد (ریال
        ///
        /// در صورتیکه کالای انتخابی تایر سنگین یا صنایع پایین دست پتروشیمی می باشد، وارد نمودن این فیلد الزامی می باشد.
        /// </summary>
        public int Price { get; set; }
    }
}
