using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Servico
{
    public abstract class BaseServico<TDominio> where TDominio : class
    {
        public abstract List<TDominio> Brose();
        public abstract TDominio Read(int id);
        public abstract TDominio Edit(TDominio instancia);
        public abstract TDominio Add(TDominio instancia);
        public abstract TDominio Delete(TDominio instancia);


    }
}
