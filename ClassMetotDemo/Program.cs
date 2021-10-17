using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Mustafa";
            musteri.Soyad = "Alkaya";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Enes";
            musteri2.Soyad = "Güvenilir";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri);
            musteriManager.MusteriGoster(musteri);
            musteriManager.MusteriGoster(musteri2);

            musteriManager.MusteriSil(musteri);
            musteriManager.MusteriSil(musteri2);

        }
    }
}
