using Modelo.Application.Interfaces;
using Modelo.Domain;
using Modelo.Infra.Repositorio;
using Modelo.Infra.Repositorio.Interfaces;

namespace Modelo.Application
{
   
    public class AlunoApplication : IAlunoApplication
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoApplication(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public Aluno BuscaAluno(int id)
        {
            var aluno = _alunoRepositorio.BuscarId(id);
            return aluno;
        }
       

    }
}