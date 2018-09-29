using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperBowlNumbers.Converters;

namespace SuperBowlNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number 1 - 3999.");
            var getNumber = Console.ReadLine();
            var myResult = NumberToNumeralConverter(getNumber);
            Console.WriteLine($"Roman Numeral: {myResult}");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        public static string NumberToNumeralConverter(string getNumber)
        {
            decimal myGetNumber = Int32.Parse(getNumber);
            string myResult = "";
            if (Int32.Parse(getNumber) < 4000)
            {
                if (Int32.Parse(getNumber) / 1000 > 0)
                {
                    var thousandsPlace = Math.Floor(myGetNumber / 1000);
                    string thousandsNumeral = Thousands.ConvertThousandsToNumeral(thousandsPlace.ToString());
                    var hundredsPlace = Math.Floor((myGetNumber % 1000) / 100);
                    string hundredsNumeral = Hundreds.ConvertHundredsToNumeral(hundredsPlace.ToString());
                    var tensPlace = Math.Floor(((myGetNumber % 1000) % 100) / 10);
                    string tensNumeral = Tens.ConvertTensToNumeral(tensPlace.ToString());
                    var onesPlace = Math.Floor((((myGetNumber % 1000) % 100)) % 10);
                    string onesNumeral = Ones.ConvertNumberToNumeral(onesPlace.ToString());

                    myResult = thousandsNumeral + hundredsNumeral + tensNumeral + onesNumeral;
                }
                else if (Int32.Parse(getNumber) / 100 > 0)
                {
                    var hundredsPlace = Math.Floor(myGetNumber / 100);
                    string hundredsNumeral = Hundreds.ConvertHundredsToNumeral(hundredsPlace.ToString());
                    var tensPlace = Math.Floor((myGetNumber % 100) / 10);
                    string tensNumeral = Tens.ConvertTensToNumeral(tensPlace.ToString());
                    var onesPlace = Math.Floor((myGetNumber % 100) % 10);
                    string onesNumeral = Ones.ConvertNumberToNumeral(onesPlace.ToString());

                    myResult = hundredsNumeral + tensNumeral + onesNumeral;
                }
                else if (Int32.Parse(getNumber) / 10 > 0)
                {
                    var tensPlace = Math.Floor(myGetNumber / 10);
                    string tensNumeral = Tens.ConvertTensToNumeral(tensPlace.ToString());
                    var onesPlace = Math.Floor(myGetNumber % 10);
                    string onesNumeral = Ones.ConvertNumberToNumeral(onesPlace.ToString());

                    myResult = tensNumeral + onesNumeral;
                }
                else
                {
                    myResult = Ones.ConvertNumberToNumeral(getNumber);
                };
            }
            else
            {
                myResult = "There has been an error";
            };

            return myResult;
        }
    }
}
