using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Identity = 11111111111;
            musteri1.Name = "Ali";
            musteri1.Surname = "Akkaş";
            musteri1.Age = 24;
            musteri1.AmountOfMoney = 24450;

            Musteri musteri2 = new Musteri();
            musteri2.Identity = 22222222222;
            musteri2.Name = "Ökkeş";
            musteri2.Surname = "Kor";
            musteri2.Age = 26;
            musteri2.AmountOfMoney = 500;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Kimlik Bilgisi:" +musteri.Identity + "\nMüşteri Adı:" + musteri.Name + "\nMüşteri Soyadı:" + musteri.Surname + "\nMüşteri Yaşı:" + musteri.Age);
            }
            Console.ReadKey();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
        }
    }
}
