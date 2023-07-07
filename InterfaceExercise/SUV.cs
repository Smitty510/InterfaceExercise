using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public bool SpeedLimiter { get; set; }
        public string Logo { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public string Package { get; set; }
        public string CargoSize { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine($"{Owner} loves driving his {Year} {Make} {Model}");
            Console.WriteLine($"Governed?  {SpeedLimiter}  Logo?  {Logo}  Trim Package?  {Package}  Cargo Space?  {CargoSize}");
            Console.WriteLine();
        }
    }
}
