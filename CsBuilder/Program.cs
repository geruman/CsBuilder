using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            DroidBuilder simpleBuilder = new SimpleDroidBuilder();
            DroidBuilder advancedBuilder = new AdvancedDroidBuilder();
            Droid simpleDroid = simpleBuilder.GetDroid();
            Droid advancedDroid = advancedBuilder.GetDroid();
            Console.WriteLine("A simple droid has");
            PrintDroid(simpleDroid);
            Console.WriteLine("An advanced droid has");
            PrintDroid(advancedDroid);
            Console.ReadKey();
        }
        private static void PrintDroid(Droid droid)
        {
            Console.WriteLine(droid.Laser.Description());
            foreach (Wheel wheel in droid.Wheels)
            {
                Console.WriteLine(wheel.Description());
            }
            foreach (Wing wing in droid.Wings)
            {
                Console.WriteLine(wing.Description());
            }
        }
    }
}
