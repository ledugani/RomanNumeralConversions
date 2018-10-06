using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ones
            // var onesValues = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var ones = new List<string>() { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            // tens
            var tensValues = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            var tens = new List<string>() { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

            //hundreds
            var hundreds = new List<string>() { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

            // start application
            Console.WriteLine("Enter the number you'd like converted to Roman Numerals: ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int result))
            {
                var numOfDigits = Math.Floor(Math.Log10(result) + 1);
                Console.WriteLine("Your number in roman numerals is ");

                switch (numOfDigits)
                {
                    case 1:
                        // convert to roman numeral ones
                        for(int i = 1;  i < 9; i++)
                        {
                            if (i == result)
                            {
                                Console.WriteLine(ones[i - 1]);
                            }
                        }
                        break;

                    case 2:
                        // grab first digit
                        var firstDigit = result / 10;
                        
                        // convert first digit to roman numeral tens
                        for (int i = 1; i < 9; i++)
                        {
                            if (i == firstDigit)
                            {
                                Console.Write(tens[i - 1]);
                            }
                        }

                        // grab second digit
                        var secondDigit = result % 10;

                        // AND convert second digit to roman numeral ones
                        for (int i = 1; i < 9; i++)
                        {
                            if (i == secondDigit)
                            {
                                Console.WriteLine(ones[i - 1]);
                            }
                        }
                        break;

                    case 3:
                        // convert third digit to roman numeral ones
                        // oh god
                        // AND convert second digit to roman numeral tens
                        // AND convert third digit to roman numeral hundreds
                        break;

                    case 4:
                        // convert third digit to roman numeral ones
                        // AND convert second digit to roman numeral tens
                        // AND convert third digit to roman numeral hundreds
                        // AND convert fourth digit to roman numeral thousands 
                        Console.WriteLine("it was four digits");
                        break;

                    default:
                        Console.WriteLine("Whoa, friend! That number is TOO big!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input not valid.");
            }
            Console.ReadLine();
        }
    }
}
