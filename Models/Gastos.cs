namespace APISERVI.Models
{
    public class Gasto
    {
        public int IdGastos { get; set; }
        public int IdVehiculo { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public string Fecha { get; set; } = string.Empty;

        public virtual Vehiculo Vehiculo { get; set; } = null!;
    }
}
