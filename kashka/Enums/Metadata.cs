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
        public static Dictionary<string, GridRowModel> TajerGridInfo = new Dictionary<string, GridRowModel>
        {

            { "DocumentDate", new GridRowModel { Title = "تاریخ سند", IsDetail = false } },
            { "InvoiceNumber", new GridRowModel { Title = " شماره صورتحساب", IsDetail = false } },
            { "BuyerNationalId", new GridRowModel { Title = "کد/شناسه ملي خريدار", IsDetail = false } },
            { "BuyerBusinessRoleCode", new GridRowModel { Title = "کد نقش تجاري خريدار ", IsDetail = false } },
            { "BuyerName", new GridRowModel { Title = " نام خريدار", IsDetail = false } },
            { "MobileNumber", new GridRowModel { Title = " تلفن همراه", IsDetail = false } },
            { "SourceWarehousePostalCode", new GridRowModel { Title = "کد پستي انبار مبدا ", IsDetail = false } },
            { "DestinationWarehousePostalCode", new GridRowModel { Title = "کد پستي انبار مقصد ", IsDetail = false } },
            { "StockExchangeContractNumber", new GridRowModel { Title = "شماره قرارداد بورس ", IsDetail = false } },
            { "TransportStatus", new GridRowModel { Title = "وضعيت حمل ", IsDetail = false } },
            { "WaybillNumber", new GridRowModel { Title = "شماره بارنامه ", IsDetail = false } },
            { "WaybillDate", new GridRowModel { Title = " تاريخ بارنامه", IsDetail = false } },
            { "WaybillSerial", new GridRowModel { Title = " سريال بارنامه", IsDetail = false } },
            { "DocumentDescription", new GridRowModel { Title = " شرح سند", IsDetail = false } },
            { "ItemId", new GridRowModel { Title = "شناسه کالا ", IsDetail = false } },
            { "Quantity", new GridRowModel { Title = "مقدار / تعداد", IsDetail = false } },
            { "UnitPrice", new GridRowModel { Title = "مبلغ واحد ", IsDetail = false } },
            { "DiscountAmount", new GridRowModel { Title = "مبلغ تخفيف ", IsDetail = false } },

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
