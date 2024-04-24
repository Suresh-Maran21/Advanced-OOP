using System;
namespace AbstractOne;
class Program{
    public static void Main(string[] args)
    {
        Cylinders cylinder = new Cylinders(7,10);
        Cubes cube=new Cubes(10);

        Console.WriteLine($"the area of the cylinder is {cylinder.CalculateArea()}");
        Console.WriteLine($"the volumke of the cylinder is {cylinder.CalculateVolume()}");
        Console.WriteLine($"the area of the cube is {cube.CalculateArea()}");
        Console.WriteLine($"the volume of the cube is {cube.CalculateVolume()}");
    }
}