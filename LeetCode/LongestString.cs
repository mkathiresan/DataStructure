using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    //class LongestString
    //{
    //    static void Main(string[] args)
    //    {
    //        LongStr solution = new LongStr();
    //        int[] nums = {-1,0,1,2,-1,-4};
    //        solution.LengthOfLongestSubstring("dvdfdasb");
    //    }
    //}


    public class LongestString
    {
        public int LengthOfLongestSubstring(string s)
        {
            string longstr = "";
            int strLength = 0;
            int maxLength = 0;
            string subs = "";
            string strcontains = "";
            int prevloc = 0;
            for (int i = 0; i < s.Length; i++)
            {
                subs = s.Substring(i, 1);
                if (longstr.Contains(subs))
                {
                    if (strLength > maxLength)
                        maxLength = strLength;
                    if (!strcontains.Contains(subs))
                        strcontains += subs;

                    prevloc = s.LastIndexOf(subs, i-1);
                    longstr = s.Substring(prevloc+1, i-prevloc);
                    strLength = longstr.Length;
                }
                else
                {
                    strLength += 1;
                    longstr += s.Substring(i, 1);
                }
            }
            if (strLength > maxLength)
                maxLength = strLength;
            return maxLength;
        }
    }

}
