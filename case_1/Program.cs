using System;
using System.Text.RegularExpressions;

namespace case_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
             * */

            try
            {
                #region User I/O
                Console.Write("How many numbers will you enter ?: ");
                string input = Console.ReadLine();
                #endregion

                #region Is odd or even calculation loop
                if (input != null && input.isInteger())
                {
                    int n = int.Parse(input);

                    if (n > 0)
                    {
                        Console.WriteLine($"Enter {n} positive numbers:");

                        for (int i = 0; i < n; i++)
                        {
                            string number = Console.ReadLine();
                            if (number != null && number.isInteger())
                            {
                                int num = int.Parse(number);
                                if (num > 0 && num % 2 == 0)
                                {
                                    Console.WriteLine($"Even number: {num}");
                                }
                                else
                                {
                                    Console.WriteLine($"Odd number: {num}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid number format for input {i + 1}. Please enter a valid positive integer.");
                                i--; // Decrement i to retry the current number input
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Number of entries must be a positive integer.");
                    }
                }
                #endregion
                #region Invalid Input Exception
                else
                {
                    throw new ArgumentException("Invalid input. Please enter a valid positive integer for the count of numbers.");
                }
                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    #region Extension Method
    public static class StringExtensions
    {
        public static bool isInteger(this string input)
        {
            string pattern = @"^[1-9]\d*$"; // Regex pattern to match positive integers (including zero if needed)
            var regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
    #endregion
}
