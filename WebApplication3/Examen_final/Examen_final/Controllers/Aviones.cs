using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexto;
using WebApplication3.Modelo;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionesController : ControllerBase
    {
        private readonly ILogger<Aviones> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public AvionesController(ILogger<AvionesController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
            [Route("")]
            [HttpGet]
        public IEnumerable<Aviones> GET()
        {
            return _aplicacionContexto.aviones.ToList();
        }

        [Route("")]
        [HttpPost]
        public IActionResult POST([FromBody] Aviones newAviones)
        {
            _aplicacionContexto.aviones.Add(newAviones);
            _aplicacionContexto.SaveChanges();
            return Ok(newAviones);
        }

        [Route("")]
        [HttpPut]
        public IActionResult PUT([FromBody] Aviones updateAviones)
        {
            _aplicacionContexto.aviones.Update(updateAviones);
            _aplicacionContexto.SaveChanges();
            return Ok(updateAviones);
        }

        [Route("")]
        [HttpDelete]
        public IActionResult DELETE(int idAvionesDelete)
        {
            _aplicacionContexto.aviones.Remove(_aplicacionContexto.aviones.ToList().Where(x => x.idAviones == idAvionesDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idAvionesDelete);
        }
    }
}
