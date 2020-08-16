using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class BinaryReverse
    {
        static void Main1(string[] args)
        {
            UInt32 input = 1234567891;
            UInt32 one = 0b00000000000000000000000000000001;
            UInt32 prefix1 = 0b11111111111111111111111111111111;
            UInt32 prefix0 = 0b01111111111111111111111111111111;
            UInt32 lastbit;
            //0b01010110011011000110001100101010;
            Console.WriteLine("givenbyte {0}", Convert.ToString(input, 2));
            //		0b10000000000000000000000000000000	2147483648	uint
            //0b00000000000000000000000000000001  1   int
            for(int i=0; i<32;i++)
            {
                lastbit = input & one;
                input = UInt32.Parse(((input >> 1).ToString().PadLeft(32,'0')));
                if (lastbit == 1)
                    input = input & prefix1;
                else
                    input = input & prefix0;

                Console.WriteLine("Last bit: {0}", Convert.ToString(input, 2));
            }


            Console.ReadLine();
        }
    }
}
