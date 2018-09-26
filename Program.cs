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
            Console.WriteLine("Enter the number you'd like converted to Roman Numerals: ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int result))
            {
                Console.WriteLine(result);
                var x = Math.Floor(Math.Log10(result) + 1);
                
                switch (x)
                {
                    case 1:
                        // convert to roman numeral ones
                        break;

                    case 2:
                        // convert second digit to roman numeral ones
                        // AND convert first digit to roman numeral tens
                        break;

                    case 3:
                        // convert third digit to roman numeral ones
                        // AND convert second digit to roman numeral tens
                        // AND convert third digit to roman numeral hundreds
                        break;

                    case 4:
                        // convert third digit to roman numeral ones
                        // AND convert second digit to roman numeral tens
                        // AND convert third digit to roman numeral hundreds
                        // AND convert fourth digit to roman numeral thousands 
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
