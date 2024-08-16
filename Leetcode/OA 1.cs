using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class OA_1
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            List<string> letterLogFiles = new List<string>();
            List<string> digitLogFiles = new List<string>();

            foreach (string log in logs)
            {
                if (char.IsLetter(log.Split(' ')[1][0])) // is letter log
                {
                    letterLogFiles.Add(log);
                }
                else // is digit log
                {
                    digitLogFiles.Add(log);
                }
            }

            // sort letter logs
            List<string> sortedLetterLogs = letterLogFiles.OrderBy(log =>
            {
                var parts = log.Split(new[] { ' ' }, 2);
                return parts[1]; // sort by contents first
            }).ThenBy(log =>
            {
                var parts = log.Split(new[] { ' ' }, 2);
                return parts[0];
            }).ToList();

            sortedLetterLogs.AddRange(digitLogFiles);
            return sortedLetterLogs.ToArray();
        }


        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            GenerateParenthesisRecursive(n, 0, 0, "", result);
            return result;
        }

        private static void GenerateParenthesisRecursive(int n, int open, int close, string current, List<string> result)
        {
            // base case
            if (current.Length == n * 2)
            {
                result.Add(current);
                return;
            }

            if (open < n)
            {
                // add opening parenthesis
                // recursive call
                GenerateParenthesisRecursive(n, open + 1, close, current + "(", result);
            }

            if (close < open)
            {
                // add closing parenthesis
                // recursive call
                GenerateParenthesisRecursive(n, open, close + 1, current + ")", result);
            }
        }
    }
}
