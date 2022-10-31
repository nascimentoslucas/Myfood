using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Dominio
{
    public class Pedido
    {
        private int id;
        private Cardapio cardapio;

        public Pedido(int id,Cardapio cardapio){
            this.id = id;
            this.cardapio = cardapio;
        }
    }

}
