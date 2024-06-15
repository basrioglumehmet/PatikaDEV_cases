using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Soru - 1
        List<int> numbers = new List<int>();
        while (numbers.Count < 20)
        {
            Console.Write("Enter a positive number: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        List<int> primeNumbers = new List<int>();
        List<int> nonPrimeNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (IsPrime(number))
            {
                primeNumbers.Add(number);
            }
            else
            {
                nonPrimeNumbers.Add(number);
            }
        }

        primeNumbers.Sort((a, b) => b.CompareTo(a));
        nonPrimeNumbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine("Prime numbers (sorted): " + string.Join(", ", primeNumbers));
        Console.WriteLine("Non-prime numbers (sorted): " + string.Join(", ", nonPrimeNumbers));
        Console.WriteLine("Prime count: " + primeNumbers.Count + ", Average: " + (primeNumbers.Count > 0 ? primeNumbers.Average() : 0));
        Console.WriteLine("Non-prime count: " + nonPrimeNumbers.Count + ", Average: " + (nonPrimeNumbers.Count > 0 ? nonPrimeNumbers.Average() : 0));

        // Soru - 2
        int[] numbersArray = new int[20];
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbersArray[i] = num;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                i--;
            }
        }

        Array.Sort(numbersArray);
        int[] smallest3 = numbersArray.Take(3).ToArray();
        int[] largest3 = numbersArray.Reverse().Take(3).ToArray();

        double smallest3Average = smallest3.Average();
        double largest3Average = largest3.Average();
        double totalAverage = smallest3Average + largest3Average;

        Console.WriteLine("Smallest 3 numbers: " + string.Join(", ", smallest3));
        Console.WriteLine("Largest 3 numbers: " + string.Join(", ", largest3));
        Console.WriteLine("Average of smallest 3: " + smallest3Average);
        Console.WriteLine("Average of largest 3: " + largest3Average);
        Console.WriteLine("Total average: " + totalAverage);

        // Soru - 3
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        List<char> vowelList = sentence.Where(c => vowels.Contains(c)).ToList();
        vowelList.Sort();

        Console.WriteLine("Vowels in the sentence: " + string.Join(", ", vowelList));
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
