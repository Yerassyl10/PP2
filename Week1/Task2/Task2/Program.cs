using System;

namespace Task2

{ 
    class Student
    {
        public string name;
        public int id;
        public int yearst;

        public Student()
        {
            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());
            yearst = int.Parse(Console.ReadLine());
        }

        public Student(string name, int id, int yearst)
        {
            this.name = name;
            this.id = id;
            this.yearst = yearst;
        }

        public override string ToString()
        {
            return yearst + " " + name + " " + id;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

        Student st = new Student();
      
        Console.WriteLine(st);

        }
    }
}
