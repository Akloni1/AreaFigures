using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    internal class Triangle : IAreaFigures
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public double AreaFigure()
        {


            if (firstSide > secondSide && firstSide > thirdSide)
            {
                if ((Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) == Math.Pow(firstSide, 2))
                {
                    return AreaRightTriangle(secondSide, thirdSide);
                }
                else
                {
                    return AreaTriangle(firstSide, secondSide, thirdSide);
                }
            }

            else if (secondSide > firstSide && secondSide > thirdSide)
            {
                if ((Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2)) == Math.Pow(secondSide, 2))
                {
                    return AreaRightTriangle(firstSide, thirdSide);
                }
                else
                {
                    return AreaTriangle(firstSide, secondSide, thirdSide);
                }
            }

            else if (thirdSide > firstSide && thirdSide > secondSide)
            {
                if ((Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)) == Math.Pow(thirdSide, 2))
                {
                    return AreaRightTriangle(firstSide, secondSide);
                }
                else
                {
                    return AreaTriangle(firstSide, secondSide, thirdSide);
                }
            }
            else
            {             
                return AreaTriangle(firstSide,secondSide,thirdSide);
            }
        }

        private double AreaRightTriangle(double cathet1, double cathet2)
        {
            Console.WriteLine("Треугольник прямоугольный");
            return cathet1*cathet2/2;
        }
        private double AreaTriangle(double firstSide, double secondSide, double thirdSide)
        {
            Console.WriteLine("Треугольник не прямоугольный");
            double p = (firstSide + secondSide + thirdSide) / 2;
            double S = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return S;
        }
    }
}
