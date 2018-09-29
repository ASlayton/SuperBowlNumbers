using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlNumbers.Converters
{
    class Tens
    {
        static string ConvertTensToNumeral(string givenNumber)
        {
            string myNumeral = "";

            if (Int32.Parse(givenNumber) == 1)
            {
                myNumeral = "X";
            }
            else if (Int32.Parse(givenNumber) == 2)
            {
                myNumeral = "XX";
            }
            else if (Int32.Parse(givenNumber) == 3)
            {
                myNumeral = "XXX";
            }
            else if (Int32.Parse(givenNumber) == 4)
            {
                myNumeral = "XL";
            }
            else if (Int32.Parse(givenNumber) == 5)
            {
                myNumeral = "L";
            }
            else if (Int32.Parse(givenNumber) == 6)
            {
                myNumeral = "LX";
            }
            else if (Int32.Parse(givenNumber) == 7)
            {
                myNumeral = "LXX";
            }
            else if (Int32.Parse(givenNumber) == 8)
            {
                myNumeral = "LXXX";
            }
            else if (Int32.Parse(givenNumber) == 9)
            {
                myNumeral = "XC";
            }

            return myNumeral;
        }

        internal static string ConvertTensToNumeral(string v)
        {
            throw new NotImplementedException();
        }
    }
}
