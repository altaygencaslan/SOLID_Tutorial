using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tutorial.OpenClose
{
    public class DriveCar
    {
        /*
         Open Close presnsibinde oluşturulan sınıfların içerikleri değiştirilmez,
         Değiştirilmemelidir, bunun yerine bu sınıfları kullanan üst sınıflar oluşturulur. 
         Bu örnekte DriveCar sınıfı temel sınıfımızdır. Bu sınıfı Otobüs sınıfları için
         çevirmek yerine CityBus sınıfına miras verdik be CityBus'ı da LongangeBus sınıfına miras verdik.
         Her sınıf alt sınıfının özelliklerini kullanırken aynı zmaanda kendine has özellikleri de edinmiş oldu
             */
        public string DriverFullName { get; set; }
        public int DriverAge { get; set; }

        public void DriveVehicle(string vehicleName)
        {
            Console.WriteLine(vehicleName + " driving..");
        }
    }
}
