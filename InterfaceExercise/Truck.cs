using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public bool SpeedLimiter { get; set; }
        public string Logo { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public string TypeTires { get; set; }
        public string BedSize { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine($"{Owner} loves driving his {Year} {Make} {Model}");
            Console.WriteLine($"Governed?  {SpeedLimiter}  Logo?  {Logo}  Type of Tires?  {TypeTires}  Bed Size?  {BedSize}");
            Console.WriteLine();
        }
    }
}
