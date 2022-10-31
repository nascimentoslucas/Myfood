using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfood.Dominio;
using Myfood.FakeDB;
using Myfood.Repositorio;
using Myfood.Servico;

namespace Myfood
{
    public class Program
    {

        public static void Main(string[] args)
        {
            FakeDataBase fakeDB = new FakeDataBase();
            fakeDB.cardapios = Preencher();
            menu(fakeDB);
        }
        private static void menu(FakeDataBase fakeDB)
        {
            bool flag = false;
            while (flag != true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" ..............................................");
                Console.WriteLine(" .            - Bem Vindo ao Myfood -         .");
                Console.WriteLine(" ..............................................");
                Console.WriteLine(" .        1 - Cadastrar Pessoa                .");
                Console.WriteLine(" .        2 - Fazer Pedido                    .");
                Console.WriteLine(" .        3 - Sair                            .");
                Console.WriteLine(" ..............................................");
                Console.Write(" Selecione uma das opções...................:");
                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CadastrarPessoa(fakeDB);
                        break;
                    case 2:
                        FazerPedido(fakeDB);
                        break;
                    case 3:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine(" Escolha uma das opcoes adequadas");
                        break;
                }
            }
        }

        private static void FazerPedido(FakeDataBase fakeDB)
        {
            RestauranteRepo repositoriojur = new RestauranteRepo(fakeDB);


            Restaurante restaurante = repositoriojur.ReadOne(1);

            restaurante.cardapios.ForEach(x=> {
                Console.WriteLine(x.Descricao);
            });
           Cardapio cardapioExcolheu = fakeDB.cardapios.SingleOrDefault();

           Pedido pedido = new Pedido(1,cardapioExcolheu);

           fakeDB.Pedidos.Add(pedido);

        }

        private static void CadastrarPessoa(FakeDataBase fakeDB)
        {
            bool flag = false;
            PessoaFisicaRepo repositorio = new PessoaFisicaRepo(fakeDB);
            RestauranteRepo repositoriojur = new RestauranteRepo(fakeDB);

            while (flag != true)
            {
                Console.WriteLine("");
                Console.WriteLine(" ..............................................");
                Console.WriteLine(" .            - Bem Vindo ao Myfood -         .");
                Console.WriteLine(" ..............................................");
                Console.WriteLine(" .        1 - Fisica                          .");
                Console.WriteLine(" .        2 - Restaurante (Juridica)          .");
                Console.WriteLine(" .        3 - Voltar                          .");
                Console.WriteLine(" ..............................................");
                Console.Write(" Selecione uma das opções...................:");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    salvarPessoaFisica(repositorio);
                    repositorio.ReadAll().ForEach(fis => Console.WriteLine(" Você já cadastrou: " + fis.Nome));
                };
                if (opcao == 2)
                {
                    salvarRestaurante(repositoriojur);
                    repositoriojur.ReadAll().ForEach(jur => Console.WriteLine(" Você já cadastrou: " + jur.Nome));
                };
                if (opcao == 3)
                {
                    flag = true;
                };
                if (opcao != 1 && opcao != 2 && opcao != 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Escolha uma das opcões adequadas");
                };
            }
        }

        private static void salvarRestaurante(RestauranteRepo repositoriojur)
        {
            {
                Restaurante jur = new Restaurante("R. Paineiras", "Perto dali", "cnpj", "nome", "email", new DateTime(2020, 02, 22), "00000", "cidade", "999999", 0);

                Console.Write(" Informe o nome do Restaurante: ");
                jur.Nome = Console.ReadLine();

                Console.Write(" Informe o CNPJ: ");
                jur.Cnpj = Console.ReadLine();

                Console.Write(" Informe o Telefone: ");
                jur.Telefone = Console.ReadLine();

                Console.Write(" Informe o email: ");
                jur.Email = Console.ReadLine();

                Console.Write(" Informe o Endeço: ");
                jur.Endereco = Console.ReadLine();

                Console.Write(" Informe Complemento: ");
                jur.Descricao = Console.ReadLine();

                Console.Write(" Informe a Cidade: ");
                jur.Cidade = Console.ReadLine();
                Console.WriteLine(" ..............................................");
                repositoriojur.Create(jur);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" Restaurante Criado...");
                Console.WriteLine(" ##############################################");
            }
        }

        private static void salvarPessoaFisica(PessoaFisicaRepo repositorio)
        {
            PessoaFisica fis = new PessoaFisica("cpf", "nome", "email", new DateTime(2020, 9, 9), "00000", "cidade", "999999", 1);

            Console.Write(" Informe o nome da Pessoa: ");
            fis.Nome = Console.ReadLine();

            Console.Write(" Informe o CPF: ");
            fis.Cpf = Console.ReadLine();

            //Console.Write(" Informe o data de nascimento: ");
            //fis.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write(" Informe o Telefone: ");
            fis.Telefone = Console.ReadLine();

            Console.Write(" Informe o email: ");
            fis.Email = Console.ReadLine();

            Console.Write(" Informe a Cidade: ");
            fis.Cidade = Console.ReadLine();
            Console.WriteLine(" ..............................................");

            repositorio.Create(fis);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Pessoa Fisica Criada...");
            Console.WriteLine(" ##############################################");
        }


        private static  List<Cardapio>  Preencher()
        {   List<Cardapio> cardapios = new List<Cardapio>();
            Cardapio cardapio = new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 1);
            cardapios.Add(cardapio);

            return cardapios;
        }
        private static void ExecutaBackup()
        {
            throw new NotImplementedException();
        }
    }
}
