using Microsoft.AspNetCore.Mvc;
using dexian_itg_challange.Model;
using dexian_itg_challange.Service.impl;

namespace dexian_itg_challange.Controllers
{
    [ApiController]
    [Route("api/v1/alunos")]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunosController(IAlunoService alunoService)
        {
            _alunoService = alunoService ?? throw new ArgumentNullException(nameof(alunoService));
        }

        [HttpGet]
        public ActionResult<List<Aluno>> GetAlunos()
        {
            var alunos = _alunoService.GetAlunos();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public ActionResult<Aluno> GetAlunoById(int id)
        {
            var aluno = _alunoService.GetAlunoById(id);
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult AddAluno(Aluno aluno)
        {
            _alunoService.AddAluno(aluno);
            return CreatedAtAction(nameof(GetAlunoById), new { id = aluno.ICodAluno }, aluno);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAluno(int id, Aluno aluno)
        {
            try
            {
                _alunoService.UpdateAluno(id, aluno);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAluno(int id)
        {
            try
            {
                _alunoService.DeleteAluno(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
