using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACONES
{
    public class SUMA
    {

        private double v1, v2, resultado1;

        public SUMA()
        {
            this.v1 = 0;
            this.v2 = 0;
            this.resultado1 = 0;
        }

        public double V1 { get => v1; set => v1 = value; }
        public double V2 { get => v2; set => v2 = value; }
        public double Resultado { get => resultado1; set => resultado1 = value; }

        public double RealizaSUMA()
        {
            resultado1 = V1 + V2;
            return resultado1;
        }
    }
}
