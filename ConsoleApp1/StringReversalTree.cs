using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class StringReversalTree
    {
        public string ReverseString(string str)
        {
            return recur(str, str.Length - 1);
        }
        public string recur(string str, int idx)
        {
            if(idx < 0)
            {
                return "";
            }

            return str[idx] + recur(str, idx - 1);
        }
    }
}
