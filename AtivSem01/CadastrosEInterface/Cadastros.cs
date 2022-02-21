using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace AtivSem01
{
    public abstract class Cadastros : IOperacoesBD
    {
        protected string Conexao { get; set; }


        public void Inserir(string NMarquivo, string x)
        {

            try
            {

                string pasta = Directory.GetCurrentDirectory();
                pasta = Path.Combine(pasta, "BANCO");
                string arquivo = Path.Combine(pasta, NMarquivo);

                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }

                File.AppendAllText(arquivo, x);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;//Usados para mudar a cor das letras no console.
                Console.WriteLine(e.Message);
            }


        }



        public void Alterar(string NMarquivo, string alteracao, string novaX)
        {
            string pasta = Directory.GetCurrentDirectory();
            pasta = Path.Combine(pasta, "BANCO  ");
            string ControleArquivo = Path.Combine(pasta, NMarquivo);

            if (File.Exists(ControleArquivo))
            {
                var archive = File.ReadAllText(ControleArquivo);
                var arrayNovo = archive.Split();
                byte controle = 0;

                foreach (var novo in arrayNovo)
                {
                    if (novo.Contains(alteracao))
                    {
                        arrayNovo[controle].Remove(0);
                        arrayNovo[controle] = novaX;
                    }
                    controle++;//irá somar mais um a varivel de controle
                }

                File.WriteAllLines(ControleArquivo, arrayNovo);//writeallLines irá escrever em todas as suas respectivas linhas
                Console.ForegroundColor = ConsoleColor.Yellow;//Usados para mudar a cor das letras no console.
                Console.WriteLine("ARQUIVO ALTERADO");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;//Usados para mudar a cor das letras no console.
                Console.WriteLine("DADOS INEXISTENTES");
            }
        }

        public void Deletar(string x, string NMarquivo)
        {
            string pasta = Directory.GetCurrentDirectory();
            pasta = Path.Combine(pasta, "BANCO");
            string ControleArquivo = Path.Combine(pasta, NMarquivo);

            if (File.Exists(ControleArquivo))
            {
                var archive = File.ReadAllText(ControleArquivo);
                var arrayNovo = archive.Split();
                var controle = 0;

                foreach (var item in arrayNovo)
                {
                    if (item.Contains(x))
                    {
                        arrayNovo[controle].Remove(0);
                    }
                    controle++;
                }

                File.WriteAllLines(ControleArquivo, arrayNovo);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ARQUIVO DELETADO");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DADO INEXISTENTE");
            }
        }


        public void Pesquisar(string procurar, string NMarquivo)
        {
            string pasta = Directory.GetCurrentDirectory();
            pasta = Path.Combine(pasta, "BANCO");
            string ControleArquivo = Path.Combine(pasta, NMarquivo);

            if (File.Exists(ControleArquivo))
            {
                var file = File.ReadAllText(ControleArquivo);
                var fileArray = file.Split();
                foreach (string item in fileArray)
                {
                    var itemSeparado = item.Split('/');
                    if (itemSeparado.Contains(procurar))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(itemSeparado);
                        Console.WriteLine("ARQUIVO ENCONTRADO");
                    }
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DADOS INEXISTENTES");
            }
        }


    }
    public interface IOperacoesBD
    {
        public void Inserir(string NMarquivo, string X);
        public void Alterar(string NMarquivo, string alteracao, string novaX);
        public void Deletar(string NMarquivo, string X);
        public void Pesquisar(string NMarquivo, string procurar);
    }

    sealed class Clientes : Cadastros
    {
        public void Inserir()
        {
           
            Console.WriteLine("INSIRA O NOME");
            var nomeCliente = Console.ReadLine();
            Console.WriteLine("INSIRA O ENDEREÇO");
            var endereco = Console.ReadLine();
            string seta = nomeCliente + "->" + endereco;
            base.Inserir("CLIENT", seta);
        }

        public void Alterar(string alterarLinha)
        {

            Console.WriteLine("INSIRA O NOME");
            var nomeCliente = Console.ReadLine();
            Console.WriteLine("INSIRA O ENDEREÇO");
            var endereco = Console.ReadLine();
            string seta = nomeCliente + "->" + endereco;
            base.Alterar("CLIENT", alterarLinha, seta);
        }
     
        public  void Deletar(string nomeArquivo, string x)
        {           
            Console.WriteLine("ESTAMOS PROCURANDO  " + x);
            base.Deletar(nomeArquivo, x);
        }
        public void Pesquisar()
        {
            Console.WriteLine("INSIRA O NOME");
            var nomeCliente = Console.ReadLine();
            base.Inserir("cliente", nomeCliente);
        }
    }

    sealed class Pedidos : Cadastros
    {
        public  void Inserir(string NMarquivo, string x)
        {

            {
                string pasta = Directory.GetCurrentDirectory();
                pasta = Path.Combine(pasta, "BANCO");
                string ControleArquivo = Path.Combine(pasta, NMarquivo);

                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }

                File.AppendAllText(ControleArquivo, x);
            }

            //4.6) O método Deletar deve sofrer sobrecarga nas duas Classes, executando o código da Classe Superior e incluindo algo novo

            //4.7) O método Inserir deve sofrer sobrecarga na classe Pedidos, desconsiderando a implementação do método da classe Superior
        }
    }
}

