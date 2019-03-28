using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACONES
{
    public class RESTA
    {
        private double r1,r2,resultado2;

        public RESTA()
        {
            this.r1 = 0;
            this.r2 = 0;
            this.resultado2 = 0;
        }

        public double R1 { get => r1; set => r1 = value; }
        public double R2 { get => r2; set => r2 = value; }
        public double Resultado2 { get => resultado2; set => resultado2 = value; }

        public double RealizaRESTA()
        {
            resultado2 = R1 - R2;
            return resultado2;
        }
    }
}
