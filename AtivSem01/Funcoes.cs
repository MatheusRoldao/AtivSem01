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
            try//tratamento de exceção
            {
                foreach (int valor in matriz)//laço foreach usado para percorrer a matriz somando suas dependencias
                {
                    ValorSoma += valor;//atribui o valor a  variavel valor da soma
                }
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);//exibição do erro
            }
                 return ValorSoma;//irá retornar a soma de todos as posiçoes
        }

    }
}
