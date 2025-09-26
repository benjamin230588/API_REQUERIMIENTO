using System.ComponentModel.DataAnnotations.Schema;

namespace API_REQUERIMIENTO.Entidades
{
    public class Requerimiento
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? Titulo { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? NombreCliente { get; set; }


        [Column(TypeName = "varchar(20)")]
        public string? CodigoCliente { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string? Detalle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaProgramada { get; set; }
       
        public int Estado { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string? Observacion1 { get; set; }
    }
}
