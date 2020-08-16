using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{

    class ReverseInt
    {

        private static int reversenumber()
        {
            int givenint = -123;
            int reversenumber,rem;
            reversenumber = 0;
            while (givenint!=0)
            {
                rem = givenint % 10;
                givenint = givenint / 10;

                try
                {
                    reversenumber = checked(reversenumber * 10 + rem);
                }catch(OverflowException e)
                {
                    return 0;
                }
                
            }
            return reversenumber;
        }

        private static bool poly(int x)
        {
            char[] revstr = x.ToString().ToCharArray();
            Array.Reverse(revstr);
            string s = new string(revstr);
            if (x == int.Parse(s))
                return true;
            else
                return false;

        }
        private static bool IsPalindrome(int x)
        {
            int givenx = x;
            int reverse, rem;
            reverse = 0;
            while (givenx > 0)
            {
                rem = givenx % 10;
                givenx = givenx / 10;
                try
                {
                    reverse = checked(reverse * 10 + rem);
                }
                catch (OverflowException e)
                {
                    return false;
                }
            }
            if (x == reverse)
                return true;
            else
                return false;
        }
    }
}
