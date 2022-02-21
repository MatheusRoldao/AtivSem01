using AtivSem01.Controles;
using System;
using System.Runtime.InteropServices;

namespace AtivSem01
{
    class Program
    {
       
        //Fim codigo para controle das propiedade de posição e tamanho da janela Console


        static void Main(string[] args)
        {           

            var responsivaMatriz = ControladoraMatriz.CriarMatriz();

            var somaDaMatriz = Funcoes.PegaMatriz(responsivaMatriz.Matriz);

            Console.WriteLine("\nA SOMA DAS LINHAS E COLUNAS É: {0}", somaDaMatriz);

            Console.ReadKey();
        }
    }
}
