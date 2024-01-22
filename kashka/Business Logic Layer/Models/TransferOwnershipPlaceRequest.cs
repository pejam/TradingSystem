using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{

    /// <summary>
    /// Request class for the TransferOwnershipPlace_SI method.
    /// </summary>
    public class TransferOwnershipPlaceRequest
    {
        /// <summary>
        /// نام کاربری سرویس*
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// رمز عبور سرویس*
        /// </summary>
        public string SrvPass { get; set; }

        /// <summary>
        /// کد/ شناسه ملی کاربر*
        /// </summary>
        public string PersonNationalCode { get; set; }

        /// <summary>
        /// رمز عبور/کد اعتبارسنجی
        /// </summary>
        public string PasswordOtpCode { get; set; }

        /// <summary>
        /// کد نقش کاربر
        /// </summary>
        public int UserRoleIDstr { get; set; }

        /// <summary>
        /// نوع سند*
        /// </summary>
        public int UserSellType { get; set; }

        /// <summary>
        /// تاریخ سند*
        /// </summary>
        public DateTime DocumentDate { get; set; }

        /// <summary>
        /// کد پستی مبدا*
        /// </summary>
        public string FromPostalCode { get; set; }

        /// <summary>
        /// اطلاعات انتقال مالکیت
        /// </summary>
        public OwnershipTransfer OwnershipTransfer { get; set; }

        /// <summary>
        /// اطلاعات انتقال مکان
        /// </summary>
        public PlaceTransfer PlaceTransfer { get; set; }

        /// <summary>
        /// اطلاعات جزئیات کد نقش فروشنده
        /// </summary>
        public Seller_UserRoleExtraFields Seller_UserRoleExtraFields { get; set; }

        /// <summary>
        /// اطلاعات جزئیات کد نقش خریدار
        /// </summary>
        public Buyer_UserRoleExtraFields Buyer_UserRoleExtraFields { get; set; }

        /// <summary>
        /// اطلاعات کالا
        /// </summary>
        public List<Stuff_Code_Count_Pair> Stuffs_In { get; set; }

        /// <summary>
        /// شرح سند
        /// </summary>
        public string DocumentDescription { get; set; }

        /// <summary>
        /// وضعیت سند
        ///
        /// 0: ثبت نهایی
        /// 7: ثبت اولیه
        /// 1: استعلام ثبت
        /// بصورت پیش فرض با وضعیت ثبت نهایی ثبت می شود
        /// 
        /// </summary>
        public int StatusAppointment { get; set; }

        /// <summary>
        /// شماره فاکتور
        /// </summary>
        public string DocNumber { get; set; }

        /// <summary>
        /// شماره سند مرتبط
        /// </summary>
        public string RelatedDocNumber { get; set; }

        /// <summary>
        /// شماره قرداد بورس
        /// </summary>
        public string StockExchangeCode { get; set; }
    }

}
