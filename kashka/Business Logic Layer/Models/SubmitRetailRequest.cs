using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    // Class for the input parameters of the SubmitRetail method
    public class SubmitRetailRequest
    {
        /// <summary>
        /// نام کاربری سرویس*
        ///
        /// از مدیر سامانه دریافت شود.
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// رمز عبور سرویس*
        ///
        /// از مدیر سامانه دریافت شود.
        /// </summary>
        public string srvPass { get; set; }

        /// <summary>
        /// رمز عبور/کد اعتبارسنجی
        ///
        /// در صورت استفاده از کاربر مستقل یا ناامن ، رمز عبور سامانه یا کد اعتبارسنجی وارد شود
        /// </summary>
        public string password_otpCode { get; set; }

        /// <summary>
        /// کد/ شناسه ملی فروشنده*
        /// </summary>
        public string PersonNationalID { get; set; }

        /// <summary>
        /// کد نقش فروشنده
        ///
        /// در صورتیکه کاربر دارای چندین نقش باشد، وارد کردن کد نقش اجباری است.
        /// </summary>
        public string UserRoleIDstr { get; set; }

        /// <summary>
        /// اطلاعات جزئیات کد نقش
        ///
        /// در صورتی که کاربر چند نقش دارد و شماره نقش را نمی دانید؛ اطلاعات اضافی جهت شناسایی نقش دریافت می¬شود.
        /// </summary>
        public UserRoleExtraFields UserRoleExtraFields { get; set; }


        /// <summary>
        /// تاریخ سند*
        ///
        /// از نوع DATE : مثال: 01-01-2020
        /// </summary>
        public DateTime DocumentDate { get; set; }

        /// <summary>
        /// شرح سند
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// اطلاعات خریدار
        ///
        /// در جدول مقادیر اطلاعات خریدار
        /// </summary>
        public BuyerDatiles BuyerDatiles { get; set; }

        /// <summary>
        /// کد پستی انبار مبدا*
        ///
        /// جهت ثبت انبار موقت این فیلد را خالی یا 10 تا 2 ارسال کنید
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// اطلاعات کالا*
        ///
        /// در جدول مقایدر اطلاعات کالا
        /// </summary>
        public List<StuffIn> Stuffs_In { get; set; }

        /// <summary>
        /// شماره فاکتور
        /// </summary>
        public string DocNumber { get; set; }

        /// <summary>
        /// وضعیت سند
        ///
        /// 0: ثبت نهایی  _  7 : ثبت اولیه
        /// بصورت پیش فرض با وضعیت ثبت نهایی سند ثبت می شود.
        /// 
        /// </summary>
        public int statusAppointment { get; set; }

        /// <summary>
        /// شماره حواله
        ///
        /// در صورتیکه کالای انتخابی تایر سنگین می باشد، وارد نمودن این فیلد الزامی می باشد.
        /// </summary>
        public string TraceCode { get; set; }
    }
}
