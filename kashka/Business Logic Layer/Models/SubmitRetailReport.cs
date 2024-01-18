using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class SubmitRetailReport : BaseModel
    {
        // تاریخ سند
        [CodePageAttribute(NeedsToConvert = false)]
        public string DocumentDate { get; set; }

        // شماره صورتحساب
        [CodePageAttribute(NeedsToConvert = false)]
        public string InvoiceNumber { get; set; }

        // کد/شناسه ملی خریدار
        [CodePageAttribute(NeedsToConvert = false)]
        public string BuyerNationalId { get; set; }

        // نام خریدار
        [CodePageAttribute(NeedsToConvert = true)]
        public string BuyerName { get; set; }

        // تلفن همراه
        [CodePageAttribute(NeedsToConvert = false)]
        public string MobileNumber { get; set; }

        // کد پستی انبار مبدا
        [CodePageAttribute(NeedsToConvert = false)]
        public string SourceWarehousePostalCode { get; set; }

        // شرح سند
        [CodePageAttribute(NeedsToConvert = true)]
        public string DocumentDescription { get; set; }

        // شناسه کالا
        [CodePageAttribute(NeedsToConvert = false)]
        public string ItemId { get; set; }

        // شناسه رهگیری
        [CodePageAttribute(NeedsToConvert = false)]
        public string TrackingId { get; set; }

        // مبلغ واحد
        [CodePageAttribute(NeedsToConvert = true)]
        public decimal UnitPrice { get; set; }
    }
}
