using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
        private string word;
        public string CleanedWord { get; private set; } 

        public PalindromeChecker(string inputWord)
        {
            word = inputWord;
            CleanedWord = CleanInput(word);
        }

        private string CleanInput(string input)
        {
            
            return Regex.Replace(input.ToLower(), @"[^\p{L}\p{Nd}]", "");
        }

        public bool IsPalindrome()
        {
            
            return CleanedWord == new string(CleanedWord.ToCharArray().Reverse().ToArray());
        }
    }
}