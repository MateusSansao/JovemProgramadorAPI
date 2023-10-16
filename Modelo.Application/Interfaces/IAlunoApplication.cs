using Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Application.Interfaces
{
    public interface IAlunoApplication
    {
        Aluno BuscaAluno(int id);
        Aluno AdicionarDadosAluno(Aluno aluno);
        void EditarDadosAluno(AlunoDto alunoDtO);
    }
   

}
