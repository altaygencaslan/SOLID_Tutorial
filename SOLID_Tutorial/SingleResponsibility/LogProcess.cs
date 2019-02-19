using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.SingleResponsibility
{
    public class LogProcess
    {
        /*
         * Görüldüğü üzere burda sadece Log ile ilgili işlemler ypaılmaktadır. 
         * Log dışında başka bir işlem yapılacaksa bunun için ayrıca bir class açılmalıdır
         */

        public void LogWrite(string message)
        {
            // Bu metod log db'ye yada notepad'e kaydedilir
        }

        public void LogRead(int id)
        {
            // Bu metod notepad'den veya db'den id bazında log okur
        }

        public void LogSetConfiguration(string[] args)
        {
            // Bu metod log ile ilgili ayarları yapar
        }

        public void LogGetConfiguration(int id)
        {
            // Bu metod log ile ilgili ayarları getirir
        }
    }
}
