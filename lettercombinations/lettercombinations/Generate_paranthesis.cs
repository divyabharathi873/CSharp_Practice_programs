using System;
using System.Collections.Generic;
namespace Recursion
{
    public class Generate_paranthesis
    {
        List<string> res = new List<string>();
        public List<string> Generate_para(int n)
        {
            
            Helper("", 0, 0, n);
            return res;
        }

        public void Helper(string str, int left,int right, int n)
        {
            if(str.Length==2*n)
            {
                res.Add(str);
            }
            if(left<n)
            {
                string temp1 = str;
                temp1 += "(";
                Helper(temp1, left+1, right, n);
            }
            if (right < left)
            {
                string temp2 = str;
                temp2 += ")";
                Helper(temp2, left, right+1, n);
            }
        }

        
        

    }
}
