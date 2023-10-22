using System;
using System.Collections.Generic;
using System.Text;

namespace vowels
{
    public class Solution
    {
        public static string RemoveVowels(string s)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                   c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }

        // Inbuilt Functions - Don't Change the below functions
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }

        static string ConvertIListToArray(IList<string> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "\"" + input[i] + "\""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }

        // Main method to demonstrate the usage
        public static void Main(string[] args)
        {
            string inputString = "leetcodeisacommunityforcoders";
            string result = RemoveVowels(inputString);
            Console.WriteLine(result);
        }
    }
}
