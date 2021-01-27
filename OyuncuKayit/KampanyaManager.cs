using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayit
{
    class KampanyaManager : IKampanyaManager
    {
        public void Giris(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya girişi sağlandı.");
        }

        public void Güncelle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }

        public void Sil(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya silindi.");
        }
    }
}
