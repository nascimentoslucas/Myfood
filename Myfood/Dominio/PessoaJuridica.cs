using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Dominio
{
    public class PessoaJuridica : Pessoa
    {
        private string cnpj;

        public string Cnpj { get => cnpj; set => cnpj = value; }

        public PessoaJuridica() : base()
        { }

        public PessoaJuridica(string cnpj, string nome, string email, DateTime dataNascimento, string telefone, string cidade, string password, int id) : base(nome, email, dataNascimento, telefone, cidade, password, id)

        {
            this.cnpj = cnpj;
        }
    }
}
