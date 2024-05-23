namespace APISERVI.Models
{
    public class Conductor
    {
        public int IdConductor { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string FechaLicencia { get; set; } = string.Empty;
        public decimal TarifaPorServicio { get; set; }


    }
}
