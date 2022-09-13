using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_expressions
{
    internal class Program
    {
        public static string LongestPalindrome(string s)
        {
            int n = s.Length;
            int ans_len = 0;
            string ans = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string temp = longest(s, i, i);
                if (temp.Length > ans_len)
                {
                    ans_len = temp.Length;
                    ans = temp;
                }

                temp = longest(s, i, i + 1);

                if (temp.Length > ans_len)
                {
                    ans_len = temp.Length;
                    ans = temp;
                }
            }
            return ans;
        }



        public static string longest(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length)
            {
                if (s[l] == s[r])
                {
                    l--;
                    r++;
                }
                else
                {
                    break;
                }
            }

            string ans = s.Substring(l + 1, r - l - 1);
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("babad"));
            string pattern = @"\d+[\+-*/]\d+";
          //  Regex rg = new Regex(pattern);
            if (!Regex.IsMatch("1231+63218-6846", @"^\d+[\+\-\*\/]\d+$"))
            {
                Console.WriteLine("Doesn't Match");

            }
            else
            {
                Console.WriteLine("Match");
            }
        }
    }
}
