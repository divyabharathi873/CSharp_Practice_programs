using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_andStrings
{
    internal class Program
    {
        public int LengthOfLongestSubstring(string s)
        {
            StringBuilder sb = new StringBuilder();
            string ln = "";
            Dictionary<char, int> dn = new Dictionary<char, int>();
            if (s.Length == 1)
            {
                return 1;
            }
            foreach (char c in s)
            {
                if (!dn.ContainsKey(c))
                {
                    dn.Add(c, 0);
                    sb.Append(c.ToString());
                }
                else
                {
                    ln = (sb.Length>ln.Length)? sb.ToString() : ln.ToString();
                     dn.Clear();
                        sb.Length = 0;
                        dn.Add(c, 0);
                        sb.Append(c.ToString());
                    }
                }
            ln = (sb.Length > ln.Length) ? sb.ToString() : ln.ToString();
            Console.WriteLine(ln);
            return Math.Max(sb.Length,ln.Length);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.LengthOfLongestSubstring("dvvdf"));
        }
    }
}
