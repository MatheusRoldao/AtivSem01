using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtivSem01.MatrizModels;
namespace AtivSem01
{
    class Funcoes
    {
        //função que irá pegar os numeros da matriz e somar seus valores
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
        /*============================================================================================================================================================================================
        ==============================================================================================================================================================================================*/
       
        //função que irá receber 4 numeros  e mostrarará o seu maior numero
        public static decimal MaiorValor(ListaDeNumeros listaDeNumeros)//criada em static para que somente ela possa receber e calcular o maior valor

        {           
                return listaDeNumeros.ListaDosNumeros.Max(); //Nesse caso será retornado o maior valor da Lista dos numeros
          
            
        }

    }
}
