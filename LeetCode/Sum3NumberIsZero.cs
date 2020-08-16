using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Sum3NumberIsZero
    {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                IList<IList<int>> Parentlist = new List<IList<int>>();
                bool boolflag;

                for (int i = 0; i < nums.Length - 2; i++)
                {
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        for (int k = j + 1; k < nums.Length; k++)
                        {
                            if (nums[i] + nums[j] + nums[k] == 0)
                            {
                                boolflag = true;
                                IList<int> Childlist = new List<int>() { i, j, k };
                                foreach (var templist in Parentlist)
                                {
                                    if (Enumerable.SequenceEqual(templist.OrderBy(t => t), Childlist.OrderBy(t => t)))
                                    {
                                        boolflag = false;
                                        break;
                                    }
                                }
                                if (boolflag)
                                    Parentlist.Add(Childlist);
                            }
                        }
                    }
                }
                return Parentlist.Distinct().ToList();

            }


    }
}
