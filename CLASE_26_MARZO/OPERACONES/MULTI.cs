using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACONES
{
    public class MULTI
    {
        private double mult1, mult2, resultado3;

        public MULTI()
        {
            this.mult1 = 0;
            this.mult2 = 0;
            this.resultado3 = 0;
        }

        public double Mult1 { get => mult1; set => mult1 = value; }
        public double Mult2 { get => mult2; set => mult2 = value; }
        public double Resultado3 { get => resultado3; set => resultado3 = value; }

        public double RealizaMULTIPLICACION()
        {
            resultado3 = Mult1 * Mult2;
            return resultado3;
        }
    }
}
