using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class PlaceTransfer
    {
        /// <summary>
        /// کدپستی مقصد
        /// </summary>
        public string ToPostalCode { get; set; }

        /// <summary>
        /// دارای بارنامه
        /// </summary>
        public int WayBillHas { get; set; }

        /// <summary>
        /// شماره بارنامه
        /// </summary>
        public string WayBillNumber { get; set; }

        /// <summary>
        /// سریال بارنامه
        /// </summary>
        public string WayBillSerial { get; set; }

        /// <summary>
        /// تاریخ بارنامه
        /// </summary>
        public DateTime WayBillDate { get; set; }
    }
}
