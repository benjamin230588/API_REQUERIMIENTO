using API_REQUERIMIENTO.DTO;
using APP_REQUERIMIENTOS2025.DTO;
using APP_REQUERIMIENTOS2025.EF_CONTEXTO;
using APP_REQUERIMIENTOS2025.Helpers;
using Microsoft.EntityFrameworkCore;

namespace API_REQUERIMIENTO.Datos
{
    public class DaoRequerimiento
    {
        private readonly AplicacionContexto context;
        public DaoRequerimiento(AplicacionContexto context)
        {
            this.context = context;

        }

        public async Task<Respuesta> ListaRequerimiento()
        {

            Respuesta obj = new Respuesta();
            try
            {
                var requerimiento = await context.Requerimientos.ToListAsync();
                var resul = requerimiento.Select(x => new RequerimientoDTO() { Id = x.Id, Titulo = x.Titulo });
                if (requerimiento != null)
                {
                    obj.codigo = 1;
                    obj.mensaje = "EXITO";
                    obj.data = resul;
                }
                else
                {
                    obj.codigo = 0;
                    obj.mensaje = "requerimiento no Existe";

                }

            }
            catch (Exception ex)
            {
                obj.codigo = 0;
                obj.mensaje = ex.Message;


            }



            return obj;
        }

    }
}
