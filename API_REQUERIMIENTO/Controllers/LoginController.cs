using APP_REQUERIMIENTOS2025.Datos;
using APP_REQUERIMIENTOS2025.DTO;
using APP_REQUERIMIENTOS2025.EF_CONTEXTO;
using APP_REQUERIMIENTOS2025.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace APP_REQUERIMIENTOS2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AplicacionContexto context;
        public LoginController(AplicacionContexto context)
        {
            this.context = context;

        }

        [HttpPost("Ingreso")]
        public async Task<ActionResult> Autenticar([FromBody] LoginReq model)
        {
            Respuesta obj = new Respuesta();
            DaoLogin objeto = new DaoLogin(context);
            obj = await objeto.Inicio(model);

            return Ok(obj);
        }
    }
}
