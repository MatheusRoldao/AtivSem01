using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtivSem01.MatrizModels;
namespace AtivSem01.ControladorNumeros
{
    internal class ControladorNumeros
    {
        public static ListaDeNumeros GetValor()
        {
            List<decimal> voltarLista = new List<decimal>();
           int Valores = 4;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;//Usados para mudar a cor das letras no console.
            Console.Write(@"                                    
  _   _                                                 
 | \ | |                                                
 |  \| |  _   _   _ __ ___     ___   _ __    ___    ___ 
 | . ` | | | | | | '_ ` _ \   / _ \ | '__|  / _ \  / __|
 | |\  | | |_| | | | | | | | |  __/ | |    | (_) | \__ \
 |_| \_|  \__,_| |_| |_| |_|  \___| |_|     \___/  |___/
                                                        
                                                        
                                           ");
            Console.WriteLine("\nINSIRA 4 NUMEROS ");
            for (int i = 1; i <= 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("INSIRA O NUMERO");
                try
                {
                    voltarLista.Add(decimal.Parse(Console.ReadLine()));
                }
                catch
                {
                    voltarLista.Add(0.00M);                   
                }
            }

            ListaDeNumeros response = new ListaDeNumeros();
            response.ListaDosNumeros = voltarLista;
            
            return response  ;
        }
    }
}

