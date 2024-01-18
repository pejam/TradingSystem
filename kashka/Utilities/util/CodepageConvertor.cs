using SamanConvertor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace kashka
{
    public class CodepageConvertor : ICodepageConvertor
    {
        public string fromTadbir(string input)
        {            
            return Direction.GetRTLString(numsFromTadbir(input));
        }

        public string toTadbir(string input)
        {
            return Direction.GetLTRString(numsToTadbir(input));
        }

        public string numsToTadbir(string input)
        {
            return TadbirEncoder.ReplaceDigits(input);
        }

        public string numsFromTadbir(string input)
        {
            return TadbirDecoder.ReplaceDigits(input, false);
        }

        public string latinizeNumbers(string input)
        {
            return TadbirDecoder.EnglishDigits(input);
        }

        public string persianizeNumbers(string input)
        {
            return TadbirDecoder.PersianizeDigits(input);
        }
    }
}
