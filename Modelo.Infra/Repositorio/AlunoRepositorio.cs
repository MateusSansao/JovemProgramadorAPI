﻿using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Infra.Repositorio
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
            List<Aluno> alunos = new List<Aluno>();




            //alunos.Add(new Aluno { Nome = "Katia", Id = 1 });
            // alunos.Add(new Aluno { Nome = "Maria", Id = 2 });
            //alunos.Add(new Aluno { Nome = "Manoel", Id = 3 });
            //var aluno = alunos.FirstOrDefault(x => x.Id == id);
            //return aluno

            return _bancoContexto.Aluno.FirstOrDefault(x => x.Id == id);
            
        }

        public void AdicionarDadosAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();   
        }


        public void EditarDadosAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }
        
        public void ExcluirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }
    }
}
