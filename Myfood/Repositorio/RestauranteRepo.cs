using Myfood.Dominio;
using Myfood.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Repositorio
{
    public class RestauranteRepo : BaseRepositorio<Restaurante>
    {
        private FakeDataBase fakeDB;

        public RestauranteRepo(FakeDataBase _fakeDB){
            this.fakeDB = _fakeDB;
        }

        public override Restaurante Create(Restaurante instancia)
        {
            int id = fakeDB.Restaurantes.Count() > 0 ? fakeDB.Restaurantes.Last().Id + 1 : 1;
            instancia.Id = id;
            fakeDB.Restaurantes.Add(instancia);
            return instancia;
        }

        public override Restaurante ReadOne(int chave)
        {
            return fakeDB.Restaurantes.SingleOrDefault(pj => pj.Id == chave);
        }

        public override List<Restaurante> ReadAll()
        {
            return fakeDB.Restaurantes;

        }

        public override Restaurante Update(Restaurante instancia)
        {
            Restaurante original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                original = instancia;
                return original;
            }
        }
        public override Restaurante Delete(Restaurante instancia)
        {
            Restaurante original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                fakeDB.Restaurantes.Remove(original);
                return original;
            }

        }
    }
}

