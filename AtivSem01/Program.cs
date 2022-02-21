using AtivSem01.Controles;
using AtivSem01.MatrizModels;
using System;


namespace AtivSem01.ControladorNumeros
{
    class Program
    {
   
        static void Main(string[] args)
        {           

            var responsivaMatriz = ControladoraMatriz.CriarMatriz();

            var somaDaMatriz = Funcoes.PegaMatriz(responsivaMatriz.Matriz);
          


            Console.WriteLine("\nA SOMA DAS LINHAS E COLUNAS É: {0} ", somaDaMatriz);//exibe a soma das posiçoes da matriz}

            var voltar = ControladorNumeros.GetValor();
            var maiorNumero = (Funcoes.MaiorValor(voltar));
            Console.WriteLine("\nO MAIOR NUMERO RECEBIDO FOI: {0} ", maiorNumero);

            Console.ReadKey();
        }
    }
}
