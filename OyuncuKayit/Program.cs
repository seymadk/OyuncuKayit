using System;

namespace OyuncuKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Id = 1;
            oyuncu1.Ad = "Şeymanur";
            oyuncu1.Soyad = "Diktaş";
            oyuncu1.TcNo = "11111111111";
            oyuncu1.DogumTarihi = "01/01/1995";

            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.Id = 2;
            oyuncu2.Ad = "Fatma";
            oyuncu2.Soyad = "Ayşe";
            oyuncu2.TcNo = "22222222222";
            oyuncu2.DogumTarihi = "01/01/1996";

            Oyuncu oyuncu3 = new Oyuncu();
            oyuncu3.Id = 3;
            oyuncu3.Ad = "Nazlı";
            oyuncu3.Soyad = "Melek";
            oyuncu3.TcNo = "33333333333";
            oyuncu3.DogumTarihi = "01/01/1997";

            Edevlet edevlet = new Edevlet();
            edevlet.Doğrula(oyuncu1);
            edevlet.Doğrula(oyuncu2);
            edevlet.Doğrula(oyuncu3);

            Oyun oyun1 = new Oyun();
            oyun1.Id = 1;
            oyun1.OyunAdi = "Pubg";
            oyun1.OyunFiyati = "24,99";

            Oyun oyun2 = new Oyun();
            oyun2.Id = 2;
            oyun2.OyunAdi = "Metin2";
            oyun2.OyunFiyati = "29,90";

            Oyun oyun3 = new Oyun();
            oyun3.Id = 3;
            oyun3.OyunAdi = "Call of Duty";
            oyun3.OyunFiyati = "34,90";

            Kampanya kampanyaYok = new Kampanya();


            Kampanya kampanya1 = new Kampanya();
            kampanya1.KampanyaAdi = "İlk üyelik indirimi";
            kampanya1.KampanyaSüresi = "3 ay";
            kampanya1.KampanyaIndirimi = "%50 indirim";

            Kampanya kampanya2 = new Kampanya();
            kampanya2.KampanyaAdi = "Yılbaşı indirimi";
            kampanya2.KampanyaSüresi = "1 ay";
            kampanya2.KampanyaIndirimi = "%25 indirim";

            Kampanya kampanya3 = new Kampanya();
            kampanya3.KampanyaAdi = "Efsane Cuma indirimi";
            kampanya3.KampanyaSüresi = "15 gün";
            kampanya3.KampanyaIndirimi = "%20 indirim";

            OyunSatis oyunsatis = new OyunSatis();
            oyunsatis.Satis(oyuncu1, oyun1, kampanya1);
            oyunsatis.Satis(oyuncu2, oyun2, kampanya2);
            oyunsatis.Satis(oyuncu3, oyun3, kampanya3);

        }
    }
}
