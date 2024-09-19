using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} Müşteri Numarası İle {1} İsimli Müşteri Sisteme Eklendi.", musteri.MusteriNumarasi,musteri.Ad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} Müşteri Numarasına Sahip {1} İsimli Müşteri Sistemden Silindi.", musteri.MusteriNumarasi, musteri.Ad);

        }
        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("{0} Müşteri Numarasına Sahip {1} İsimli Müşterinin Bilgileri Başarıyla Güncellendi.", musteri.MusteriNumarasi,musteri.Ad);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(
                     "\nMüşterinin Adı: " + musteri.Ad +
                     "\nMüşterinin SoyAdı: " + musteri.SoyAd +
                     "\nMüşterinin Yaşı: " + musteri.Yas +
                     "\nMüşteri Numarası: " + musteri.MusteriNumarasi
                     );
            }

        }
    }
}
