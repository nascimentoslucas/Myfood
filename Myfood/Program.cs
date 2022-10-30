using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfood.Dominio;
using Myfood.Repositorio;
using Myfood.Servico;

namespace Myfood
{
    public class Program
    {
               
        public static void Main(string[] args)
        {
            menu();
        }

        private static void CadastrarPessoa()
        {
            bool flag = false;
            PessoaFisicaRepo repositorio = new PessoaFisicaRepo();

            while (flag != true)
            {

                Console.WriteLine("1 - Fisica");
                Console.WriteLine("2 - Juridica (Restaurante)");
                Console.WriteLine("3 - Voltar");
                Console.Write("\nSelecione uma das opções:");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao == 1) {
                    salvarPessoaFisica(repositorio);
                    repositorio.ReadAll().ForEach(x=> Console.WriteLine(x.Nome));
                };
                if(opcao == 2) {
                    salvarRestaurante();
                    repositorio.ReadAll().ForEach(x=> Console.WriteLine(x.Nome));
                };
            }
        }

        private static void salvarRestaurante()
        {
            throw new NotImplementedException();
        }

        private static void salvarPessoaFisica(PessoaFisicaRepo repositorio)
        {
            PessoaFisica pessoa;
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe CPF ");
            string cpf = Console.ReadLine();

            Console.Write("Informe Cidade ");
            string cidade = Console.ReadLine();

            pessoa = new PessoaFisica(cpf,nome,"email",new DateTime(2020,9,9),"00000",cidade,"999999",0);

            repositorio.Create(pessoa);

            Console.WriteLine("\nPessoa Fisica Criada");
            Console.WriteLine("...............................");
        }

        private static void menu(){
            bool flag = false;
            while (flag != true)
            {
                Console.Clear();
                Console.WriteLine("................................................");
                Console.WriteLine("              - Bem Vindo ao Myfood -" );
                Console.WriteLine("................................................");
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Fazer Pedido");
                Console.WriteLine("3 - Sair\n");
                //Console.WriteLine("4 - Sair\n");
                Console.Write("Selecione uma das opções:");
                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CadastrarPessoa();
                        break;
                    case 2:
                        FazerPedido();
                        break;
                    case 3:
                        flag = true;
                        //CriarRepositori();
                        break;
                    case 4:
                        flag = true;
                        break;
                    default: 
                        Console.WriteLine("Escolha uma das opcoes adequadas");
                        break;
                }
            }
        }

        private static void FazerPedido()
        {

        }

        private static void ExecutaBackup()
        {
            throw new NotImplementedException();
        }
    }
}
