using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACONES
{
   public class DIVISION
    {
        private double div1, div2, resultado4;

        public DIVISION()
        {
            div1 = 0;
            div2 = 0;
            resultado4 = 0;
        }

        public double Div1 { get => div1; set => div1 = value; }
        public double Div2 { get => div2; set => div2 = value; }
        public double Resultado4 { get => resultado4; set => resultado4 = value; }

        public double RealizaDIVISION()
        {
            if (div2 > 0)
            {
                resultado4 = div1 / div2;
                
            }
            else Console.WriteLine("no se puede realizar");
            return resultado4;
        }
    }
}
