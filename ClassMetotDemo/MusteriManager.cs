using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " +musteri.Soyad + " Ekleme Başarılı" );
        }
        public void MusteriGoster(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad );
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silme İşlemi Başaralı " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
