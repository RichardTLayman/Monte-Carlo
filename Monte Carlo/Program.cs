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

            Console.WriteLine("Please enter the number of points you want to see:");
            int points = Convert.ToInt32(Console.ReadLine());

            int[] MC = new int[points];
        }
    }
}
