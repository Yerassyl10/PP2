using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n * 2];
            int j = 0;
            for (int i=0; i<n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());


                array2[j] = array[i];
                array2[j + 1] = array[i]; 

                j = j + 2;


            }
            for (int f = 0; f <(n * 2); f++)
            {

                Console.Write(array2[f] + " ");


            }

        }
    }
}
