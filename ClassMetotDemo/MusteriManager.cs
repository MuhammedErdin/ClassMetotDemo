using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi\n" + " Müşteri Kimlik Bilgisi: " + musteri.Identity +
                ", Müşteri Adı:" + musteri.Name +" Müşteri Soyadı:" + musteri.Surname + " Müşteri Yaşı: " + musteri.Age);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri silindi\n" + " Müşteri Adı: " + musteri.Name + " Müşteri Yaşı: " + musteri.Age);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgisi listelendi\n" + " ,Müşteri Adı: " + musteri.Name +
                ", Müşterinin Para Miktarı: " + musteri.AmountOfMoney);
        }
    }
}

