
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kashka.Business_Logic_Layer.Models
{
    public class BaseModel
    {

        protected ICodepageConvertor _codepageService { get; private set; }

        public BaseModel()
        {
            _codepageService = new CodepageConvertor();
        }

    }
}
