using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class UserRoleExtraFields
    {
        /// <summary>
        /// کد پستی محل فعالیت
        /// </summary>
        public int PostalCode { get; set; }

        /// <summary>
        /// شماره مجوز
        ///
        /// شماره صنفی یا بهین یاب
        /// </summary>
        public int LicenseNumber { get; set; }

        /// <summary>
        /// نوع فعالیت
        ///
        /// در جدول مقادیر نوع فعالیت
        /// </summary>
        public int ActivityType { get; set; }
    }
}
