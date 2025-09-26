using System.ComponentModel.DataAnnotations.Schema;

namespace API_REQUERIMIENTO.DTO
{
    public class RequerimientoDTO
    {
        public int Id { get; set; }
  
        public string Titulo { get; set; }

        public string Detalle { get; set; }
        public DateTime? FechaProgramada { get; set; }
        public int Estado { get; set; }
        public string NommbreEstado { get; set; }
        public string Observacion1 { get; set; }

        public string NombreCliente { get; set; }
        public string CodigoCliente { get; set; }
    }
}
