using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.OpenClose
{
    public class DriveLongRangeBus : DriveCityBus
    {
        public int BusRange { get; set; }
    }
}
