using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.InterfaceSegregation
{
    /*
     Bu prensipte Loskovs Substitution prensibinin interface'ler ile daha kurgusal hale gelmiş şeklini görebiliri.
     Prensip Interface'ler ile kod bütünlüğünü, kod temizliğini, yerine geçme prensibini, single responsibility'i sağlar.         
     ILog inputuna sadece ILog'dan türetilmiş bir değer (LogDB, LogNotepad) gelebilir, sadece ILog içinde izin verilen kodlara erişilebilir.
     En iyisi de sisteme yeni bir Log türü (örneğin LogXML)ekleneceği zaman LogBusiness'da değişiklik yapılmaya gerek yoktur. 
     Sadece ILog'dan türeyen yeni bir sınıf oluşturulması yeterlidir. Böylece hızlı ve planlı geliştirilebilirlik de sağlanır.
         */
    public class LogBusiness
    {
        public void GeneralLogSaveMethod(ILog log)
        {
            log.LogSave("log mesajı");
        }
    }
}
