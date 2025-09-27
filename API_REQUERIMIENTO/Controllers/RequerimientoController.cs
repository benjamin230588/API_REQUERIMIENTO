using API_REQUERIMIENTO.Datos;
using API_REQUERIMIENTO.DTO;
using API_REQUERIMIENTO.Entidades;
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
        [HttpPost]
        [Route("Lista")]

        public async Task<ActionResult<List<RequerimientoDTO>>> ListaRequerimiento([FromBody] Paginacion model)
        {
            Respuesta obj = new Respuesta();
            DaoRequerimiento objeto = new DaoRequerimiento(context);
            obj = await objeto.ListaRequerimiento(model);
            //var clientes = await context.Clientes.ToListAsync();
            return Ok(obj);

        }
        [HttpPost]
        [Route("Grabar")]
        public async Task<ActionResult> Post([FromBody] Requerimiento model)
        {
            Respuesta obj = new Respuesta();
            //var cliente = mapper.Map<Clientes>(objeto);
            DaoRequerimiento objeto = new DaoRequerimiento(context);
            obj = await objeto.GrabarRequerimiento(model);
            //var clientes = await context.Clientes.ToListAsync();
            return Ok(obj);

           
        }

        [HttpPut]
        [Route("Modificar")]
        public async Task<ActionResult> Put([FromBody] Requerimiento model)
        {
            Respuesta obj = new Respuesta();
            //var cliente = mapper.Map<Clientes>(objeto);
            DaoRequerimiento objeto = new DaoRequerimiento(context);
            obj = await objeto.ModificarRequerimiento(model);
            //var clientes = await context.Clientes.ToListAsync();
            return Ok(obj);


        }
        [HttpDelete("Delete/{id:int}")] // api/autores/2
        public async Task<ActionResult> Delete(int id)
        {
            Respuesta obj = new Respuesta();
            //var cliente = mapper.Map<Clientes>(objeto);
            DaoRequerimiento objeto = new DaoRequerimiento(context);
            obj = await objeto.EliminarRequerimiento(id);
            //var clientes = await context.Clientes.ToListAsync();
            return Ok(obj);
        }
    }
}
