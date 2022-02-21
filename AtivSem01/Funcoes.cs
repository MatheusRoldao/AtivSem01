using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    class Funcoes
    {
        public static int PegaMatriz(int[,] matriz)
        {
            int ValorSoma = 0;
            try
            {
                foreach (int valor in matriz)
                {
                    ValorSoma += valor;
                }
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }
                 return ValorSoma;
        }

    }
}
