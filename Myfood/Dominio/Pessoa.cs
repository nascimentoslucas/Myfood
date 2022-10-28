using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Dominio
{
    public abstract class Pessoa
    {
        private string nome;
        private string email;
        private DateTime dataNascimento;
        private string telefone;
        private string cidade;
        private string password;
        private int id;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNascimento { get => DataNascimento; set => DataNascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public Pessoa()
        { }

        public Pessoa(string nome, string email, DateTime dataNascimento, string telefone, string cidade, string password, int id)
        {
            this.nome = nome;
            this.email = email;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.cidade = cidade;
            this.password = password;
            this.id = id;
        }
    }


}

