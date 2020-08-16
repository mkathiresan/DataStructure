using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class RotateArray
    {
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    int[] n = RotateNtime1(numbers,3);
        //}

        static int[] RotateNtime(int[] nums, int k)
        {
            int temp = 0;
            int len = nums.Length - 1;
            for (int i = 1; i <= k; i++)
            {
                temp = nums[len];
                for (int r = len; r > 0; r--)
                {
                    nums[r] = nums[r - 1];
                }
                nums[0] = temp;
            }
            return nums;
        }

        static int[] RotateNtime1(int[] nums, int k)
        {
            int len = nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k );
            Array.Reverse(nums, k, len-k);
            return nums;
        }


    }
}
