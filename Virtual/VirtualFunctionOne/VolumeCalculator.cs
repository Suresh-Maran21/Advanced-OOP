using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctionOne
{
    public class VolumeCalculator : Areacalculator
    {
        public double Height {get; set;}
        public VolumeCalculator(double radius,double height) : base(radius)
        {
            Height = height;
        }
        double result;
        public override void Calculate(double height)
        {
            result = Math.PI * Radius * Radius * height;
        }
        public override void Display()
        {
            Console.WriteLine($"Volume = {result}");
        }
    }
}