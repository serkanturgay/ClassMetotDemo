using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();//1. Müşteri

            musteri1.Id = 1;
            musteri1.Isim = "Ahmet";
            musteri1.SoyIsim = "Aslan";
            musteri1.Cinsiyet = "Erkek";
            musteri1.Yas = 21;
            
            Musteri musteri2 = new Musteri();//1. Müşteri

            musteri2.Id = 2;
            musteri2.Isim = "Kemal";
            musteri2.SoyIsim = "Kaplan";
            musteri2.Cinsiyet = "Erkek";
            musteri2.Yas = 35;            
            
            Musteri musteri3 = new Musteri();//1. Müşteri

            musteri3.Id = 3;
            musteri3.Isim = "Elif";
            musteri3.SoyIsim = "Yaprak";
            musteri3.Cinsiyet = "Kadın";
            musteri3.Yas = 30;

            MusteriManager musteriManager1 = new MusteriManager();
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("----------------------");
            musteriManager1.musteriList(musteri1);
            musteriManager1.musteriList(musteri2);
            Console.WriteLine("----------------------");

            MusteriManager musteriManager2 = new MusteriManager();
            Console.WriteLine("Yeni Eklenen Müşteriler");
            Console.WriteLine("----------------------");
            musteriManager2.musteriAdd(musteri3);
            Console.WriteLine("----------------------");
        }
    }
}
