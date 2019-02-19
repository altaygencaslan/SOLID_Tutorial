using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.LiskovsSubstitution
{
    public class LogBusiness
    {
        /*
         Bu prensipte aşağıdaki LogSave metodu çağırılırken metoda 
         LogDB'de gönderilebilir, LogNotepad'de gönderilebilir.
         Prensipte Yerine geçme olarak isimlendirilen bu özellik 
         aslında Interface'ler ile kurgulanır ancak bu şekilde de 
         kullanılabilir.
         */
        public void LogSave(LogBase logBase)
        {
            // logBase verisini kaydedecek
        }
    }
}
