using System;
namespace CalculatorApp;
class Program{
    public static void Main(string [] args)
    {
        CylinderVolume cylinder=new CylinderVolume();
        cylinder.Radius=5;
        cylinder.Height=10;
        double volume=cylinder.CalculateVolume(cylinder.Radius,cylinder.Height);
        Console.WriteLine($"cylinder volume : {volume}");
        CircleArea circle=new CircleArea();

        double mass= 5;
        Console.WriteLine($"CalculateWeight : {cylinder.CalculateWeight(mass)}");

        double area=circle.CalculatorCircleArea(cylinder.Radius);
        Console.WriteLine($"Circle Area : {area}");
        Console.WriteLine($"value of Area {cylinder.Area}");
    }
}