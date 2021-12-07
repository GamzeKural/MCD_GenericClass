using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.TcKimlikNumarasi = "12345678901";
            m1.musteriNumara = "MS123";
            m1.isim = "Gamze";
            m1.soyisim = "Kural";
            m1.dogumTarihi = DateTime.Parse("07.01.1998");

            MusteriGeneric<int> musteriGeneric1 = new MusteriGeneric<int>();
            musteriGeneric1.id = 1;
            musteriGeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid> musteriGeneric2 = new MusteriGeneric<Guid>();
            musteriGeneric2.musteriNumarasiAl();

            Console.ReadKey();
        }
    }
}
