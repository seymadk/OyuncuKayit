using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayit
{
    interface IKampanyaManager
    {
        void Giris(Kampanya kampanya);
        void Sil(Kampanya kampanya);
        void Güncelle(Kampanya kampanya);

    }
}
