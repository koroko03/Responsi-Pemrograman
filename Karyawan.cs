using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3805
{
    class Karyawan
    {
        // Private variable
        private string NIK;
        private string Nama;
        private int GajiBulanan;

        public Karyawan()
        {
            Nama = "Paijo";
            Nama = "Jono";
            NIK = "19030123";
            NIK = "19030124";
            GajiBulanan = 3000000;
            GajiBulanan = 2000000;
        }

       
        // Method
        public void inisialisasi()
        {
            Console.WriteLine("No.  NIK   Nama  Gaji Bulanan {0}");
            Console.WriteLine("{0}", NIK);
            Console.WriteLine("{0}", Nama);
            Console.WriteLine("{0}", GajiBulanan);

        }

    }
}
