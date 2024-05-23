namespace APISERVI.Models
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public int IdContratista { get; set; }
        public string Fecha { get; set; } = string.Empty;
        public string Hora { get; set; } = string.Empty;
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public decimal PagoServicio { get; set; }
        public string EstadoServicio { get; set; } = string.Empty;

        public virtual Contratista Contratista { get; set; } = null!;
        public virtual Estado Estado { get; set; } = null!;
    }
}
