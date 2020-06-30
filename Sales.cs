using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiKaryawan2723.ClassInduk;
namespace AplikasiKaryawan2723.ClassAnak

{
    public class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }
        

        public override int Gaji() => JumlahPenjualan * Komisi;

    }
}
