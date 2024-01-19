using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kashka.Business_Logic_Layer.Models;

namespace kashka.Enums
{
    public static class Dics
    {
        private static int _index = 0;
        private static int _index2 = 0;

        public static Dictionary<string, GridRowModel> TajerGridInfo = new Dictionary<string, GridRowModel>
        {

            { "DocumentDate", new GridRowModel { Title = "سند تاریخ", IsDetail = false } },
            { "InvoiceNumber", new GridRowModel { Title = "صورتحساب شماره", IsDetail = false } },
            { "BuyerNationalId", new GridRowModel { Title = "خريدار شناسه ملي کد/", IsDetail = false } },
            { "BuyerBusinessRoleCode", new GridRowModel { Title = "خريدار کد نقش تجاري", IsDetail = false } },
            { "BuyerName", new GridRowModel { Title = "خريدار نام       ", IsDetail = false } },
            { "MobileNumber", new GridRowModel { Title = "همراه تلفن", IsDetail = false } },
            { "SourceWarehousePostalCode", new GridRowModel { Title = "انبار مبدا کد پستي", IsDetail = false } },
            { "DestinationWarehousePostalCode", new GridRowModel { Title = "انبار مقصد کد پستي", IsDetail = false } },
            { "StockExchangeContractNumber", new GridRowModel { Title = "بورس قرارداد شماره", IsDetail = false } },
            { "TransportStatus", new GridRowModel { Title = "حمل وضعيت", IsDetail = false } },
            { "WaybillNumber", new GridRowModel { Title = "بارنامه شماره", IsDetail = false } },
            { "WaybillDate", new GridRowModel { Title = "بارنامه تاريخ", IsDetail = false } },
            { "WaybillSerial", new GridRowModel { Title = "بارنامه سريال", IsDetail = false } },
            { "DocumentDescription", new GridRowModel { Title = "سند شرح", IsDetail = false } },
            { "ItemId", new GridRowModel { Title = "کالا شناسه", IsDetail = false } },
            { "Quantity", new GridRowModel { Title = "مقدار / تعداد", IsDetail = false } },
            { "UnitPrice", new GridRowModel { Title = "واحد مبلغ", IsDetail = false } },
            { "DiscountAmount", new GridRowModel { Title = "تخفيف مبلغ", IsDetail = false } },
            { "TaxAndDutyAmount", new GridRowModel { Title = "ماليات و عوارض مبلغ", IsDetail = false } }

        };

        public static Dictionary<string, GridRowModel> submitGridInfo = new Dictionary<string, GridRowModel>
        {
            { "DocumentDate", new GridRowModel { Title = "تاریخ سند", IsDetail = false } },
            { "InvoiceNumber", new GridRowModel { Title = "شماره صورتحساب", IsDetail = false } },
            { "BuyerNationalId", new GridRowModel { Title = "کد/شناسه ملي خريدار", IsDetail = false } },
            { "BuyerName", new GridRowModel { Title = "نام خريدار", IsDetail = false } },
            { "MobileNumber", new GridRowModel { Title = "تلفن همراه", IsDetail = false } },
            { "SourceWarehousePostalCode", new GridRowModel { Title = "کد پستي انبار مبدا", IsDetail = false } },
            { "DocumentDescription", new GridRowModel { Title = "شرح سند", IsDetail = false } },
            { "ItemId", new GridRowModel { Title = "شناسه کالا", IsDetail = false } },
            { "TrackingId", new GridRowModel { Title = "شناسه رهگيري", IsDetail = false } },
            { "UnitPrice", new GridRowModel { Title = "مبلغ واحد", IsDetail = false } }
        };
    }
}
