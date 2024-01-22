using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class TransferOwnershipPlaceReport : BaseModel
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

        // کد نقش تجاری خریدار
        [CodePageAttribute(NeedsToConvert = false)]
        public int BuyerBusinessRoleCode { get; set; }

        // نام خریدار
        [CodePageAttribute(NeedsToConvert = true)]
        public string BuyerName { get; set; }

        // تلفن همراه
        [CodePageAttribute(NeedsToConvert = false)]
        public string MobileNumber { get; set; }

        // کد پستی انبار مبدا
        [CodePageAttribute(NeedsToConvert = false)]
        public string SourceWarehousePostalCode { get; set; }

        // کد پستی انبار مقصد
        [CodePageAttribute(NeedsToConvert = false)]
        public string DestinationWarehousePostalCode { get; set; }

        // شماره قرارداد بورس
        [CodePageAttribute(NeedsToConvert = false)]
        public string StockExchangeContractNumber { get; set; }

        // وضعیت حمل
        [CodePageAttribute(NeedsToConvert = true)]
        public string TransportStatus { get; set; }

        // شماره بارنامه
        [CodePageAttribute(NeedsToConvert = false)]
        public string WaybillNumber { get; set; }

        // تاریخ بارنامه
        [CodePageAttribute(NeedsToConvert = false)]
        public string WaybillDate { get; set; }

        // سریال بارنامه
        [CodePageAttribute(NeedsToConvert = false)]
        public string WaybillSerial { get; set; }

        // شرح سند
        [CodePageAttribute(NeedsToConvert = true)]
        public string DocumentDescription { get; set; }

        // شناسه کالا
        [CodePageAttribute(NeedsToConvert = false)]
        public string ItemId { get; set; }

        // تعداد / مقدار
        [CodePageAttribute(NeedsToConvert = false)]
        public decimal Quantity { get; set; }

        // مبلغ واحد
        [CodePageAttribute(NeedsToConvert = true)]
        public decimal UnitPrice { get; set; }

        // مبلغ تخفیف
        [CodePageAttribute(NeedsToConvert = true)]
        public decimal DiscountAmount { get; set; }

        // مبلغ مالیات و عوارض
        [CodePageAttribute(NeedsToConvert = true)]
        public decimal TaxAndDutyAmount { get; set; }
    }
}
