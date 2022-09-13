using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {

        List<string> result = new List<string>();
        Dictionary<char, List<char>> dictnry = new Dictionary<char, List<char>>();
        public IList<string> LetterCombinations(string digits)
        {

            dictnry.Add('2', new List<char> { 'a', 'b', 'c' });
            dictnry.Add('3', new List<char> { 'd', 'e', 'f' });
            dictnry.Add('4', new List<char> { 'g', 'h', 'i' });
            dictnry.Add('5', new List<char> { 'j', 'k', 'l' });
            dictnry.Add('6', new List<char> { 'm', 'n', 'o' });
            dictnry.Add('7', new List<char> { 'p', 'q', 'r', 's' });
            dictnry.Add('8', new List<char> { 't', 'u', 'v' });
            dictnry.Add('9', new List<char> { 'w', 'x', 'y', 'z' });
            return helper(digits, 0, new StringBuilder());

        }

        public List<string> helper(string digits, int i, StringBuilder sb)
        {
            if (i == digits.Length)
            {
                result.Add(sb.ToString());
            }
            else
            {
                Console.WriteLine(digits[i]);
                foreach (var cd in dictnry[digits[i]])
                {
                    sb.Append(cd);
                    Console.WriteLine(cd);
                    helper(digits, i + 1, sb);
                    Console.WriteLine("before remove " + sb.ToString() + " " + i.ToString());
                    sb.Remove(sb.Length - 1, 1);
                    Console.WriteLine("after remove " + sb.ToString() + " " + i.ToString());
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Program c = new Program();
            // c.LetterCombinations("23");
            //Generate_paranthesis gp = new Generate_paranthesis();
            // c.result = gp.Generate_para(2);
            //foreach (string s in c.result)
            //{
            //    Console.WriteLine(s);
            //}
            string word = "ABCDH";
            char[,] board = { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' }, { 'I', 'J', 'K', 'L' } };
            word_search ws = new word_search();
            ws.Exist(board, word);
           // ws.solve(word, 0, "", 0, 0, board);
            Console.ReadLine();
        }
    }
    
}


