using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_11
{
    internal class menuIslemler
    {
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("---Menü---");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Lütfen işleminizi seçiniz : ");
        }

        public void sonucEkranaYaz(decimal kullaniciSayi1 , decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.Clear();
            Console.WriteLine($"{kullaniciSayi1} {operators} {kullaniciSayi2} {sonuc} ");

        }
    }
}
