using Myfood.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.FakeDB
{
    public static class PessoaFisicaFakeDB
    {
        private static List<PessoaFisica> pessoasFisicas;
        public static List<PessoaFisica> PessoasFisicas
        {
            get
            {
                if (pessoasFisicas == null)
                {
                    pessoasFisicas = new List<PessoaFisica>();
                    Preencher();
                }
                return pessoasFisicas;
            }
        }
        private static void Preencher()
        {
            pessoasFisicas.Add(new PessoaFisica("101010","Joao", "joao@gmail.com",new DateTime(28, 01, 1996), "67992861652", "Campo Grande", "joao123", 0));
            pessoasFisicas.Add(new PessoaFisica("101010", "Joao", "joao@gmail.com", new DateTime(28, 01, 1996), "67992861652", "Campo Grande", "joao123", 1));
            pessoasFisicas.Add(new PessoaFisica("101010","Joao", "joao@gmail.com", new DateTime(28, 01, 1996), "67992861652", "Campo Grande", "joao123", 2));
            pessoasFisicas.Add(new PessoaFisica("101010", "Joao", "joao@gmail.com", new DateTime(28, 01, 1996), "67992861652", "Campo Grande", "joao123", 3));
        }

    }
}
