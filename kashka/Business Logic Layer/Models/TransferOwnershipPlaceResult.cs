using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kashka.Business_Logic_Layer.Models
{
    public class TransferOwnershipPlaceResult
    {
        /// <summary>
        /// شماره سند
        /// </summary>
        [XmlElement("SellID")]
        public int SellID { get; set; }

        /// <summary>
        /// وضعیت سند
        /// </summary>
        [XmlElement("SellStatusId")]
        public int SellStatusId { get; set; }

        /// <summary>
        /// شرح مغایرت بارنامه
        /// </summary>
        [XmlElement("public string WayBillConflictMessage { get; set; }")]
        public string WayBillConflictMessage { get; set; }

        /// <summary>
        /// رشته‌ای
        /// سریال بارنامه
        /// </summary>
        [XmlElement("WayBillSerial")]
        public string WayBillSerial { get; set; }

        /// <summary>
        /// رشته‌ای
        /// تاریخ بارنامه
        /// </summary>
        [XmlElement("WayBillDate")]
        public string WayBillDate { get; set; }

        /// <summary>
        /// رشته‌ای
        /// شماره رسید انبار
        /// </summary>
        [XmlElement("WarehouseReceiptNumber")]
        public string WarehouseReceiptNumber { get; set; }

        /// <summary>
        /// رشته‌ای
        /// شماره حواله انبار
        /// </summary>
        [XmlElement("WarehouseRequisitionNumber")]
        public string WarehouseRequisitionNumber { get; set; }

        /// <summary>
        /// رشته‌ای
        /// پیام سرویس انبار
        /// </summary>
        [XmlElement("WarehouseMessage")]
        public string WarehouseMessage { get; set; }

        /// <summary>
        /// لیست نقش‌های فروشنده
        /// لیست
        /// در صورتی که فروشنده چند نقش داشته باشد و تعیین نشده باشد.
        /// </summary>
        [XmlElement("SellerRolesList")]
        public List<string> SellerRolesList { get; set; }

        /// <summary>
        /// لیست نقش‌های خریدار
        /// لیست
        /// در صورتی که خریدار چند نقش داشته باشد و تعیین نشده باشد.
        /// </summary>
        [XmlElement("BuyerRolesList")]
        public List<string> BuyerRolesList { get; set; }
    }

}
