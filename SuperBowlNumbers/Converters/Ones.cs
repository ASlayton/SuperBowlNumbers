using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlNumbers.Converters
{
    class Ones
    {
        string OnesString { get; set;}

        static string ConvertNumberToNumeral(string onesString)
        {
            string myNumeral = "";
            if (Int32.Parse(onesString) == 1)
            {
                myNumeral = "I";
            }
            else if (Int32.Parse(onesString) == 2)
            {
                myNumeral = "II";
            }
            else if (Int32.Parse(onesString) == 3)
            {
                myNumeral = "III";
            }
            else if (Int32.Parse(onesString) == 4)
            {
                myNumeral = "IV";
            }
            else if (Int32.Parse(onesString) == 5)
            {
                myNumeral = "V";
            }
            else if (Int32.Parse(onesString) == 6)
            {
                myNumeral = "VI";
            }
            else if (Int32.Parse(onesString) == 7)
            {
                myNumeral = "VII";
            }
            else if (Int32.Parse(onesString) == 8)
            {
                myNumeral = "VIII";
            }
            else if (Int32.Parse(onesString) == 9)
            {
                myNumeral = "IX";
            }
            else
            {
                myNumeral = "Entry is not valid";
            };

            return myNumeral;
        }

        internal static string ConvertNumberToNumeral(string v)
        {
            throw new NotImplementedException();
        }
    }
}
