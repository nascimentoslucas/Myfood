using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Dominio
{
    public class Cardapio
    {
        private int id;
        private string produto;
        private string descricao;
        private double valor;
        private string imagem;
    

        public string Produto { get => produto; set => produto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public int Id { get => id; set => id = value; }

        public Cardapio(string produto, string descricao, double valor, string imagem, int id)
        {
            this.produto = produto;
            this.descricao = descricao;
            this.valor = valor;
            this.imagem = imagem;
            this.id = id;
        }
    }
}
