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
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }

        [HttpPost("InserirDadosAluno")]
        public async Task<IActionResult> InserirDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                // var aluno = _alunoApplication.InserirAluno(id);
                return Ok("Aluno Inserido com sucesso");
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }
        [HttpPut("EditarDadosAluno")]
        public async Task<IActionResult> EditarDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                // var aluno = _alunoApplication.InserirAluno(id);
                return Ok("Dados do aluno editados com sucesso");
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }
    }
}
