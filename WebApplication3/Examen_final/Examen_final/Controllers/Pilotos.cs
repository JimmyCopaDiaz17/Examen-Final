using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexto;
using WebApplication3.Modelo;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotosController : ControllerBase
    {

            private readonly ILogger<PilotosController> _logger;
            private readonly AplicacionContexto _aplicacionContexto;

            public PilotosController(ILogger<PilotosController> logger, AplicacionContexto aplicacionContexto)
            {
                _logger = logger;
                _aplicacionContexto = aplicacionContexto;
            }
            [Route("")]
            [HttpGet]
            public IEnumerable<Pilotos> GET()
            {
                return _aplicacionContexto.pilotos.ToList();
            }

            [Route("")]
            [HttpPost]
            public IActionResult POST([FromBody] Pilotos newPilotos)
            {
                _aplicacionContexto.pilotos.Add(newPilotos);
                _aplicacionContexto.SaveChanges();
                return Ok(newPilotos);
            }

            [Route("")]
            [HttpPut]
            public IActionResult PUT([FromBody] Pilotos updatePilotos)
            {
                _aplicacionContexto.pilotos.Update(updatePilotos);
                _aplicacionContexto.SaveChanges();
                return Ok(updatePilotos);
            }

            [Route("")]
            [HttpDelete]
            public IActionResult DELETE(int idPilotosDelete)
            {
                _aplicacionContexto.pilotos.Remove(_aplicacionContexto.pilotos.ToList().Where(x => x.idPilotos == idPilotosDelete).FirstOrDefault());
                _aplicacionContexto.SaveChanges();
                return Ok(idPilotosDelete);
            }

        }
    
}