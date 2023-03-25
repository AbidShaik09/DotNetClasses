using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Si{
        internal int P;
        internal float R;
        internal int T;
        public Si(int P,float R,int T)
        {
            this.P = P;
            this.R = R; 
            this.T = T;
        }
        public float Calculate()
        {
            float si = (P * T * R) / 100;
            return si;
        }
    }
}
