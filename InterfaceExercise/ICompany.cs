using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public bool SpeedLimiter { get; set; }
        public string Logo { get; set; }
    }
}
