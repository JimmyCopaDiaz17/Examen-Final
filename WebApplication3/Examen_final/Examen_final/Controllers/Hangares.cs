using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexto;
using WebApplication3.Modelo;

namespace WebApplication3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HangaresController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        
        public HangaresController(ILogger<HangaresController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Hangares> GET()
        {
            return _aplicacionContexto.hangares.ToList();
        }

        [HttpPost]
        [Route("")]
        public IActionResult POST([FromBody] Hangares newHangares)
        {
            _aplicacionContexto.hangares.Add(newHangares);
            _aplicacionContexto.SaveChanges();
            return Ok(newHangares);
        }

        [HttpPut]
        [Route("")]
        public IActionResult PUT([FromBody] Hangares hangaresUpdate)
        {
            _aplicacionContexto.hangares.Update(hangaresUpdate);
            _aplicacionContexto.SaveChanges();
            return Ok(hangaresUpdate);
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DELETE(int idHangaresDelete)
        {
            _aplicacionContexto.hangares.Remove(_aplicacionContexto.hangares.ToList().Where(x=>x.idHangares == idHangaresDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idHangaresDelete);
        }
    }
}
