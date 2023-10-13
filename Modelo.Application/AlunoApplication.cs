using Modelo.Application.Interfaces;
using Modelo.Domain;
using Modelo.Infra.Repositorio;
using Modelo.Infra.Repositorio.Interfaces;
using System.Reflection.Metadata.Ecma335;

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

        public Aluno AdicionarDadosAluno(Aluno aluno)
        {
            _alunoRepositorio.AdicionarDadosAluno(Aluno);
            return aluno;
        }
        
        public void EditarDadosAluno(AlunoDto alunoDto)
        {
            Aluno aluno = new();

            aluno.Id = alunoDto.Id;
            aluno.Nome = alunoDto.Nome;

            _alunoRepositorio.EditarDadosAluno(aluno);
        }
       

    }
}