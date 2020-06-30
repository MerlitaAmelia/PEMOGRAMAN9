using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiKaryawan2723.ClassInduk;
namespace AplikasiKaryawan2723.ClassAnak

{
    public class KaryawanTetap : Karyawan
    {
        public int GajiBulanan { get; set; }
        

        public override int Gaji() => GajiBulanan;

    }
}
