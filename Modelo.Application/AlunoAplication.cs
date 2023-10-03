using Modelo.Application.Interfaces;
using Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Application
{
    public class AlunoAplication :  IAlunoApplication
    {
        private AlunoAplication(IAlunoApplication alunoApplication) 
        {
            _alunoRepositorio = alunoApplication;   
        }

        public Aluno BuscaAluno(int id)
        {
            var aluno = _alunoRepositorio.BuscarId(id); 
            return aluno;
        }
    }
}
