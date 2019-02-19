using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.LiskovsSubstitution
{
    public class LogDB : LogBase
    {
        public override int LogType
        {
            get
            {
                return 0;
            }
        }
    }
}
