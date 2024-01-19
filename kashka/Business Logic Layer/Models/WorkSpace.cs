using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class WorkSpace : BaseModel
    {
        /// <summary>
        /// شناسه
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public int Id { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        [CodePage(NeedsToConvert = true)] 
        public string Name { get; set; }

        /// <summary>
        /// مسیر پایگاه داده 1
        /// </summary>
        [CodePage(NeedsToConvert = false)] 
        public string MdbPath { get; set; }

        /// <summary>
        /// مسیر پایگاه داده 2
        /// </summary>
        [CodePage(NeedsToConvert = true)] 
        public string MdbPath1 { get; set; }

        /// <summary>
        /// مسیر پایگاه داده 3
        /// </summary>
        [CodePage(NeedsToConvert = true)] 
        public string MdbPath2 { get; set; }

        /// <summary>
        /// مسیر پایگاه داده 4
        /// </summary>
        [CodePage(NeedsToConvert = true)] 
        public string MdbPath3 { get; set; }

        /// <summary>
        /// مسیر پایگاه داده 5
        /// </summary>
        [CodePage(NeedsToConvert = true)]
        public string MdbPath4 { get; set; }

        /// <summary>
        /// نوع سرویس وب
        /// </summary>
        [CodePage(NeedsToConvert = false)]
        public int WSType { get; set; }
    }

}
