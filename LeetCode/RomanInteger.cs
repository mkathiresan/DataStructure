using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class RomanInteger
    {
        //static void Main(string[] args)
        //{
        //    string val = Int2Roman(8);
        //}

        static string Int2Roman(int v)
        {
            int d = 10;
            int v1 = 0;
            string rs = "";
            Dictionary<int, char> Roman = new Dictionary<int, char >
            { {1, 'I' },{5,'V'},{10,'X'},{50,'L' },{100, 'C' }, {500, 'D'}, {1000,'M'}};

            while(v > 0)
            {
                v1 = v % d;
                if(d == 10)
                {
                    while (v1 > 0)
                    {
                        if (Convert.ToInt16(v1 / 4) > 0)
                        {
                            rs = Roman[5] + rs;
                            v1 = 5-v1;
                            if (v1 < 0)
                                v1 *= -1;
                            else if(v1 == 1)
                            {
                                rs = Roman[1] + rs;
                                v1--;
                            }
                        }
                        else if (v1 < 4)
                        {
                            rs += Roman[1];
                            v1--;
                        }
                    }
                }
                v = v / d;
            }
            return rs;
        }
        static int RomantoInt(string s)
        {
            int rom=0;

            Dictionary<char, int> Roman = new Dictionary<char, int>
            { {'I' , 1 },{'V' , 5 },{'X' , 10 },{'L' , 50 },{'C' , 100 }, {'D' , 500 }, {'M' , 1000 }};

            for(int i = s.Length-1; i>=0; i--)
            {
                if (i < s.Length - 1)
                    if (Roman[s[i]] < Roman[s[i + 1]])
                    {
                        rom -= Roman[s[i]];
                        continue;
                    }
                    rom += Roman[s[i]];
            }
            return rom;
        }

        static uint Roman2Int(string roman)
        {
            uint romanint = 0;
            bool bigflag , bigflagl , bigflagc, bigflagd, bigflagm ;
            bigflag = bigflagl = bigflagc = bigflagd = bigflagm = false;
            string sc = null;
            for(int i = roman.Length-1; i >=0 ; i--)
            {
                sc = roman.Substring(i, 1);
                switch(sc)
                {
                    case "I":
                        if (bigflag)
                        {
                            romanint -= 1;
                            bigflag = false;
                        }
                        else
                            romanint += 1;
                        break;
                    case "V":
                        romanint += 5;
                        bigflag = true;
                        break;
                    case "X":
                        if(bigflagl || bigflagc)
                        {
                            romanint -= 10;
                            bigflagl = false;
                            bigflagc = false;
                        }
                        else
                        {
                            romanint += 10;
                            bigflag = true;
                        }
                        break;
                    case "L":
                        if (bigflagc)
                        {
                            romanint -= 50;
                            bigflagc = false;
                        }
                        else
                        {
                            romanint += 50;
                            bigflagl = true;
                        }
                        break;
                    case "C":
                        if(bigflagd || bigflagm)
                        {
                            romanint -= 100;
                            bigflagd = false;
                            bigflagm = false;
                        }
                        else
                        {
                            romanint += 100;
                            bigflagc = true;
                        }
                        break;
                    case "D":
                        if (bigflagm)
                        {
                            romanint -= 500;
                            bigflagm = false;
                        }
                        else
                        {
                            romanint += 500;
                            bigflagd = true;
                        }
                        break;
                    case "M":
                        romanint += 1000;
                        bigflagm = true;
                        break;
                }
            }
            return romanint;
        }

    }
}
