using APP_REQUERIMIENTOS2025.DTO;
using APP_REQUERIMIENTOS2025.EF_CONTEXTO;
using APP_REQUERIMIENTOS2025.Entidades;
using APP_REQUERIMIENTOS2025.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_REQUERIMIENTOS2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AplicacionContexto context;
        public ClienteController(AplicacionContexto context)
        {
            this.context = context;

        }
        
        [HttpGet]
        [Route("Lista")]
       
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            var clientes = await context.Clientes.ToListAsync();
            return clientes;

        }

        [HttpPost]
        [Route("Grabar")]
        public async Task<ActionResult> Post([FromBody] Cliente objeto)
        {
            Respuesta obj = new Respuesta();
            //var cliente = mapper.Map<Clientes>(objeto);
           

            context.Add(objeto);
            await context.SaveChangesAsync();
            obj.codigo = 1;
            obj.mensaje = "Exito";
            return Ok(obj);
        }
        [HttpPut]
        [Route("Actualizar")]
        public async Task<ActionResult> Put([FromBody] Cliente objeto)
        {
            Respuesta obj = new Respuesta();
            //var cliente = mapper.Map<Clientes>(objeto);


            context.Add(objeto);
            await context.SaveChangesAsync();
            obj.codigo = 1;
            obj.mensaje = "Exito";
            return Ok(obj);
        }
    }
}
