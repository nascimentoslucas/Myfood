using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfood.Dominio;
using Myfood.Repositorio;
using Myfood.Servico;
using Myfood.ZConsole;

namespace Myfood
{
    public class Program
    {
        //private static BaseRepositorio;
        private static PessoaFisicaRepo repositorio;
        
        public static void Main(string[] args)
        {
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

        private static void CadastrarPessoa()
        {
            bool flag = false;

            while (flag != true)
            {
                
                Console.WriteLine("1 - Fisica");
                Console.WriteLine("2 - Juridica (Restaurante)");
                Console.WriteLine("3 - Voltar");
                Console.Write("\nSelecione uma das opções:");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        PessoaFisica pessoaFisica = new PessoaFisica();

                        Console.Write("Informe o nome: ");
                        pessoaFisica.Nome = Console.ReadLine();

                        Console.Write("Informe CPF ");
                        pessoaFisica.Cpf = Console.ReadLine();

                        Console.Write("Informe Cidade ");
                        pessoaFisica.Cidade = Console.ReadLine();

                        Console.WriteLine("\nPessoa Fisica Criada");
                        Console.WriteLine("...............................");
                        //pessoaFisica.Cpf = Console.ReadLine();
                        //Console.WriteLine("Pessoa Fisica Criada");
                        //pessoaFisica.Cpf = Console.ReadLine();
                        //Console.WriteLine("Pessoa Fisica Criada");
                        //pessoaFisica.Cpf = Console.ReadLine();
                        //Console.WriteLine("Pessoa Fisica Criada");
                        //pessoaFisica.Cpf = Console.ReadLine();
                        //Console.WriteLine("Pessoa Fisica Criada");

                        break;
                    case 2:
                        PessoaJuridica pessoaJuridica = new PessoaJuridica();

                        Console.Write("Informe o nome: ");
                        pessoaJuridica.Nome = Console.ReadLine();

                        Console.Write("Informe CPF ");
                        pessoaJuridica.Cnpj = Console.ReadLine();

                        Console.Write("Informe Cidade ");
                        pessoaJuridica.Cidade = Console.ReadLine();

                        Console.WriteLine("\nRestaurante Criado");
                        Console.WriteLine("...............................");
                        break;
                    case 3:
                        flag = true;
                        break;
                }
            }
        }

        private static void FazerPedido()
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            Console.Write("Informe o nome: ");
            pessoaFisica.Nome = Console.ReadLine();

            Console.Write("Informe o CPF: ");
            pessoaFisica.Cpf= Console.ReadLine();

            //Console.Write("Informe o nome: ");
            //cliente.cpf = Console.ReadLine();

        }

        private static void ExecutaBackup()
        {
            throw new NotImplementedException();
        }
    }
}
