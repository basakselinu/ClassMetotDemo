using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Başak Selin";
            musteri1.SoyAd = "Ünsal";
            musteri1.Yas = 24;
            musteri1.MusteriNumarasi = "4538";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Yaren";
            musteri2.SoyAd = "İlikkan";
            musteri2.Yas = 36;
            musteri2.MusteriNumarasi = "6921";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Batuhan";
            musteri3.SoyAd = "Yılmaz";
            musteri3.Yas = 24;
            musteri3.MusteriNumarasi = "7953";

            Musteri[] musleriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Güncelle(musteri3);

            Console.WriteLine("\n---------- MÜŞTERİ BİLGİLERİ ---------");

            musteriManager.Listele(musleriler);


        }
    }
}

//do not repeat yourself - DRY - Clean Code - Best Practice
