namespace APISERVI.Models
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Placa { get; set; } = string.Empty;
        public int NoOrden { get; set; }
        public int Capacidad { get; set; }
        public int IdEstado { get; set; }

        public virtual Estado Estado { get; set; } = null!;

    }
}
