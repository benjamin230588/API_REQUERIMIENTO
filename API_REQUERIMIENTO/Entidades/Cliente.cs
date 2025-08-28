using System.ComponentModel.DataAnnotations.Schema;

namespace APP_REQUERIMIENTOS2025.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Ciudad { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Provincia { get; set; }

      
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
