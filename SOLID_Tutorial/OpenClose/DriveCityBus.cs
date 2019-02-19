using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.OpenClose
{
    public class DriveCityBus : DriveCar
    {
        public int BusCapacity { get; set; }
        public int BusDoorCount { get; set; }

    }
}
