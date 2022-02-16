using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    class TestClass
    {
        public static double SectorSurfaceArea(double r, double h)
        {
            return Math.PI * r * (2 * h + Math.Sqrt(2 * h * r - Math.Pow(h,2)));
        }  

        public void css()
        {
            Console.WriteLine("wwww");
        }
    }
}
