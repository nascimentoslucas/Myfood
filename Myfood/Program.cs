using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfood.Dominio;
using Myfood.FakeDB;
using Myfood.Repositorio;
using Myfood.Servico;
using static System.Net.Mime.MediaTypeNames;

namespace Myfood
{
    public class Program
    {

        public static void Main(string[] args)
        {
            FakeDataBase fakeDB = new FakeDataBase();
            fakeDB.cardapios = PreencherCardapio();
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

        public static void FazerPedido(FakeDataBase fakeDB)
        {
          // bool flag = true;
            PessoaFisicaRepo repositorio = new PessoaFisicaRepo(fakeDB);
            RestauranteRepo repositoriojur = new RestauranteRepo(fakeDB);

            //while (flag != false)
            //{

                foreach (var fis in fakeDB.PessoasFisicas)
                {
                repositorio.ReadAll().ForEach(fis => Console.WriteLine(fis.Id + " - " + fis.Nome));
                Console.Write(" Selecione uma das opções...................:");
                int cod = Convert.ToInt32(Console.ReadLine());

                 if (cod == fis.Id)
                    {
                    foreach (var jur in fakeDB.Restaurantes)
                    {
                        repositoriojur.ReadAll().ForEach(jur => Console.WriteLine(jur.Id + " - " + jur.Nome));
                        Console.WriteLine(" - Cardário - ");
                        Console.Write(" Selecione uma das opções...................:");
                        int cod1 = Convert.ToInt32(Console.ReadLine());
                        
                        //        int opcao = Convert.ToInt32(Console.ReadLine());
                    }
                 }
                // RestauranteRepo repositoriojur = new RestauranteRepo(fakeDB);
                // Restaurante restaurante = repositoriojur.ReadOne(1);

                // restaurante.cardapios.ForEach(x=> {
                //     Console.WriteLine(x.Descricao);
                // });
                //Cardapio cardapioExcolheu = fakeDB.cardapios.SingleOrDefault();

                //Pedido pedido = new Pedido(1,cardapioExcolheu);

                //fakeDB.Pedidos.Add(pedido);
                }
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
                    SalvarPessoaFisica(repositorio);
                    repositorio.ReadAll().ForEach(fis => Console.WriteLine(" Você já cadastrou: " + fis.Nome));
                };
                if (opcao == 2)
                {
                    SalvarRestaurante(repositoriojur);
                    repositoriojur.ReadAll().ForEach(jur => Console.WriteLine(" Você já cadastrou: " + jur.Nome));
                };
                if (opcao == 3)
                {
                    flag = true;
                };
                if (opcao != 1 || opcao != 2 || opcao != 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Escolha uma das opcões adequadas");
                };
            }
        }

        private static void SalvarRestaurante(RestauranteRepo repositoriojur)
        {
            {
                Restaurante jur = new Restaurante("R. Paineiras", "Perto dali", "cnpj", "nome", "email", new DateTime(2020, 02, 22), "00000", "cidade", "999999", 1);
                Cardapio car = new Cardapio("produto", "descricao", 2.5, "imagem", 1);

                Console.Write(" Informe o nome do Restaurante: ");
                jur.Nome = Console.ReadLine();

                //Console.Write(" Informe o CNPJ: ");
                //jur.Cnpj = Console.ReadLine();

                //Console.Write(" Informe o Telefone: ");
                //jur.Telefone = Console.ReadLine();

                //Console.Write(" Informe o email: ");
                //jur.Email = Console.ReadLine();

                //Console.Write(" Informe o Endeço: ");
                //jur.Endereco = Console.ReadLine();

                //Console.Write(" Informe Complemento: ");
                //jur.Descricao = Console.ReadLine();

                //Console.Write(" Informe a Cidade: ");
                //jur.Cidade = Console.ReadLine();


                //Console.Write(" Informe o primeiro item do Cardápio: ");
                //car.Produto = Console.ReadLine();
                //Console.Write(" Informe o segundo item do Cardápio: ");
                //car.Descricao = Console.ReadLine();



                Console.WriteLine(" ..............................................");
                repositoriojur.Create(jur);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" Restaurante Criado...");
                Console.WriteLine(" ##############################################");
            }
        }

        private static void SalvarPessoaFisica(PessoaFisicaRepo repositorio)
        {
            PessoaFisica fis = new PessoaFisica("cpf", "nome", "email", new DateTime(2020, 9, 9), "00000", "cidade", "999999", 1);

            Console.Write(" Informe o nome da Pessoa: ");
            fis.Nome = Console.ReadLine();

            //Console.Write(" Informe o CPF: ");
            //fis.Cpf = Console.ReadLine();

            ////Console.Write(" Informe o data de nascimento: ");
            ////fis.DataNascimento = DateTime.Parse(Console.ReadLine());

            //Console.Write(" Informe o Telefone: ");
            //fis.Telefone = Console.ReadLine();

            //Console.Write(" Informe o email: ");
            //fis.Email = Console.ReadLine();

            //Console.Write(" Informe a Cidade: ");
            //fis.Cidade = Console.ReadLine();
            Console.WriteLine(" ..............................................");

            repositorio.Create(fis);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Pessoa Fisica Criada...");
            Console.WriteLine(" ##############################################");
        }


        public static  List<Cardapio>  PreencherCardapio()
        {   
            List<Cardapio> cardapios = new List<Cardapio>();

            cardapios.Add(new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 1));
            cardapios.Add(new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 2));
            cardapios.Add(new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 3));
            cardapios.Add(new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 4));
            cardapios.Add(new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 5));
            cardapios.Add(new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 6));
            //cardapios.Add();
            return cardapios;
        }

     
        public void ImprimirDados()
        {
            

        }
    }
}
