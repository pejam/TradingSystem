using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseServices.Util
{
    public class CodePageAttribute : Attribute
    {

        public bool NeedsToConvert { get; set; }
    }
}
