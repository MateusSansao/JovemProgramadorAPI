using Microsoft.AspNetCore.Mvc;
using Modelo.Application.Interfaces;
using Modelo.Domain;

namespace JovemProgramadorAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IAlunoApplication _alunoApplication;
        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }
        [HttpGet("BuscarDadosAluno/{id}")]
        public async Task<IActionResult> BuscarDadosAluno(int id)
        {
            try
            {
                var aluno = _alunoApplication.BuscaAluno(id);
                return Ok(aluno);
                
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar aluno");
            }
        }

        [HttpPost("InserirDadosAluno")]
        public async Task<IActionResult> AdicionarDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.AdicionarDadosAluno(aluno);
                return Ok("Aluno Inserido com sucesso");
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }
        [HttpPut("EditarDadosAluno")]
        public async Task<IActionResult> EditarDadosAluno([FromBody] AlunoDto alunoDto)
        {
            Retorno<Aluno> retorno = new(null);
            try
            {
                _alunoApplication.EditarDadosAluno(alunoDto);
                retorno.CarregaRetorno(true, "aluno editado com sucesso", 200);
                return Ok(retorno);

            }
            catch (Exception e)
            {
                retorno.CarregaRetorno(false, e.Message, 400);
                return BadRequest(retorno);
            }
        }
        
        [HttpDelete("DeletarAluno{id}")]

        public async Task<IActionResult> ExcluirAlunos(int id)

        {

            Retorno<Aluno> retorno = new(null);



            try

            {



                var aluno = _alunoApplication.BuscaAluno(id);



                _alunoApplication.ExcluirAluno(aluno);

                retorno.CarregaRetorno(true, "O id informado foi excluído com êxito", 200);

                return Ok(retorno);

            }

            catch (Exception e)

            {

                retorno.CarregaRetorno(false, e.Message, 400);

                return BadRequest(retorno);

            }

        }
    }
}
