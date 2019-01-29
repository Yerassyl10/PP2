using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n];
            int cnt = 0;
            int d = 0;

            for (int i = 0; i < n; i++)

            {
                array[i] = Convert.ToInt32(Console.ReadLine());

                for (int k = 2; k < Math.Sqrt(array[i]); k++)

                {
                    if (array[i] == 2 || array[i] == 3)
                    {
                        array2[d] = array[i];
                        cnt++;
                        d++;
                    }


                    else
                            if (array[i] % k == 0 || array[i] == 1)

                    {
                        break;
                    }


                    else
                    {
                        array2[d] = array[i];
                        d++;
                        cnt++;
                    }



                }


            }
            Console.WriteLine(cnt);
            for (int j = 0; j < cnt; j++)

            {
              
                Console.Write(array2[j] + " ");

            }
        }
    }
}