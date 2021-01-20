using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Barış";
            musteri1.MusteriSoyadi = "Özer";
            musteri1.MusteriTel = 0531701556;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Atakan";
            musteri2.MusteriSoyadi = "İlci";
            musteri2.MusteriTel = 0531701889;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriSilme(musteri2);
        }
    }
}
