namespace APISERVI.Models
{
    public class Contratista
    {
        public int IdContratista { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public string PersonaContacto { get; set; } = string.Empty;
        public string TelefonoContacto { get; set; } = string.Empty;

    }
}
