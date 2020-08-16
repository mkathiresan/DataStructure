using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class TwoSumToTarget
    {

            public int[] TwoSum(int[] nums, int target)
            {
                int[] sumindex = new int[2];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            sumindex[0] = i;
                            sumindex[1] = j;
                            return sumindex;
                        }
                    }
                }
                return sumindex;
            }

    }
}
