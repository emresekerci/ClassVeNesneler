using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVeNesneler
{
    internal class Person
    {
        public string ad;
        public string soyad;
        public DateTime dogumTarihi;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public void KisiBilgisi()
        {
            Console.WriteLine($"Adı: {Ad}");
            Console.WriteLine($"Soyadı: {Soyad}");
            Console.WriteLine($"Doğum Tarihi: {DogumTarihi}");
            return;
        }

    }
}
