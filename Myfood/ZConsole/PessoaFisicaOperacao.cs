using Myfood.Dominio;
using Myfood.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.ZConsole
{
    public class PessoaFisicaOperacao
    {
        private PessoaFisicaServ servico;

        public PessoaFisicaOperacao()
        {
            this.servico = new PessoaFisicaServ();
        }

        public void ListarTodos()
        {
            List<PessoaFisica> pfs = this.servico.Brose();
            Console.WriteLine("Listar todas as Pessoas Fisicas:");
            foreach (PessoaFisica item in pfs)
            {
                Console.WriteLine("Nome: {0} - Telefone: {1}", item.Nome, item.Telefone);
            }
        }
    }
}
