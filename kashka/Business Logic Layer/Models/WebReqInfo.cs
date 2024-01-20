using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class WebReqInfo
    {
        public int FactorId { get; set; }
        public int FactorArticleId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
