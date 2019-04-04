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

            MonteCarlo("10");
            MonteCarlo("100");
            MonteCarlo("1000");
            MonteCarlo("10000");
            Console.ReadKey();

            void MonteCarlo(string number)
            {
                Random r = new Random();
                Coords point = new Coords();
                double counter = 0;

                Console.WriteLine("Please enter the number of points you want to see:");
                //int points = Convert.ToInt32(Console.ReadLine()); if receiving user input
                int points = Convert.ToInt32(number);

                Coords[] array = new Coords[points];

                for (int i = 0; i < array.Length; i++)
                {
                    point = new Coords(r);
                    array[i] = point;
                }
                foreach (Coords coord in array)
                {
                    if (coord.HypeTri(coord.x, coord.y) < 1)
                    {
                        counter++;
                    }
                }

                double counted = counter / array.Length;
                counted = counted * 4;

                Console.WriteLine($" USING {points} POINTS");
                Console.WriteLine($" The number of points overlapping the quarter circle is: {counter}.");
                Console.WriteLine($" The absolute value of the circle is: {counted}.");
                Console.WriteLine();
            }
        }
    }
}
