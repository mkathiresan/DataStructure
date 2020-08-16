using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class LongestPrefix
    {
        public static void Main11(string[]  args)
        {
            string[] input = { "aa","a" };
            string commonpre = bettersln(input);
        }

        public static string bettersln(string[] strs)
        {
            string lcp = "";
            if (strs.Length == 0)
                return lcp;
            lcp = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int c = lcp.Length < strs[i].Length ? lcp.Length : strs[1].Length;
                while (c > 0)
                {
                    if (lcp.Substring(0, c) != strs[i].Substring(0, c))
                    {
                        if (--c == 0)
                            return "";
                        lcp = lcp.Substring(0, c);
                    }
                    else
                    {
                        lcp = lcp.Substring(0, c);
                        break;
                    }
                }
            }
            return lcp;
        }
        public static string findlongprefix(string[] input)
        {
            int i = 0;
            string commonprefix = "";
            string prefixchar = "";
            bool preflag=true;
            while(preflag && input.Length>0)
            {
                for (int j=0; j < input.Length; j++)
                {
                    if(input[j].Length > i)
                    {
                        if (j == 0)
                            prefixchar = input[j].Substring(i, 1);
                        if (prefixchar != input[j].Substring(i, 1))
                        {
                            preflag = false;
                            break;
                        }
                    }
                }
                if (preflag)
                {
                    i++;
                    commonprefix += prefixchar;
                }
            }

            return commonprefix;
        }
    }
}
