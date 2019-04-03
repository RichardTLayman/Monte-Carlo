using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //Coord point = new Coord();
            MC point; ;

            Console.WriteLine("Please enter the number of points you want to see:");
            int points = Convert.ToInt32(Console.ReadLine());

            MC[] array = new MC[points];

            for (int i = 0; i < array.Length; i++)
            {
                point = new MC(r);
                array[i] = point;
            }
            foreach(MC element in array)
            {
                Console.WriteLine($"{element.HypeTri(element.x, element.y)}");
            }
        }
    }
}
