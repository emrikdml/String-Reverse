using System;
using System.Collections;

namespace String_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "expect";
            var result = ReverseString(str);
            //var result = ReverseUsingStack(str);
            Console.WriteLine(" The reverse string is " + result);
            Console.ReadLine();
        }

        public static string ReverseUsingStack(string a)
        {
            var rev = string.Empty;
            Stack st = new Stack();
            foreach (var t in a)
            {
                st.Push(t);
                while (st.Count>0)
                {
                    rev += st.Pop();
                }
            }

            return rev;

        }
        public static String ReverseString(string v)
        {
            var st = string.Empty;
            char[] a = new char[v.Length];
            var f = 0;
            //var st = string.Empty;
            char[] ar = new char[v.Length];
            int forward = 0;
            var len = v.Length - 1;
            for (int i = len; i >=0; i--)
            {
                ar[forward++] = v[i];
            }
            return new string(ar);
        }
    }
}
