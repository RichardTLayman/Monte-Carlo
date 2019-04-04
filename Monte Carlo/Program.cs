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
            //MonteCarlo("10000000");
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

// Why do we multiply the value from step 5 above by 4?
// To represent a full circle, and not a quarter.

//What do you observe in the output when running your program with parameters of increasing size?
// You draw closer to the absolute value of PI.

// If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
// No. Fresh random numbers are generated each time resulting in new data.

// Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of ?
// 10,000,000 was 2.6 Seconds  with a result of 3.1423188

//Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
// Rolling Snake eyes. 1- 36 chance, or a 2.777% chance


