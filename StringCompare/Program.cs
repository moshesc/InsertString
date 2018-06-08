using System;

namespace StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Csharpstar ";
            string str2 = "CSHARPSTAR";
            Console.WriteLine(string.Compare(str1, str2));
        }
    }
}
