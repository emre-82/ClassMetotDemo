using System;
using System.Collections.Generic;

namespace OPP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcının seçebileceği kredi seçenekleri

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager esnafKredi = new EsnafKrediManager();



            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();




            //yazılımın seçimden sonra fonksiyona hesap için yollaması 

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredi ,new List<ILoggerService>{ new DatabaseLoggerService(), new SmsLoggerService()});


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
