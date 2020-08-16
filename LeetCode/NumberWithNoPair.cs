using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class NumberWithNoPair
    {
        static int OddNumberArray(int[] nums)
        {
            int s = 0;
            foreach (int i in nums)
                s = s ^ i;
            return s;
        }
    }
}
