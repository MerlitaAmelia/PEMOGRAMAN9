using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OPPdanCollection.ClassInduk;
namespace OPPdanCollection.ClassAnak

{
    public class KaryawanHarian : Karyawan
    {
        public int UpahPerJam { get; set; }
        public int JumlahJamKerja { get; set; }
        
        public override int Gaji() => UpahPerJam * JumlahJamKerja;


    }
}
