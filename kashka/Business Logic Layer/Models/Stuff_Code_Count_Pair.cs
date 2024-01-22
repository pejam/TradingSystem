using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class Stuff_Code_Count_Pair
    {
        /// <summary>
        /// شناسه کالا
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// تعداد/مقدار
        /// </summary>
        public decimal Count { get; set; }

        /// <summary>
        /// مبلغ واحد(ریال)
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// تخفیف(ریال)
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// مالیات و عوارض(ریال)
        /// </summary>
        public decimal VAT { get; set; }
    }
}
