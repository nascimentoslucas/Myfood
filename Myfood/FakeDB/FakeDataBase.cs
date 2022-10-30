using Myfood.Dominio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Myfood.FakeDB
{
    public class FakeDataBase
    {
        public  List<PessoaFisica> PessoasFisicas = new List<PessoaFisica>();
        public List<Restaurante> Restaurantes = new List<Restaurante>();
    }
}
