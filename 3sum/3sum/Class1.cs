using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sum
{
    public class Class1
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
                return 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add(s[0], 0);
            int start = 0;
            int sp = 0;
            int curlen = 0;
            int maxlen = int.MinValue;
            int i = 1;
            for (i = 1; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], i);
                }
                else
                {
                    if (dict[s[i]] >= sp)
                    {
                        curlen = i - sp;

                        if (maxlen < curlen)
                        {
                            maxlen = curlen;
                            start = sp;
                        }
                        sp = dict[s[i]] + 1;
                        dict[s[i]] = i;

                    }
                    //if (maxlen < i - sp)
                    //{
                    //    maxlen = i - sp;
                    //    start = sp;
                    //}
                }
            }

          

            Console.WriteLine(s.Substring(start, maxlen));
            return maxlen;
        }
    
            public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> lst = new List<IList<int>>();
            Array.Sort(nums);
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {

                int l = i + 1;
                int r = n - 1;
                int x = nums[i];
                if (i > 0 && nums[i - 1] == nums[i])
                    continue;
                while (l < r)
                {
                    int threesum = 0;
                    
                    threesum = x + nums[l] + nums[r];
                    if (threesum == 0)
                    {
                        lst.Add(new List<int>() { nums[i], nums[l], nums[r] });
                        l++;
                        r--;
                    }
                    else if (threesum < 0)
                    {
                        l++;
                    }
                    else if (threesum > 0)
                    {
                        r--;

                    }
                    while (l < r && nums[l + 1] == nums[l])
                        l++;
                    while (l < r && nums[r - 1] == nums[r])
                        r--;

                }
            }
            return lst;
        }
        static void Main()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            Class1 c = new Class1();
            var num = c.LengthOfLongestSubstring("aabaab!bb");
            var lst = c.ThreeSum(nums);

            foreach(var item in lst)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1 + " ");
                }
                Console.WriteLine("\n");
            }

        }
    }

    
}
