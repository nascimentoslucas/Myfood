using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Myfood.Dominio
{
    public class Restaurante    {

        private string endereco;
        private string nome;
        private string descricao;
        private int id;

        public string Endereco { get => endereco; set => endereco = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => this.descricao; set => this.descricao = value; }
        public int Id { get => id; set => id = value; }
        

        Cardapio cd1 = new Cardapio("coca", "lite", 25, "papa", 01);

    }


}
