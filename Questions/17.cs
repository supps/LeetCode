using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Questions
{
    public class _17 : IQuestionSolving
    {
        /*
         * 17. Letter Combinations of a Phone Number
         * https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
         * 
            My Notes:
            I know I will need to use recursion on this one.
        
            Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

            A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

            Example 1:

            Input: digits = "23"
            Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
            Example 2:

            Input: digits = "2"
            Output: ["a","b","c"]
 

            Constraints:

            1 <= digits.length <= 4
            digits[i] is a digit in the range ['2', '9'].         
         */

        Dictionary<char, string> digitToLetters = new Dictionary<char, string>
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };
        public void Solve()
        {
            var digits = "23";
            var result = LetterCombinations(digits);
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
        public IList<string> LetterCombinations(string digits)
        {
            List<string> output = new List<string>();
            Backtrack("", digits, output);
            return output;
        }

        public void Backtrack(string combination, string nextDigits, List<string> output)
        {
            // If there is no more digits to check
            if (nextDigits.Length == 0)
            {
                // The combination is done
                output.Add(combination);
            }
            else
            {
                // Iterate over all letters which map the next available digit
                char digit = nextDigits[0];
                string letters = digitToLetters[digit];
                foreach (char letter in letters)
                {
                    // Append the current letter to the combination and proceed to the next digits
                    Backtrack(combination + letter, nextDigits.Substring(1), output);
                }
            }
        }
    }
}
