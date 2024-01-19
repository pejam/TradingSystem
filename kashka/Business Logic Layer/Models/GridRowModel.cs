using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class GridRowModel
    {
        public int Ordinal { get; set; }

        public string Title { get; set; }

        public bool IsDetail = false;
    }
}
