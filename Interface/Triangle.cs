using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Triangle : IShape
    {
        public double height { get; set; }
        public double width { get; set; }

        public double side { get; set; }

        public double Area()
        {
            return height * width/2;
        }

        public double perimeter()
        {
            return height + width + side;
        }
    }
}
