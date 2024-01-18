using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Enums
{
    /// <summary>
    /// Represents the type of activity.
    /// </summary>
    public enum ActivityType
    {
        /// <summary>
        /// وارد کننده
        /// </summary>
        Importer = 1,

        /// <summary>
        /// تولید کننده
        /// </summary>
        Manufacturer = 2,

        /// <summary>
        /// عمده فروش
        /// </summary>
        Wholesaler = 3,

        /// <summary>
        /// خرده فروش
        /// </summary>
        Retailer = 6,

        /// <summary>
        /// نماینده
        /// </summary>
        Representative = 7,

        /// <summary>
        /// فروشگاه زنجیره ای
        /// </summary>
        ChainStore = 8,

        /// <summary>
        /// نامشخص
        /// </summary>
        Unknown = 10,

        /// <summary>
        /// میادین میوه و تره بار
        /// </summary>
        FruitAndVegetableMarket = 12,

        /// <summary>
        /// شرکت های پخش کالا
        /// </summary>
        GoodsDistributionCompanies = 13,

        /// <summary>
        /// تعاونی مصرف
        /// </summary>
        ConsumerCooperative = 15,

        /// <summary>
        /// صاحب برند
        /// </summary>
        BrandOwner = 16
    }
}
