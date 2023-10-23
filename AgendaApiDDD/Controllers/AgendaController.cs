using Agenda.Aplication.Interfaces;
using Agenda.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDDD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaRepository _agendaRepository;

        public AgendaController(IAgendaRepository agendaRepository)
        {
            _agendaRepository = agendaRepository;
        }

        [HttpGet]
        public IEnumerable<CadastroAgenda> GetContacts()
        {
            return _agendaRepository.FindAll();
            
        }

        [HttpGet("{id}")]
        public ActionResult<CadastroAgenda> Get(int id)
        {
            return _agendaRepository.Get(id);
            
        }

        [HttpPost]
        public ActionResult<CadastroAgenda> Create([FromBody] CadastroAgenda agenda)
        {
            //var novo = new CadastroAgenda(agenda.Nome,)
            var result = _agendaRepository.Create(agenda);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult Update([FromBody] CadastroAgenda agenda)
        {
            //var result = _agendaRepository.Get(agenda.Id);
            //result.altera();
            _agendaRepository.Update(agenda);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _agendaRepository.Get(id);
            if(result != null)
            {
                _agendaRepository.Delete(result);
                return NoContent();
            }
            return NotFound();
        }
    }
}