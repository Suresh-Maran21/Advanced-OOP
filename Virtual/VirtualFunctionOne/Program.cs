using System;
using VirtualFunctionOne;
namespace VirtualFuctionOne;
class Program{
    public static void Main(string[] args)
    {
        Areacalculator area=new Areacalculator(20);
        VolumeCalculator volume=new VolumeCalculator(area.Radius,50);
        area.Calculate(area.Radius);
        volume.Calculate(volume.Height);
        area.Display();
        volume.Display();
    }
}
