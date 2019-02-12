using System;

namespace Theary.Epicodus.Palindromes
{
  public class Palindromes
  {
    public bool IsPalindromes(string word)
    {
      //word, phrase, number, or other sequence of characters that reads the same
      //both backward or forward
      //eg. racecar
      bool IsMatch = true;
      int i = 0;
      int j = word.Length-1;

      while (i != j)
      {
        IsMatch = word[i] == word[j];
        if (!IsMatch)
        {
          break;
        }
        i++;
        j--;
      }

      return IsMatch;
    }
  }
}
