using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {



           // /*
            
            //----------------  Header
            Console.WriteLine("yapmak istediğiniz eylemin değerini giriniz : Müşteri listeleme(1) - " +
                "Müşteri silme(2) - Nüşteri ekleme(3)");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            
            //---------------- header end.

            Musteri musteri1 = new Musteri();
            musteri1.Name = "emre";
            musteri1.surName = "rusen";
            musteri1.tcNo = 111111111;
            musteri1.telNo = 533000;
            musteri1.id = 1;


            Musteri musteri2 = new Musteri();
            musteri2.Name = "ali";
            musteri2.surName = "yılmaz";
            musteri2.tcNo = 2222222;
            musteri2.telNo = 5332222;
            musteri2.id = 2;



            Musteri[] musteriList = new Musteri[] { musteri1 , musteri2 };

            Console.WriteLine("aaaaa");
            Console.WriteLine(musteriList);
           
            if (a == 1)
            {
               
              
            }
            else if (a == 2)
            {
                Console.WriteLine("Hangi Müşteriyi Silmek istiyorsunuz, Lütfen id numarasını giriniz : ");
                Console.WriteLine(" ");



                foreach (var listeleme in musteriList)
                {


                    Console.WriteLine( "Name : " + listeleme.Name + " " + "SurName : "
                        + listeleme.surName + " " + "tcNo : " + listeleme.tcNo + " " + "tel No : " + listeleme.telNo
                        + " " + "id : " + listeleme.id);

                   
                }

                
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                int b;
                b = Convert.ToInt32(Console.ReadLine());

                if (b == musteri2.id || b == musteri1.id)
                {
                    MusteriManager musteriManager = new MusteriManager();
                    musteriManager.delete(b);
                }
                else
                {
                    Console.WriteLine("Yanlış İd girdiniz");
                }

                foreach (var listeleme in musteriList)
                {


                    Console.WriteLine("Name : " + listeleme.Name + " " + "SurName : "
                        + listeleme.surName + " " + "tcNo : " + listeleme.tcNo + " " + "tel No : " + listeleme.telNo
                        + " " + "id : " + listeleme.id);


                }

            }

            //*/




        }
    }
}
