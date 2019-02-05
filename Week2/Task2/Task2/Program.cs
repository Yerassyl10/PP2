using System;
using System.IO;

namespace Task1
{
    class Program
    {

        public static bool Isprime(int n) 
        {
            if (n == 1)
            {
                return false; 

            }
            if (n == 2)
            {
                return true; 
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false; 

                }
            }
            return true;
        }

        static void Main()
        {

                string str = File.ReadAllText(@"/Users/daniyarbekulyyerassyl/Projects/PP2/Week2/Test.txt");
               
                string[] numbers = str.Split(" ");
                
                int val;

            File.WriteAllText(@"/Users/daniyarbekulyyerassyl/Projects/PP2/Week2/Test2.txt", string.Empty);

            foreach (string s in numbers)

                {

                    val = int.Parse(s);
                    if (Isprime(val))
                    {
                    string sval = val.ToString();

                    File.AppendAllText(@"/Users/daniyarbekulyyerassyl/Projects/PP2/Week2/Test2.txt" , sval + " ");
                }

                
            }


            


        }
    }
}
