using Myfood.Dominio;
using Myfood.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Repositorio
{
    public class PessoaFisicaRepo : BaseRepositorio<PessoaFisica>
    {
        private FakeDataBase fakeDB = new FakeDataBase();

        public override PessoaFisica Create(PessoaFisica instancia)
        {
            int id = fakeDB.PessoasFisicas.Count() > 0 ? fakeDB.PessoasFisicas.Last().Id + 1 : 1;
            instancia.Id = id;
            fakeDB.PessoasFisicas.Add(instancia);
            return instancia;
        }

        public override PessoaFisica ReadOne(int chave)
        {
            return fakeDB.PessoasFisicas.SingleOrDefault(pf => pf.Id == chave);
        }

        public override List<PessoaFisica> ReadAll ()
        {
            return fakeDB.PessoasFisicas;

        }

        public override PessoaFisica Update(PessoaFisica instancia)
        {
            PessoaFisica original = this.ReadOne(instancia.Id);
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
        public override PessoaFisica Delete(PessoaFisica instancia)
        {
            PessoaFisica original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                fakeDB.PessoasFisicas.Remove(original);
                return original;
            }

        }
    }
}

