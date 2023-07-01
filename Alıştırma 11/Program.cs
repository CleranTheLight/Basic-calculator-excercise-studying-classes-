using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baslangic:
            menuIslemler Menu= new menuIslemler();
            Menu.menu();
            Matematik matematik= new Matematik();


            int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("1. sayı değerinizi giriniz = ");
            decimal kullaniciSayi1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("2. sayı değerini giriniz = ");
            decimal kullaniciSayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1:
                    sonuc = matematik.toplama(kullaniciSayi1, kullaniciSayi2);
                    Menu.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    System.Threading.Thread.Sleep(1500);
                    break;
                case 2:
                    sonuc = matematik.cikartma(kullaniciSayi1, kullaniciSayi2);
                    Menu.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    System.Threading.Thread.Sleep(1500);
                    break;
                case 3:
                    sonuc = matematik.carpma(kullaniciSayi1, kullaniciSayi2);
                    Menu.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    System.Threading.Thread.Sleep(1500);
                    break;
                case 4:
                    sonuc = matematik.bolme(kullaniciSayi1, kullaniciSayi2);
                    Menu.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    System.Threading.Thread.Sleep(1500);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız.");
                    System.Threading.Thread.Sleep(1500);
                    goto baslangic; 
            }

            Console.Write("Yeniden işlem yapmak istiyor musunuz? E/H");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto baslangic;
            }
        }
    }
}
