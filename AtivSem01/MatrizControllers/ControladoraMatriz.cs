using AtivSem01.MatrizModels;//Usado para referenciar o projeto MatrizModels
using System;

namespace AtivSem01.Controles
{
    class ControladoraMatriz
    {
        //Metodo para criar a matriz.
        public static ResponsivaMatriz CriarMatriz() 
        {
            ResponsivaMatriz responsivaMatriz = ObterQuantidadeLinhasEColulunas("LINHAS"); //passado string de controle.

            if(responsivaMatriz.MatrizCheia == true) //if usado para realizar a verificação se é possivel continuar a execução normamlmente.
            {
                var segundaMatrizResponse = ObterQuantidadeLinhasEColulunas("COLUNAS");//passado string de controle. 
                if (segundaMatrizResponse.MatrizCheia == true)
                {
                    responsivaMatriz.Y = segundaMatrizResponse.Y; 
                    var matriz = PreecherMatriz(responsivaMatriz); // metodo utilizado para pegar os valores da matriz.
                   responsivaMatriz.Matriz = matriz;
                    responsivaMatriz.MatrizCheia = true;
                }
                else    //caso seja falso a responsiveMatriz é mudada para falsa e retornada. 
                {
                    responsivaMatriz.MatrizCheia = false;

                }
            }
            return responsivaMatriz;//retorna a responsiveMatriz criada .
        }

        /* ===========================================================================================================================================================================================================================
           =========================================================================================================================================================================================================================== */

        private static ResponsivaMatriz ObterQuantidadeLinhasEColulunas(string exe) //Essa clase foi instanciada com  modificador de acesso Privado para que nenhuma outra classe consiga chama-ló.
       
        {   //variavies instanciada  para serem usadas como recurso para assim  obter os numeros de linhas e colunas.
            bool repeticao = false;
            int valor = 0;
            int somatoriaErros = 0;
            ResponsivaMatriz responsivaMatriz = new ResponsivaMatriz();//Novo objeto instanciado.

            Console.Clear(); //O console.Clear é usado para limpar a tela do console.
            Console.ForegroundColor = ConsoleColor.Yellow;//Usados para mudar a cor das letras no console.
            Console.WriteLine(@"                    _          _       
                   | |        (_)     
  _ __ ___    __ _ | |_  _ __  _  ____
 | '_ ` _ \  / _` || __|| '__|| ||_  /                  
 | | | | | || (_| || |_ | |   | | / / 
 |_| |_| |_| \__,_| \__||_|   |_|/___|
                                      
                                      
");//Exibição de matriz no console        
            Console.WriteLine("INSIRA A QUANTIDADE DE {0} DA MATRIZ",exe);
            try//tratamento de exceção
            {
                valor = Int32.Parse(Console.ReadLine());
                responsivaMatriz.MatrizCheia = true;
            }
            catch
            {
                repeticao = true;
                somatoriaErros++;

                while (repeticao)//laço de repetição usado para exibir a mensagem de erro
                {
                    Console.WriteLine("NÃO  RECONHECIDO COMO UM TIPO INTEIRO, DIGITE  " +
                                      "NOVAMENTE ({0} TENTATIVAS EXCEDENTES)", 3 - somatoriaErros);
                    try//try catch usado para filtrar e exibir mensagens caso ocorra um erro
                    {
                        valor = Convert.ToInt32(Console.ReadLine());
                        repeticao = false;
                       responsivaMatriz.MatrizCheia = true;
                    }
                    catch
                    {
                        if (somatoriaErros < 2) // limitador de tentativas
                        {
                            repeticao = true;
                            somatoriaErros++;
                        }
                        else
                        {
                            repeticao = false;
                            valor = 0;
                            Console.WriteLine("DESCULPE, MAS NÃO FOI POSSIVEL IMPOSSIVEL EXIBIR UMA MATRIZ " +
                              "TE REDIRECIONAREMOS AO INICIO ");
                            responsivaMatriz.MatrizCheia = false;
                        }
                    }

                }

            }
            if (exe == "COLUNAS") responsivaMatriz.Y = valor; // verificção para colocar na propriedade correta
            else responsivaMatriz.X = valor;

            return responsivaMatriz;
        }


        /* ===========================================================================================================================================================================================================================
            =========================================================================================================================================================================================================================== */

        private static int[,] PreecherMatriz(ResponsivaMatriz responsivaMatriz) //TODO criar função especifica para limpar a tela e gerar o padrao inicial de matriz 
        {
            int quantidadeDeValores = responsivaMatriz.Y * responsivaMatriz.X; // Calculo para informar a quantidade de valores que espera-se se recebido
            int[,] matriz = new int[responsivaMatriz.X, responsivaMatriz.Y];

            Console.Clear(); //limpa a tela           

            Console.WriteLine("NECESSÁRIO QUE INFORME OS {0} VALORES PARA O PREENCHIMENTO DA MATRIZ {1}X{2}", quantidadeDeValores,
                               responsivaMatriz.X, responsivaMatriz.Y);
            
            for(int x = 0; x < responsivaMatriz.X; x++) // laço de repetição para percorrer todas linhas atribuindo o valor a tal
            {
                for(var y = 0; y < responsivaMatriz.Y; y++) // laço de repetição para percorrer todas Colunas  atribuindo o valor nela
                {
                    try //Bloco de tratamento para caso o usuario informe um valor invalido
                    {
                        Console.WriteLine("INSIRA O VALOR DA LINHA {0} COLUNA {1}", x + 1, y + 1);
                        matriz[x, y] = Int32.Parse(Console.ReadLine());//conversao para Int32
                    }
                    catch
                    {
                        bool repeticao = true;
                        while (repeticao) //laço de repetiçao para tratamento ate o usuario informar um valor valido
                        {
                            try // Bloco para verificar se o valor é valido e caso não seja permanecer no laço
                            {
                                Console.WriteLine("INVALIDO\n INSIRA O VALOR DA LINHA { 0}  E NA COLUNA { 1}", x++, y++);                        
                                  matriz[x, y] = Int32.Parse(Console.ReadLine());
                                  repeticao = false;                               
                            }
                            catch
                            {
                                repeticao = true;
                            }
                        }
                    }
                }
            }

            return matriz;//retorna a matriz depois de passar pelo tratamento de exceção
        }

    }
}