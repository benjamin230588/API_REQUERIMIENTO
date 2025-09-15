using API_REQUERIMIENTO.Datos;
using API_REQUERIMIENTO.DTO;
using APP_REQUERIMIENTOS2025.Datos;
using APP_REQUERIMIENTOS2025.EF_CONTEXTO;
using APP_REQUERIMIENTOS2025.Entidades;
using APP_REQUERIMIENTOS2025.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_REQUERIMIENTO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequerimientoController : ControllerBase
    {
        private readonly AplicacionContexto context;
        public RequerimientoController(AplicacionContexto context)
        {
            this.context = context;

        }
        [HttpGet]
        [Route("Lista")]

        public async Task<ActionResult<List<RequerimientoDTO>>> Get()
        {
            Respuesta obj = new Respuesta();
            DaoRequerimiento objeto = new DaoRequerimiento(context);
            obj = await objeto.ListaRequerimiento();
            //var clientes = await context.Clientes.ToListAsync();
            return Ok(obj);

        }
    }
}
