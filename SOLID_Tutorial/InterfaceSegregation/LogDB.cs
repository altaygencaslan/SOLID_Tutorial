using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.InterfaceSegregation
{
    public class LogDB : ILog
    {
        public void LogSave(string message)
        {
            // DB'ye kaydetme işlemi
        }
    }
}
