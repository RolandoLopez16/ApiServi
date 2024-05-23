namespace APISERVI.Models
{
    public class Asignacion
    {
        public int IdAsignacion { get; set; }
        public int IdServicio { get; set; }
        public int IdVehiculo { get; set; }
        public int IdConductor { get; set; }
        public decimal PagoExtraConductor { get; set; }

        public virtual Servicio Servicio { get; set; } = null!;
        public virtual Vehiculo Vehiculo { get; set; } = null!;
        public virtual Conductor Conductor { get; set; } = null!;
    }
}
