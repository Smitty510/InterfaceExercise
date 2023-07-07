using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public bool SpeedLimiter { get; set; }
        public string Logo { get; set; }
        public bool HasTrunk { get; set; }
        public string TopSpeed { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine($"{Owner} loves driving his {Year} {Make} {Model}");
            Console.WriteLine($"Governed?  {SpeedLimiter}  Logo?  {Logo}  Has a trunk?  {HasTrunk}  Top Speed?  {TopSpeed}");
            Console.WriteLine();
        }
    }   }
   
