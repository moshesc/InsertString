using System;

namespace InsertString
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = " Welcome to Csharpstar";
            string insstr = " World !!!";
            Console.WriteLine(str.Insert(22,insstr));
        }
    }
}
