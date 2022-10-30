using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Myfood.Dominio
{
    public class Restaurante: PessoaJuridica  {
    
        private string endereco;
        private string descricao;

        private int cardapioId;

        public Restaurante()
        {
        }

        public Restaurante(string endereco, string descricao, string cnpj, string nome, string email, DateTime dataNascimento, string telefone, string cidade, string password, int id) : base(cnpj, nome, email, dataNascimento, telefone, cidade, password, id)
        {
        }

        public string Endereco { get => endereco; set => endereco = value; }
        public string Descricao { get => this.descricao; set => this.descricao = value; }

    }


}
