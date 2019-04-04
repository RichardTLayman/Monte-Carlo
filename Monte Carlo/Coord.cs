using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{

        struct Coords
        {

            public double x;
            public double y;

            public Coords(Random r)
            {
                this.x = r.NextDouble();
                this.y = r.NextDouble();
            }

            public Coords(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double HypeTri(double x, double y)
            {
                double Hyp = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                return Hyp;
            }
    }
}
