using System.ComponentModel.DataAnnotations.Schema;

namespace APP_REQUERIMIENTOS2025.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Username { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Pasword { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Apellido { get; set; }
    }
}
