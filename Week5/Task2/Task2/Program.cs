using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Task2
{
    public class Marks
    {

        public int mark;
        public string point;
        public string str;
        public Marks() { }
        public Marks(int mark, string point)
        {
            this.mark = mark;
            this.point = point;

        }
       

    }

    class Program
    {

        static string getLetter(int a)
        {
            if (a >= 95) return "A";
            else if (a < 95 && a >= 90) return "A-";
            else if (a < 90 && 85 <= a) return "B+";
            else if (a < 85 && 80 <= a) return "B";
            else if (a < 80 && 75 <= a) return "B-";
            else if (a < 75 && 70 <= a) return "C+";
            else if (a < 70 && 65 <= a) return "C";
            else if (a < 65 && 60 <= a) return "C-";
            else if (a < 60 && 55 <= a) return "D+";
            else  if(a < 55 && 50 <= a) return "D-";
            return "0";
           
        }

        static void Main(string[] args)
        {
        
            List<Marks> myList = new List<Marks>();
            myList.AddRange(new Marks[]{
                new Marks(95, getLetter(95)),
                new Marks(83, getLetter(83)),
                new Marks(60, getLetter(60))
        });
            

            //Serialize
            FileStream fs1 = new FileStream("test.xml", FileMode.OpenOrCreate);

            XmlSerializer formatter = new XmlSerializer(typeof(List<Marks>));

            formatter.Serialize(fs1, myList);

                fs1.Close();


            //Deserialize
            FileStream fs2 = new FileStream("test.xml", FileMode.OpenOrCreate);

            List<Marks> newmarks = (List<Marks>)formatter.Deserialize(fs2);


        }

    }  

}
