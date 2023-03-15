using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_1302213077
{
    public class KodeBuah
    {
        public enum buah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka,
        }
        public static string getKodeBuah(buah namaBuah)
        {
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "K00", "L00", "M00", "N00", "O00" };
            return kodeBuah[(int) namaBuah];
        }
        
    }
}
