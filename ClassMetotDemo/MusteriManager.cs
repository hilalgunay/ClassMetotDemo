using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {

            Console.WriteLine("Yeni müşteri eklendi.\n" + "Müşteri Id :" + musteri.Id + "\n" + "Müşteri Adı : " + musteri.Ad + "\n" + "Müşteri Soyadı : " + musteri.Soyad + "\n" + "Müşteri Maaşı : " + musteri.Gelir);

        }
        public void Delete (Musteri musteri)
        {
            Console.WriteLine("Müşteri silme işlemi başarıyla gerçekleşmiştir.\n" + "Müşteri Id :" + musteri.Id + "\n" + "Müşteri Adı : " + musteri.Ad + "\n" + "Müşteri Soyadı : " + musteri.Soyad + "\n" + "Müşteri Geliri : " + musteri.Gelir);

        }

        public void Show(Musteri[] musteriler )
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteriler: .\n" + "Müşteri Id :" + musteri.Id + "\n" + "Müşteri Adı : " + musteri.Ad + "\n" + "Müşteri Soyadı : " + musteri.Soyad + "\n" + "Müşteri Maaşı : " + musteri.Gelir);
            }
        }
    }
}
