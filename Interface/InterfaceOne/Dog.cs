using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceOne
{
    public class Dog
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }

        public Dog(string name,string habitat,string eatingHabit)
        {
            Name=name;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }

        public void DisplayName()
        {
            Console.WriteLine($"Dog name: {Name}");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Dog Info..\nDog name: {Name}\nHabitat: {Habitat}\nEating Habit: {EatingHabit}");
        }
    }
}