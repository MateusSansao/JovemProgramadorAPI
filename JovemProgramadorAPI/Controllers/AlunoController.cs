using Microsoft.AspNetCore.Mvc;
using Modelo.Application.Interfaces;

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
    }
}
