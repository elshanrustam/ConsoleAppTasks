using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Classes
{
    public class Triangle
    {
        private int side1;
        public int Side1
        {
            get { return side1; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of Triangle can not be zero or negative.");
                }
                side1 = value;
            }
        }

        private int side2;
        public int Side2
        {
            get { return side2; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of Triangle can not be zero or negative.");
                }
                side2 = value;
            }
        }

        private int side3;
        public int Side3
        {
            get { return side3; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of Triangle can not be zero or negative.");
                }
                side3 = value;
            }
        }
        public bool IsExist()
        {
            if ((Math.Abs(side1 - side2) < side3 && side3 < side1 + side2) && (Math.Abs(side2 - side3) < side1 && side1 < side2 + side3) && (Math.Abs(side1 - side3) < side2 && side2 < side1 + side3))
            {
                return true;
            }
            return false;

        }
        public double CalcPerimetr()
        {
            return side1 + side2 + side3;
        }
        public double CalcAreaOfTriangle()
        {
            if (IsExist())
            {
                double halfOfPerimetr = CalcPerimetr() / 2;
                return Math.Sqrt(halfOfPerimetr * (halfOfPerimetr - side1) * (halfOfPerimetr - side2) * (halfOfPerimetr - side3));
            }
            else
            {
                throw new ArgumentException("This Triangle does not exist");
            }
        }
    }
}
