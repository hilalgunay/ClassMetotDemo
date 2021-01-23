using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Musteri musteriler1 = new Musteri();
            musteriler1.Id = 1;
            musteriler1.Ad = "Hilal";
            musteriler1.Soyad = "Günay";
            musteriler1.Gelir = 5000;

            Musteri musteriler2 = new Musteri();
            musteriler2.Id = 2;
            musteriler2.Ad = "Nilgün";
            musteriler2.Soyad = "Sengül";
            musteriler2.Gelir = 2500;


            Musteri musteriler3 = new Musteri();
            musteriler3.Id = 3;
            musteriler3.Ad = "Engin";
            musteriler3.Soyad = "Demir";
            musteriler3.Gelir = 7000;

            Musteri[] musteriler = new Musteri[] { musteriler1, musteriler2, musteriler3 };
            MusteriManager musteriManager = new MusteriManager();


            musteriManager.Show(musteriler);
            musteriManager.Add(musteriler1);
            musteriManager.Add(musteriler2);
            musteriManager.Add(musteriler3);
            musteriManager.Delete(musteriler2);



        }
    }
}
