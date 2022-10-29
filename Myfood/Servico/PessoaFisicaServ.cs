using Myfood.Dominio;
using Myfood.Repositorio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Servico
{
    public class PessoaFisicaServ : BaseServico<PessoaFisica>
    {
        private PessoaFisicaRepo repositorio;

        public PessoaFisicaServ() : base()
        {
            this.repositorio = new PessoaFisicaRepo();
        }
        public override List<PessoaFisica> Brose()
        {
            return this.repositorio.ReadAll();
        }
        public override PessoaFisica Read(int id)
        {
            return this.repositorio.ReadOne(id);
        }

        public override PessoaFisica Edit(PessoaFisica instancia)
        {
            return this.repositorio.Update(instancia);
        }

        public override PessoaFisica Add(PessoaFisica instancia)
        {
            return this.repositorio.Create(instancia);
        }

        public override PessoaFisica Delete(PessoaFisica instancia)
        {
            return this.repositorio.Delete(instancia);
        }
    }
}
