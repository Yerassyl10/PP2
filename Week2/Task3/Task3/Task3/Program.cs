using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string source = @"/Users/daniyarbekulyyerassyl/Projects/PP2/Week2/Test4.txt";
                string destination = @"/Users/daniyarbekulyyerassyl/Documents/Test4.txt";

           if (Directory.Exists(source))

            {
            
                Console.WriteLine("Your file has already created");
                    return;
            }


           TextWriter tw = new StreamWriter(source, true);
           
           Console.WriteLine("Press Enter to Copy");
           
           
           
           if(Console.ReadKey().Key == ConsoleKey.Enter)
            {

                File.Copy(source,destination, true);

                Console.WriteLine("Copied!");
            }

             Console.WriteLine();

            Console.WriteLine("Press Enter to Delete old file");


            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                File.Delete(source);

                Console.WriteLine("Deleted");
            }

        }

    }
}
