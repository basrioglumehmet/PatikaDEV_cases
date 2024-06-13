using System;
using System.Text.RegularExpressions;

namespace case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            */

            try
            {
                #region User I/O
                Console.Write("Enter the number of positive numbers you will input (n): ");
                string n = Console.ReadLine();
                Console.Write("Enter a positive number (m): ");
                int m = int.Parse(Console.ReadLine());
                #endregion

                #region N checks positive number
                if (n != null && n.isInteger())
                {
                    int length = int.Parse(n);
                    // Kullanıcının girmiş olduğu sayılardan m'e eşit ya da tam bölünenleri console'a yazdırın.
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write($"Enter positive number {i + 1}: ");
                        int number = int.Parse(Console.ReadLine());
                        if (number % m == 0)
                        {
                            Console.WriteLine($"{number} is divisible by {m}");
                        }
                        else if (number == m)
                        {
                            Console.WriteLine($"{number} is equal to {m}");
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid number format. Please enter a positive integer.");
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
            string pattern = @"^[1-9]\d*$"; // Regex pattern to match positive integers
            var regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
    #endregion
}
