using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString
{
    public class LongestCommon
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            // edge case of only having one string in strs
            if (strs.Length == 1)
            {
                return strs[0];
            }

            // init output string as a string builder so we can add to it
            StringBuilder outputString = new StringBuilder();

            // need to find the string with the smallest length
            string smallestString = strs[0];
            foreach (string str in strs)
            {
                if (str.Length < smallestString.Length)
                {
                    smallestString = str;
                }
            }

            // edge case to see if the smallest string has no items in it
            if (smallestString.Length == 0)
            {
                return "";
            }

            // loop through the smallest string in the array
            for (int i = 0; i < smallestString.Length; i++)
            {
                // current char that we are comparing to
                char curChar = smallestString[i];

                // loop through each string in the string arrays
                int j = 0;
                while (j < strs.Length)
                {
                    // if it is a match
                    if (strs[j][i] == curChar)
                    {
                        // if we have gone through all the strings in the array
                        // that means it is a match through all of the strings
                        // so we can add it to the outputString
                        if (j == strs.Length - 1)
                        {
                            // add the char to the outputString
                            outputString.Append(strs[j][i]);

                            // if we are at the end of the smallest string, we can't go further so
                            // we have to return the outputString
                            if (i == smallestString.Length - 1) { return outputString.ToString(); }
                        }
                    }
                    // if the current char in the string is not a match with the char we are comparing to
                    else
                    {
                        // we want to return the outputString as is
                        return outputString.ToString();
                    }

                    j += 1;
                }
            }

            return outputString.ToString();
        }
    }
}



// trying to do easier way

// loop through the smallest string in the array
//for (int i = 0; i < smallestString.Length; i++)
//{
//    // current char that we are comparing to
//    char curChar = smallestString[i];

//    // loop through each string in the string arrays
//    for (int j = 0; j < strs.Length; j++)
//    {
//        if (strs[j][i] != curChar)
//        {
//            return outputString.ToString();
//        }
//    }
//    outputString.Append(curChar);
//}