using Microsoft.AspNetCore.Mvc;
using dexian_itg_challange.Model;
using dexian_itg_challange.Service.impl;

namespace dexian_itg_challange.Controllers
{
    [ApiController]
    [Route("api/v1/escolas")]
    public class EscolasController : ControllerBase
    {
        private readonly IEscolaService _escolaService;

        public EscolasController(IEscolaService escolaService)
        {
            _escolaService = escolaService ?? throw new ArgumentNullException(nameof(escolaService));
        }

        [HttpGet]
        public ActionResult<List<Escola>> GetEscolas()
        {
            var escolas = _escolaService.GetEscolas();
            return Ok(escolas);
        }

        [HttpGet("{id}")]
        public ActionResult<Escola> GetEscolaById(int id)
        {
            var escola = _escolaService.GetEscolaById(id);
            return Ok(escola);
        }

        [HttpPost]
        public IActionResult AddEscola(Escola escola)
        {
            _escolaService.AddEscola(escola);
            return CreatedAtAction(nameof(GetEscolaById), new { id = escola.ICodEscola }, escola);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEscola(int id, Escola escola)
        {
            try
            {
                _escolaService.UpdateEscola(id, escola);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEscola(int id)
        {
            try
            {
                _escolaService.DeleteEscola(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
