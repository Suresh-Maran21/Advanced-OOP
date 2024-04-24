using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalculatorApp
    {
        protected double radius;
        public double Radius {get{return radius;} set {radius=value;}}
        internal double Area {get{return PI*radius*radius;}}
        public double CalculatorCircleArea(double radius)
        {
            this.radius=radius;
            return Area;
        }
    }
}