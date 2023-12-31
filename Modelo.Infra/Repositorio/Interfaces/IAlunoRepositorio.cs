﻿using Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Infra.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        Aluno BuscarId(int id);

        void AdicionarDadosAluno(Aluno aluno);

        void EditarDadosAluno(Aluno aluno);
        void ExcluirAluno(Aluno aluno);
        List<Aluno> BuscarAlunos();


    }
   
}
