using System;

namespace Palindrome
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            bool palindrone = IsPalindrome(word);
            Console.WriteLine($"Is {word} a palindrome: {palindrone}");
            Console.ReadLine();
        }
        public static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string reverseWord = String.Concat(wordArray);
            bool palindrome = false;
            if (word == reverseWord)
            {
                return true;
            }
            return palindrome;
        }


 // TODO: Create a method that recognizes palindromes.
        // The name of the method you create should be IsPalindrome
        // The method should take a string as the input.
        // The method should return a bool - true if the input is a palindrome and false if it is not.
    }
}
