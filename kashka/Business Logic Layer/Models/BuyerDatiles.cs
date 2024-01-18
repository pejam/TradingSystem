using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class BuyerDatiles
    {
        /// <summary>
        /// نام خریدار
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// کد ملی/ شناسه ملی خریدار
        ///
        /// در صورتیکه کالای انتخابی تایر سنگین می باشد، وارد نمودن این فیلد الزامی می باشد.
        /// </summary>
        public string BuyerNationalID { get; set; }

        /// <summary>
        /// شماره همراه خریدار
        /// </summary>
        public string BuyerMobile { get; set; }
    }
}
