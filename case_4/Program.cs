using System;

namespace case_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir cümle girmesini isteyin
            Console.Write("Bir cümle yazınız: ");
            string sentence = Console.ReadLine();

            // Kelime ve harf sayısını hesaplayın
            int wordCount = sentence.CountWords();
            int letterCount = sentence.CountLetters();

            // Sonuçları console'a yazdırın
            Console.WriteLine($"Toplam kelime sayısı: {wordCount}");
            Console.WriteLine($"Toplam harf sayısı: {letterCount}");
        }
    }

    public static class StringExtensions
    {
        public static int CountWords(this string sentence)
        {
            // Boşluklara göre ayırarak kelime sayısını hesaplayın
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return 0;
            }
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static int CountLetters(this string sentence)
        {
            // Harf sayısını hesaplayın (sadece alfabetik karakterler)
            int letterCount = 0;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }
            return letterCount;
        }
    }
}
