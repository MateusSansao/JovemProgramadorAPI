using Modelo_Infra.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Infra.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Aluno BuscarId(int id)
        {
            return _bancoContexto.Aluno.FirstOrdefault(x => x.Id == id);    
        }
    }
}
