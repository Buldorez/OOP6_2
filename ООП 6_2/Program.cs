using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_6_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Line a = new Line("2423445256664246");
            a.print();
            Line b = new Line("56774");
            b.print();
            Line c = new Line();
            c.print();

            Console.ReadLine();

        }

        class Line

        {
            public string num;

            public Line()
            {
                num = "Пусто";
            }
            public Line(string Line)
            {
                if (Line.Length > 10)
                    this.num = "Строка слишком длинная.";
                else
                    this.num = Line;
            }
            public void print()
            {
                Console.WriteLine(num);
            }
        
        }

    }

}
