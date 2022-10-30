using Myfood.Dominio;
using Myfood.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Servico
{
    public class RestauranteServ : BaseServico<Restaurante>
    {
        private RestauranteRepo repositoriojur;

        public RestauranteServ() : base()
        {
            this.repositoriojur = new RestauranteRepo();
        }
        public override List<Restaurante> Brose()
        {
            return this.repositoriojur.ReadAll();
        }
        public override Restaurante Read(int id)
        {
            return this.repositoriojur.ReadOne(id);
        }

        public override Restaurante Edit(Restaurante instancia)
        {
            return this.repositoriojur.Update(instancia);
        }

        public override Restaurante Add(Restaurante instancia)
        {
            return this.repositoriojur.Create(instancia);
        }

        public override Restaurante Delete(Restaurante instancia)
        {
            return this.repositoriojur.Delete(instancia);
        }
    }
}