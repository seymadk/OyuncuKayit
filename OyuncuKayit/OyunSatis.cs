using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayit
{
    class OyunSatis : Oyuncu
    {
        public void Satis(Oyuncu oyuncu, Oyun oyun, Kampanya kampanya)
        {

            Console.WriteLine(oyuncu.Ad + "   " + oyuncu.Soyad);
            Console.WriteLine(oyun.OyunAdi + "   " + oyun.OyunFiyati);
            Console.WriteLine(kampanya.KampanyaAdi + "   " + kampanya.KampanyaIndirimi + "   " + kampanya.KampanyaSüresi);
            Console.WriteLine("Kampanyalı oyun satışı yapıldı.");
            Console.WriteLine("-----------------------------");
        }
    }
}
