using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Myfood.Dominio
{
    public class PessoaFisica : Pessoa
    {
        private string cpf;
        public PessoaFisica() : base()
        { }

        public PessoaFisica(string cpf, string nome, string email, DateTime dataNascimento, string telefone, string cidade, string password, int id) : base(nome, email, dataNascimento, telefone, cidade, password, id)

        {
            this.cpf = cpf;
        }

        public void CalculaIdade()
        {
            // Declaração de variáveis.
            DateTime dataNascimento = new DateTime();
            DateTime dataAtual = new DateTime();
            //Recupera a data de hoje.
            dataAtual = DateTime.Now;
            // Recupera a data de nascimento, digitada pelo usuário no TextBox.
            dataNascimento = Convert.ToDateTime(dataNascimento);
            // Recupera a diferença de anos entre a data de nascimento e a data de hoje.
            int idade = dataAtual.Year - dataNascimento.Year;

        }
        public void definirCpf(string cpf){
            this.cpf = cpf;
        }
        public string retornarCpf(){
            return this.cpf;
        }
    }
}
