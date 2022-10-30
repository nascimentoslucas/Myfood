using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfood.Dominio;

namespace Myfood.FakeDB
{
    public static class CardapioFakeDB
    {
        private static List<Cardapio> cardapios;
        public static List<Cardapio> Cardapios
        {
            get
            {
                if (Cardapios == null)
                {
                    cardapios = new List<Cardapio>();
                    Preencher();
                }
                return cardapios;
            }
        }
        private static void Preencher()
        {
            cardapios.Add(new Cardapio("COCA", "QUENTE", 234, "IMAGEM", 1));
        }
    }
}