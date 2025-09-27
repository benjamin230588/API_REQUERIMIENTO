namespace APP_REQUERIMIENTOS2025.Helpers
{
    public class Respuesta
    {
        public int codigo { get; set; }
        public object data { get; set; }
        public string mensaje { get; set; }
    }

    public class ResulLista<T>
    {
        public int cantidadregistro { get; set; }
        public List<T> lista { get; set; }
    }
    public class Paginacion
    {
        public int pagine { get; set; }

        public int skip { get; set; }
    }
}
