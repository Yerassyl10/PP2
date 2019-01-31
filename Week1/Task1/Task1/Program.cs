using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            static void Main(string[] args)
        {
            {
                int n;

                int cnt = 0;

                n = int.Parse(Console.ReadLine());

                int[] array = new int[n];

                string s = Console.ReadLine();

                string[] ar = s.Split();

                for (int i = 0; i < n; i++)
                {
                    array[i] = int.Parse(ar[i]);
                }


                for (int i = 0; i < array.Length; i++)
                {

                    if (Isprime(array[i]))
                    {
                        cnt++;
                    }
                }

                Console.WriteLine(cnt);

                for (int i = 0; i < array.Length; i++)
                {

                    if (Isprime(array[i]))
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                Console.ReadKey();

            }


        }
    }
}