using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class WebReqInfo
    {
        public string InvoiceNumber { get; set; }
        public int StockRoomId { get; set; }
        public int FiscalPeriodId { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
