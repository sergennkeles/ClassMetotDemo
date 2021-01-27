using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
 
        public void MusteriEkle(Musteri musteri)
        {
           
            
            string ad, tipi;
            int tc,sayac;

           Console.Write("Kaç tane müşteri eklemek istiyorsunuz? ");// kullanıcıdan kaç tane kayıt gireceği bilgisini aldık.
           sayac = Convert.ToInt32(Console.ReadLine());
            //  Musteri[] musteriler = new Musteri[sayac];//diziye sayac sayısı kadar eleman ekleneceğini belirttik.
            List<Musteri> musteriler = new List<Musteri> { };
            for (int i = 0; i < sayac; i++)//döngü sayac sayısı kadar çalışacak
            {
                 musteri = new Musteri();// her yeni kayıt için musteri class'ını newledik
                Console.Write("Müşteri TC'si: ");//müşteri tc bilgisini aldık.
                tc = Convert.ToInt32(Console.ReadLine());
                musteri.TcNo = tc;

                Console.Write("Müşteri adını ve soyadını giriniz: ");//müşteri adını aldık
                ad = Console.ReadLine();
                musteri.AdSoyad = ad;

                Console.Write("Müşteri Bireysel mi ? Kurumsal mı? : ");//müşteri tipini aldık
                tipi = Console.ReadLine();
                musteri.MusteriTipi = tipi;
                musteriler.Add(musteri);//musteriler dizisinin i'nci elemanına musteri classındaki bilgilerimizi aktardık.
              

            }
            TumMusteriler(musteriler);// TumMusteriler methodu ile Müşteriler dizisindeki elemanları ekranda göster.
           Sil(musteriler);

        }

        public void TumMusteriler(List<Musteri> musteriler)
        {
          
                //musteriler dizisindeki elemanları listele ve aşağıdakim mesajı ekrana yazdır.
                foreach (var item in musteriler)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Tc No'su " + item.TcNo + " olan " + item.AdSoyad + " adlı müşterinin müşteri tipi " + item.MusteriTipi + " olarak ayarlandı.");

                }
            
        
        }

        public void Sil(List<Musteri> musteriler)
        {
            int sil;
            string cevap;
          
            Console.WriteLine();
            Console.Write("Müşteriler bu şekilde kaydedildi. Silmek istediğiniz bir kayıt var mı ? e/h :");
            cevap = Console.ReadLine();

            if (cevap == "e")
            {
                Console.Write("Silmek istediğiniz kaydın id numarasını giriniz: ");
                sil = Convert.ToInt32(Console.ReadLine());

                if (sil > musteriler.Count)
                {
                    Console.WriteLine("Böyle bir kayıt yok!!!!");
                    TumMusteriler(musteriler);
                }
                else
                {

                    musteriler.RemoveRange(sil, sil);
                    TumMusteriler(musteriler);

                   
                }
            }
            else
            {

                TumMusteriler(musteriler);
            }
        }

    }
}
