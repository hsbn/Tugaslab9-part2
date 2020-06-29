using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public int banyakJamKerja { get; set; }
        public int gajiPerJam { get; set; }
        public override double Gaji()
        {

            return banyakJamKerja * gajiPerJam;

        }
    }
}
