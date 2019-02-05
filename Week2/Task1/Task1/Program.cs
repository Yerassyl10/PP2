using System;
using System.IO;

namespace Task1
{
    class Program
    {
        public static bool Ispalin(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {

            string text = "Yes";
            string text2 = "No";
            string str = File.ReadAllText(@"/Users/daniyarbekulyyerassyl/Projects/PP2/Week2/Test.txt");
            if (Ispalin(str))
            {
                System.IO.File.WriteAllText(@"/Users/daniyarbekulyyerassyl/Projects/PP2/Week2/Test.txt" , text);
            }
                else 
                {
                System.IO.File.WriteAllText(@"/Users/daniyarbekulyyerassyl/Projects/PP2/Week2/Test.txt" , text2);
            }

        }
    }
}
