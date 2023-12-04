using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexto;
using WebApplication3.Modelo;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Pilotos_avionController : ControllerBase
    {
        private readonly ILogger<Pilotos_avionController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public Pilotos_avionController(ILogger<Pilotos_avionController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Pilotos_avion> GET()
        {
            return _aplicacionContexto.pilotos_avion.ToList();
        }

        [Route("")]
        [HttpPost]
        public IActionResult POST([FromBody] Pilotos_avion newPilotos_avion)
        {
            _aplicacionContexto.pilotos_avion.Add(newPilotos_avion);
            _aplicacionContexto.SaveChanges();
            return Ok(newPilotos_avion);
        }

        [Route("")]
        [HttpPut]
        public IActionResult PUT([FromBody] Pilotos_avion updatePilotos_avion)
        {
            _aplicacionContexto.pilotos_avion.Update(updatePilotos_avion);
            _aplicacionContexto.SaveChanges();
            return Ok(updatePilotos_avion);
        }

        [Route("")]
        [HttpDelete]
        public IActionResult DELETE(int idPilotos_avionDelete)
        {
            _aplicacionContexto.pilotos_avion.Remove(_aplicacionContexto.pilotos_avion.ToList().Where(x => x.idPilotos_avion == idPilotos_avionDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idPilotos_avionDelete);
        }
    }
}
