using System;

namespace Theary.Epicodus.Palindromes
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a word to see if it's a palindrome: ");
      string response = Console.ReadLine();
      Palindromes palindrome = new Palindromes();
      bool IsPalindromes = palindrome. IsPalindromes(response);
      Console.WriteLine("Is palindrome = " + IsPalindromes);
    }
  }
}
