using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3805
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();
            Karyawan kry2 = new Karyawan();

            bool TambahGaji = true;

            kry1.NIK = "19030123";
            kry1.Nama = "Paijo";
            kry1.Gaji = 3000000;

            kry2.NIK = "19030124";
            kry2.Nama = "Jono";
            kry2.Gaji = 2000000;

            kry1.tambah();
            kry2.tambah2();

            double a = 3000000.0;
            double b = 0.1;
            double c = 2000000.0;
            double hasil1 = (a * b) + a;
            double hasil2 = (c * b) + c;


            if (TambahGaji == true)
            {
                Console.WriteLine("\nAlhamdulillah, Selamat anda mendapat kenaikan gaji\n");
                Console.WriteLine("No. NIK      Nama  Gaji Bulanan(Rp)");
                Console.WriteLine("==================================");
                Console.WriteLine("1.  " + kry1.NIK + " " + kry1.Nama + " " + hasil1);
                Console.WriteLine("2.  " + kry2.NIK + " " + kry2.Nama + "  " + hasil2);
                Console.WriteLine("\n");
            }
            else
                Console.WriteLine("\nMohon maaf belum ada kenaikan gaji\n");

            Console.WriteLine("Press any key....");
            Console.ReadKey();
        }
    }
}
