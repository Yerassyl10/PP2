using System;
using System.IO;
using System.Xml.Serialization;

namespace Task1
{

    [Serializable]
    public class Complexn
    {
        public double realn { get; set; }
        public double imagn { get; set; }


        public Complexn()
        { }

        public Complexn(double realn, double imagn)
        {
            this.realn = realn;
            this.imagn = imagn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Complexn complexn = new Complexn(1, 2);
            Console.WriteLine("Complex number is created");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Complexn));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, complexn);

                Console.WriteLine("The Complex number is serialized");
            }

            // десериализация
            using (FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate))
            {
                Complexn newPerson = (Complexn)formatter.Deserialize(fs);

                Console.WriteLine("The Complex number is deserialized");
                Console.WriteLine("Real number: {0} --- Imaginary Number: {1}", complexn.realn, complexn.imagn);
            }


        }
    }
}