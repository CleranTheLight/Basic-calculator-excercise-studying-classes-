using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_11
{
    internal class Matematik
    {
        public decimal toplama(decimal sayi1 , decimal sayi2)
        {
            decimal sonuc = sayi1+ sayi2;
            return sonuc;   
            
        }

        public decimal cikartma (decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public decimal carpma (decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1*sayi2;
            return sonuc;
        }

        public decimal bolme(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

       
    }
}
