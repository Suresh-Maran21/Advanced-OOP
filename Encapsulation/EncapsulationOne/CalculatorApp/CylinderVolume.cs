using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private double height;
        public double Height {get{return height;}set{height=value;}}
        internal double volume{get {return Area*height;}}

        public double CalculateVolume(double radius,double height)
        {
            this.radius=radius;
            this.height=height;
            return volume;
        }
    }
}