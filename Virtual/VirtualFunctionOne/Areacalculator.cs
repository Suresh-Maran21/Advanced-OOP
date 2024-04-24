using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctionOne
{
    public class Areacalculator
    {
        public double Radius {get; set;}
        public Areacalculator(double radius)
        {
            Radius=radius;
        }
        double result;
        public virtual void Calculate(double radius)
        {
            result = Math.PI * radius * radius;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Area = {result}");
        }
    }
}