using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kashka
{
    public class CodePageAttribute : Attribute
    {

        public bool NeedsToConvert { get; set; }
    }
}
