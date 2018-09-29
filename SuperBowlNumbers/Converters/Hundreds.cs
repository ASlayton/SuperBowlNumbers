using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlNumbers.Converters
{
    class Hundreds
    {
        static string ConvertHundredsToNumeral(string givenNumber)
        {
            string myNumeral = "";
            if (Int32.Parse(givenNumber) == 1)
            {
                myNumeral = "C";
            }
            else if (Int32.Parse(givenNumber) == 2)
            {
                myNumeral = "CC";
            }
            else if (Int32.Parse(givenNumber) == 3)
            {
                myNumeral = "CCC";
            }
            else if (Int32.Parse(givenNumber) == 4)
            {
                myNumeral = "CD";
            }
            else if (Int32.Parse(givenNumber) == 5)
            {
                myNumeral = "D";
            }
            else if (Int32.Parse(givenNumber) == 6)
            {
                myNumeral = "DC";
            }
            else if (Int32.Parse(givenNumber) == 7)
            {
                myNumeral = "DCC";
            }
            else if (Int32.Parse(givenNumber) == 8)
            {
                myNumeral = "DCCC";
            }
            else if (Int32.Parse(givenNumber) == 9)
            {
                myNumeral = "CM";
            }
            return myNumeral;
        }

        internal static string ConvertHundredsToNumeral(string v)
        {
            throw new NotImplementedException();
        }
    }
}
