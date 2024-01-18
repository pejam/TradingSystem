using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class Buyer_UserRoleExtraFields
    {
        /// <summary>
        /// کد پستی محل فعالیت
        /// </summary>
        public int PostalCode { get; set; }

        /// <summary>
        /// شماره مجوز
        /// </summary>
        public int LicenseNumber { get; set; }

        /// <summary>
        /// نوع فعالیت
        /// </summary>
        public int ActivityType { get; set; }
    }
}
