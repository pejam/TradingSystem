using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Enums
{
    public enum UserSellType
    {
        /// <summary>
        /// انتقال مالکیت
        /// </summary>
        OwnershipTransfer = 1,

        /// <summary>
        /// انتقال مکان
        /// </summary>
        PlaceTransfer = 2,

        /// <summary>
        /// انتقال مالکیت و مکان
        /// </summary>
        OwnershipAndPlaceTransfer = 3,

        /// <summary>
        /// برگشت از خرید
        /// </summary>
        PurchaseReturn = 4,

        /// <summary>
        /// تحویل حق العمل کاری
        /// </summary>
        WorkPermitDelivery = 5
    }
}
