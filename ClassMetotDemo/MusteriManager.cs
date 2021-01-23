using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriList(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+ "." + musteri.Isim + "  " + musteri.SoyIsim + "  " + musteri.Cinsiyet + "  " + musteri.Yas);
        }
        public void musteriAdd(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + "  " + musteri.SoyIsim +"  "+ "Yeni Müşteri Eklendi");

        }
    }
}
