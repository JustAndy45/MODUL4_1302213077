using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_1302213077
{
    public class Poskar
    {
        public enum state 
        { 
            Jongkok, 
            berdiri, 
            Terbang, 
            Tengkurap, 
        }
        public enum Tombol
        {
            TombolS, 
            TombolW, 
            TombolX, 
        }
        public class Perubahan
        {
            public state prevstate;
            public state nextstate;
            public Tombol Button;
            public Perubahan(state prevstate, state nextstate, Tombol Button)
            {
                this.prevstate = prevstate;
                this.nextstate = nextstate;
                this.Button = Button;
            }
        }
        public static void Main()
        {
            
        }
        
    }

   
}
