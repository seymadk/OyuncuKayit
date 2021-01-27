using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayit
{
    class Edevlet : IEdevletManager
    {
        public void Doğrula(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Id);
            Console.WriteLine(oyuncu.Ad);
            Console.WriteLine(oyuncu.Soyad);
            Console.WriteLine(oyuncu.TcNo);
            Console.WriteLine(oyuncu.DogumTarihi);
            Console.WriteLine("E-devlet hesabı doğrulandı!");
            Console.WriteLine("---------------------------------");
        }
    }
}
