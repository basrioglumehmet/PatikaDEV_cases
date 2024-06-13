using System;
using System.Text.RegularExpressions;

namespace case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            */

            List<string> list = new List<string>();

            try
            {
                #region User I/O
                Console.Write("Enter the number of words you will input (n): ");
                string n = Console.ReadLine();
                #endregion

                #region N checks positive number
                if (n != null && n.isInteger())
                {
                    int length = int.Parse(n);
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write($"Insert a word {i + 1}: ");
                        string word = Console.ReadLine();
                        char[] wordChars = word.ToCharArray();
                        Array.Reverse(wordChars);
                        list.Add(new string(wordChars));
                    }

                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid number format. Please enter a word.");
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
