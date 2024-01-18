using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kashka.Business_Logic_Layer.Models
{
    // Define a class for the API response structure
    [XmlRoot("ObjList")]
    public class ApiResult<T>
    {
        [XmlElement("ObjList")]
        public T ObjList { get; set; }

        [XmlElement("ResultCode")]
        public int ResultCode { get; set; }

        [XmlElement("ResultMessage")]
        public string ResultMessage { get; set; }
    }
}
