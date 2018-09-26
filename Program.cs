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
                var x = Math.Floor(Math.Log10(result) + 1);
                Console.WriteLine("Your number in roman numerals is");
                switch (x)
                {
                    case 1:
                        // convert to roman numeral ones
                        if (result == 1)
                        {
                            Console.Write("I");
                        }
                        else if (result == 2)
                        {
                            Console.Write("II");
                        }
                        break;

                    case 2:
                        // convert second digit to roman numeral ones
                        // AND convert first digit to roman numeral tens
                        Console.WriteLine("it was two digits");
                        break;

                    case 3:
                        // convert third digit to roman numeral ones
                        // AND convert second digit to roman numeral tens
                        // AND convert third digit to roman numeral hundreds
                        Console.WriteLine("it was three digits");
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
