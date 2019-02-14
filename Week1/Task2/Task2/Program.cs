using System;

namespace Task2

{ 
    class Student
    {
        public string name;
        public int id;
        public static int year =0;



        public Student(string name, int id)
        {
            this.name = name;
            this.id = id;
            year++;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Yerassyl", 10);
            student1.Print();
            Console.WriteLine("Year: " + Student.year);

            Console.WriteLine();

            Student student2 = new Student("Nurassyl", 22);
            student2.Print();
            Console.WriteLine("Year: " + Student.year);

        }
    }
}

