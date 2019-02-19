using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.LiskovsSubstitution
{
    public class LogBase
    {
        public string LogHeader { get; set; }
        public string LogBody { get; set; }
        public DateTime LogDate { get; set; }
        public virtual int LogType { get; }

    }
}
