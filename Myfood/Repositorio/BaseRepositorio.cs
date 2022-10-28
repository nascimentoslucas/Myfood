using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfood.Repositorio
{
    public abstract class BaseRepositorio<Tipo> where Tipo : class
    {
        public abstract Tipo Create(Tipo instancia);
        public abstract Tipo ReadOne(int chave);
        public abstract List<Tipo> ReadAll();
        public abstract Tipo Update(Tipo instancia);
        public abstract Tipo Delete(Tipo instancia);
    }
    
}
