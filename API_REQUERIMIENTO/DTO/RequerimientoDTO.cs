namespace API_REQUERIMIENTO.DTO
{
    public class RequerimientoDTO
    {
        public int Id { get; set; }
  
        public string Titulo { get; set; }

        public string Detalle { get; set; }
        public DateTime? FechaProgramada { get; set; }
        public int Estado { get; set; }
        public string ObservacionInicial { get; set; }
    }
}
