using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3805
{
    public class Karyawan
    {
        private object a;

        public string NIK { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

        public void tambah()
        {
            Console.WriteLine("No. NIK      Nama  Gaji Bulanan");
            Console.WriteLine("==================================");
            Console.WriteLine("1.  " + NIK + " " + Nama + " " +  Gaji);
        }

        public void tambah2()
        {
            Console.WriteLine("2.  " + NIK + " " + Nama + "  " + Gaji);
        }

    }
        
}
