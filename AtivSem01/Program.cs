using AtivSem01.Controles;
using System;


namespace AtivSem01
{
    class Program
    {
              

        static void Main(string[] args)
        {           

            var responsivaMatriz = ControladoraMatriz.CriarMatriz();

            var somaDaMatriz = Funcoes.PegaMatriz(responsivaMatriz.Matriz);

            Console.WriteLine("\nA SOMA DAS LINHAS E COLUNAS É: {0}", somaDaMatriz);//exibe a soma das posiçoes da matriz

            Console.ReadKey();
        }
    }
}
