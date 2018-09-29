using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlNumbers.Converters
{
    class Thousands
    {
        static string ConvertThousandsToNumeral(string givenNumber)
        {
            string myNumeral = "";
            if (Int32.Parse(givenNumber) == 1)
            {
                myNumeral = "M";
            }
            else if (Int32.Parse(givenNumber) == 2)
            {
                myNumeral = "MM";
            }
            else if (Int32.Parse(givenNumber) == 3)
            {
                myNumeral = "MMM";
            }

            return myNumeral;
        }

        internal static string ConvertThousandsToNumeral(string v)
        {
            throw new NotImplementedException();
        }
    }
}
