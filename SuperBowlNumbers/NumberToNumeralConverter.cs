using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlNumbers
{
    class NumberToNumberalConverter
    {
        decimal myGetNumber = Int32.Parse(getNumber);
        string myResult = "";
        if (Int32.Parse(getNumber) < 4000)
        {
            if (Int32.Parse(getNumber) / 1000 > 0)
            {
                var thousandsPlace = Math.Floor(myGetNumber / 1000);
                string thousandsNumeral = ConvertThousandsToNumeral(thousandsPlace.ToString());
                var hundredsPlace = Math.Floor((myGetNumber % 1000) / 100);
                string hundredsNumeral = ConvertHundredsToNumeral(hundredsPlace.ToString());
                var tensPlace = Math.Floor(((myGetNumber % 1000) % 100) / 10);
                string tensNumeral = ConvertTensToNumeral(tensPlace.ToString());
                var onesPlace = Math.Floor((((myGetNumber % 1000) % 100)) % 10);
                string onesNumeral = ConvertNumberToNumeral(onesPlace.ToString());

                myResult = thousandsNumeral + hundredsNumeral + tensNumeral + onesNumeral;
            }
            else if (Int32.Parse(getNumber) / 100 > 0)
            {
                var hundredsPlace = Math.Floor(myGetNumber / 100);
                string hundredsNumeral = ConvertHundredsToNumeral(hundredsPlace.ToString());
                var tensPlace = Math.Floor((myGetNumber % 100) / 10);
                string tensNumeral = ConvertTensToNumeral(tensPlace.ToString());
                var onesPlace = Math.Floor((myGetNumber % 100) % 10);
                string onesNumeral = ConvertNumberToNumeral(onesPlace.ToString());

                myResult = hundredsNumeral + tensNumeral + onesNumeral;
            }
            else if (Int32.Parse(getNumber) / 10 > 0)
            {
                var tensPlace = Math.Floor(myGetNumber / 10);
                string tensNumeral = ConvertTensToNumeral(tensPlace.ToString());
                var onesPlace = Math.Floor(myGetNumber % 10);
                string onesNumeral = ConvertNumberToNumeral(onesPlace.ToString());

                myResult = tensNumeral + onesNumeral;
            }
            else
            {
                myResult = ConvertNumberToNumeral(getNumber);
            };
        }
        else
        {
            myResult = "There has been an error";
        };

        return myResult;

        static string ConvertNumberToNumeral(string givenNumber)
        {
            string myNumeral = "";
            if (Int32.Parse(givenNumber) == 1)
            {
                myNumeral = "I";
            }
            else if (Int32.Parse(givenNumber) == 2)
            {
                myNumeral = "II";
            }
            else if (Int32.Parse(givenNumber) == 3)
            {
                myNumeral = "III";
            }
            else if (Int32.Parse(givenNumber) == 4)
            {
                myNumeral = "IV";
            }
            else if (Int32.Parse(givenNumber) == 5)
            {
                myNumeral = "V";
            }
            else if (Int32.Parse(givenNumber) == 6)
            {
                myNumeral = "VI";
            }
            else if (Int32.Parse(givenNumber) == 7)
            {
                myNumeral = "VII";
            }
            else if (Int32.Parse(givenNumber) == 8)
            {
                myNumeral = "VIII";
            }
            else if (Int32.Parse(givenNumber) == 9)
            {
                myNumeral = "IX";
            }
            else
            {
                myNumeral = "Entry is not valid";
            };

            return myNumeral;
        }




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


    }
}
