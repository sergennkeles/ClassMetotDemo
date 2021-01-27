using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
 
        public void MusteriEkle()
        {
           
            
            string ad, tipi;
            int tc,sayac;

            Console.Write("Kaç tane müşteri eklemek istiyorsunuz? ");// kullanıcıdan kaç tane kayıt gireceği bilgisini aldık.
            sayac = Convert.ToInt32(Console.ReadLine());
            Musteri[] musteriler = new Musteri[sayac];//diziye sayac sayısı kadar eleman ekleneceğini belirttik.

            for (int i = 0; i < sayac; i++)//döngü sayac sayısı kadar çalışacak
            {
                Musteri musteri = new Musteri();// her yeni kayıt için musteri class'ını newledik
                Console.Write("Müşteri TC'si: ");//müşteri tc bilgisini aldık.
                tc = Convert.ToInt32(Console.ReadLine());
                musteri.TcNo = tc;

                Console.Write("Müşteri adını ve soyadını giriniz: ");//müşteri adını aldık
                ad = Console.ReadLine();
                musteri.AdSoyad = ad;

                Console.Write("Müşteri Bireysel mi ? Kurumsal mı? : ");//müşteri tipini aldık
                tipi = Console.ReadLine();
                musteri.MusteriTipi = tipi;
                musteriler[i] =musteri;//musteriler dizisinin i'nci elemanına musteri classındaki bilgilerimizi aktardık.
              

            }
            TumMusteriler(musteriler);// TumMusteriler methodu ile Müşteriler dizisindeki elemanları ekranda göster.
            

        }

        public void TumMusteriler(Musteri[] musteriler)
        {
            string cevap;
            Console.Write("Müşteriler bu şekilde kaydedildi. Silmek istediğiniz bir kayıt var mı ? e/h :");
            cevap = Console.ReadLine();
            if (cevap == "e")
            {
                Sil(musteriler);
            }
            else
            {
                //musteriler dizisindeki elemanları listele ve aşağıdakim mesajı ekrana yazdır.
                foreach (var item in musteriler)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Tc No'su " + item.TcNo + " olan " + item.AdSoyad + " adlı müşterinin müşteri tipi " + item.MusteriTipi + " olarak ayarlandı.");

                }
            }
        
        }

        public void Sil(Musteri[] musteriler)
        {
            int sil;
           
                Console.Write("Silmek istediğiniz kaydın id numarasını giriniz: ");
                sil = Convert.ToInt32(Console.ReadLine());
            if (sil>musteriler.Length)
            {
                Console.WriteLine("Böyle bir kayıt yok!!!!");
                TumMusteriler(musteriler);
            }
            else
            {
                if (Array.IndexOf(musteriler, sil) == -1)// sil değişkenine girilen no, musteriler dizisinde var mı?
                {
                    Array.Clear(musteriler, sil, 1);// eğer varsa musteriler dizisinin sil değişkenine girilen sayısal ne ise o elemanını sil.
                    Console.WriteLine(sil + " no'lu kayıt silindi ");// aslında burada TumMusteriler(musteriler) methodunu çağırıp
                    //kalan müşterileri listelemek istedim. Fakat silme işleminden sonra musteriler dizisinde null kalan değer yüzünden
                    //sürekli hata aldım. Hatayı gideremediğim için bu şekilde mesaj vermekle yetindim. 82.satıra breakpoint atarak 
                    //kaydın gerçekten silinip silinmediğini kontrol edebilirsiniz.

                }
            }
               
           
                
            
         

        }


    }
}
