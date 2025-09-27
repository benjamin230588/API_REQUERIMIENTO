using API_REQUERIMIENTO.DTO;
using API_REQUERIMIENTO.Entidades;
using APP_REQUERIMIENTOS2025.DTO;
using APP_REQUERIMIENTOS2025.EF_CONTEXTO;
using APP_REQUERIMIENTOS2025.Entidades;
using APP_REQUERIMIENTOS2025.Helpers;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Text.RegularExpressions;
using System.Linq;

namespace API_REQUERIMIENTO.Datos
{
    public class DaoRequerimiento
    {
        private readonly AplicacionContexto context;
        public DaoRequerimiento(AplicacionContexto context)
        {
            this.context = context;

        }

        public async Task<Respuesta> ListaRequerimiento(Paginacion objresult)
        {

            Respuesta obj = new Respuesta();
            try
            {
               // var requerimiento = await context.Requerimientos.ToListAsync();
                List<RequerimientoDTO> model = new List<RequerimientoDTO>();
                int regis = 0;
                IQueryable<RequerimientoDTO> result = context.Requerimientos.Select(
                    x => new RequerimientoDTO()
                    {
                        Id = x.Id,
                        Titulo = x.Titulo,
                        Detalle = x.Detalle,
                        FechaProgramada = x.FechaProgramada,
                        NombreCliente = x.NombreCliente,
                        CodigoCliente = x.CodigoCliente,
                        Estado = x.Estado,
                        NommbreEstado = x.Estado == 1 ? "Activo" : "ANULADO"
                    });

                model = await result.Skip(objresult.skip).Take(objresult.pagine).ToListAsync();
                regis = await result.CountAsync();

                ResulLista<RequerimientoDTO> lst = new ResulLista<RequerimientoDTO>()
                {
                    cantidadregistro = regis,
                    lista = model
                };

                if (regis > 0)
                {
                    obj.codigo = 1;
                    obj.mensaje = "EXITO";
                    obj.data = lst;
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

        public async Task<Respuesta> GrabarRequerimiento(Requerimiento model)
        {

            Respuesta obj = new Respuesta();
            try
            {
                context.Add(model);
                await context.SaveChangesAsync();
                if (model.Id>0)
                {
                    obj.codigo = 1;
                    obj.mensaje = "EXITO";
                    obj.data = model;
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

        public async Task<Respuesta> ModificarRequerimiento(Requerimiento model)
        {

            Respuesta obj = new Respuesta();
            try
            {
                context.Update(model);
                await context.SaveChangesAsync();
                if (model.Id > 0)
                {
                    obj.codigo = 1;
                    obj.mensaje = "EXITO";
                    obj.data = model;
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

        public async Task<Respuesta> EliminarRequerimiento(int idreq)
        {

            Respuesta obj = new Respuesta();
            try
            {
                var model = context.Requerimientos.Where(x => x.Id == idreq).FirstOrDefault();
                context.Requerimientos.Remove(model);
                await context.SaveChangesAsync();
                if (model.Id > 0)
                {
                    obj.codigo = 1;
                    obj.mensaje = "EXITO";
                    obj.data = model;
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
