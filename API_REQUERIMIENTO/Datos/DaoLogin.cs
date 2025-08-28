using APP_REQUERIMIENTOS2025.DTO;
using APP_REQUERIMIENTOS2025.EF_CONTEXTO;
using APP_REQUERIMIENTOS2025.Entidades;
using APP_REQUERIMIENTOS2025.Helpers;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace APP_REQUERIMIENTOS2025.Datos
{
    public class DaoLogin
    {
        

        private readonly AplicacionContexto context;
        public DaoLogin(AplicacionContexto context)
        {
            this.context = context;

        }
        public async Task<Respuesta>  Inicio(LoginReq model)
        {

            Respuesta obj = new Respuesta();
            try
            {
                var usuario = await context.Usuarios.Where(x => x.Username == model.username && x.Pasword == model.password).FirstOrDefaultAsync();
                if (usuario != null)
                {
                    obj.codigo = 1;
                    obj.mensaje = "EXITO";
                    obj.data = usuario;
                }
                else
                {
                    obj.codigo = 0;
                    obj.mensaje = "Usuario no Existe";

                }

            }
            catch (Exception ex)
            {
                obj.codigo = 0;
                obj.mensaje=ex.Message;


            }



            return obj;
        }

    }
}
