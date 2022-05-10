using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    internal class Circle : IAreaFigures
    {
       private double radius;
       public Circle(double radius)
        {
            this.radius = radius;
        }

        public double AreaFigure()
        {
            double area = Math.PI * Math.Pow(radius, 2);
      
            return area;
        }
    }
}
