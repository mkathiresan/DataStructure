using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class ValidPara
    {
        //static void Main(string[] args)
        //{
        //    string input = "(])";
        //    bool val = ValidParanthasis(input);
        //}
        private static bool ValidParanthasis(string input)
        {
            Stack paran = new Stack();
            string cc = null;
            string pc = null;
            for(int i=0; i<input.Length;i++)
            {
                cc = input.Substring(i, 1);
                if("{[(".Contains(cc))
                    paran.Push(cc);
                else if("}])".Contains(cc) )
                {
                    if (paran.Count == 0)
                        return false;
                    pc = paran.Peek().ToString();
                    if (cc == "}" && pc == "{")
                        paran.Pop();
                    else if (cc == ")" && pc == "(")
                        paran.Pop();
                    else if (cc == "]" && pc == "[")
                        paran.Pop();
                    else
                        return false;

                }
            }
            if (paran.Count == 0)
                return true;
            else
                return false;
        }
    }
}
