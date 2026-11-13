using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Questions
{
    public class _4106 : IQuestionSolving
    {
        /*
         * 4106. Find Mismatched Segments Between Two Strings
         * 
         You are given two strings s1 and s2 of the same length.

        My Notes:
        Can the words be different lengths?
        Need to check the index in both words are the same and if they differ, keep going until they don't.  Then add them to the list
        
        A mismatched segment is a maximal contiguous range of indices where the characters of s1 and s2 differ at every index.

        Return a 2D array containing [sub1, sub2] for each mismatched segment, where sub1 and sub2 are the corresponding substrings from s1 and s2, respectively. Return the segments in increasing order of their starting indices. If there are no mismatched segments, return an empty array.

        Example 1:

        Input: s1 = "earth", s2 = "empty"

        Output: [["ar","mp"],["h","y"]]

        Explanation:

        The characters at indices 1 and 2 differ, forming the mismatched segment ["ar","mp"].
        The characters at index 4 differ, forming the mismatched segment ["h","y"].
        Example 2:

        Input: s1 = "action", s2 = "nation"

        Output: [["ac","na"]]

        Explanation:

        The characters at indices 0 and 1 differ, forming the mismatched segment ["ac","na"]. All remaining characters are equal in both strings.

        Example 3:

        Input: s1 = "hot", s2 = "hot"

        Output: []

        Explanation:

        The two strings are identical, so there are no mismatched segments.

 

        Constraints:

        1 <= s1.length == s2.length <= 100
        s1 and s2 consist of lowercase English letters.
         */
        public void Solve()
        {
            var s1 = "hot";
            var s2 = "hot";
            var result = FindMismatchedSegments(s1, s2);
            foreach (List<string> list in result)
            {
                Console.WriteLine($"[{string.Join(", ", list)}]");
            }
        }
        public IList<IList<string>> FindMismatchedSegments(string s1, string s2)
        {
            List<IList<string>> result = new List<IList<string>>();
            int length = s1.Length;
            var sub1 = "";
            var sub2 = "";
            var bFoundMisMatch = false;
            for (int i = 0; i < length; i++)
            {
                if (s1[i] != s2[i])
                {
                    bFoundMisMatch = true;
                    sub1 += s1[i];
                    sub2 += s2[i];
                }
                else bFoundMisMatch = false;
                if (!bFoundMisMatch)
                {
                    if (sub1.Length > 0)
                    {
                        List<string> list = new List<string>();
                        list.Add(sub1);
                        list.Add(sub2);
                        result.Add(list);
                        sub1 = "";
                        sub2 = "";
                    }
                }
            }
            if (sub1.Length > 0)
            {
                List<string> list = new List<string>();
                list.Add(sub1);
                list.Add(sub2);
                result.Add(list);
                sub1 = "";
                sub2 = "";
            }
            return result;
        }
    }
}
