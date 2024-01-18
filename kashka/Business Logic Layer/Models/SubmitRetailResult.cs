using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kashka.Business_Logic_Layer.Models
{
    public class SubmitRetailResult
    {
        [XmlElement("RolesList")]
        public List<string> RolesList { get; set; }

        [XmlElement("FactorID")]
        public int FactorID { get; set; }
    }
}
