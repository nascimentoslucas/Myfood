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
        public override PessoaFisica Create(PessoaFisica instancia)
        {
            int id = PessoaFisicaFakeDB.PessoasFisicas.Last().Id + 1;
            instancia.Id = id;
            PessoaFisicaFakeDB.PessoasFisicas.Add(instancia);
            return instancia;
        }

        public override PessoaFisica ReadOne(int chave)
        {
            return PessoaFisicaFakeDB.PessoasFisicas.SingleOrDefault(pf => pf.Id == chave);
        }

        public override List<PessoaFisica> ReadAll ()
        {
            return PessoaFisicaFakeDB.PessoasFisicas;

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
                PessoaFisicaFakeDB.PessoasFisicas.Remove(original);
                return original;
            }

        }
    }
}

