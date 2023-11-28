using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalendrome(string word)
        {
            if (word == null || word.Length == 0)
            {
                return false;
            }

            string wordLowered = word.ToLower();

            string front = "";
            string back = "";

            for (int i = wordLowered.Length - 1; i >= 0; i--)
            {
                back += wordLowered[i];
            }
            if(wordLowered == back)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
