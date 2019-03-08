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
        public int point { get; set; }
        public string mark { get; set; }

        public Marks() { }
        public Marks(int point, string mark)
        {
            this.mark = mark;
            this.point = point;

        }
        public override string ToString()
        {
            return "The point" + this.point +"(" + this.mark + ")";
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
                else if (a < 55 && 50 <= a) return "D-";
                return "Z";

            }



            


            static void Main(string[] args)
            {

                Marks Mark = new Marks();
                Mark.point = 95;
                Mark.mark = getLetter(Mark.point);

                Marks Mark2 = new Marks();
                Mark2.point = 75;
                Mark2.mark = getLetter(Mark2.point);
                

                List<string> myList = new List<string>();
                myList.Add(Mark.ToString());
                myList.Add(Mark2.ToString());






                //Serialize
                FileStream fs1 = new FileStream("test.xml", FileMode.OpenOrCreate);

                XmlSerializer formatter = new XmlSerializer(typeof(List<string>));

                formatter.Serialize(fs1, myList);

                fs1.Close();


                //Deserialize
                FileStream fs2 = new FileStream("test.xml", FileMode.OpenOrCreate);

                List<string> newmarks = (List<string>)formatter.Deserialize(fs2);


            }

        }

    
}
