namespace Datos.Models
{
    public partial class Inventario : BaseEntity<int>
    {
        public int IdProducto{ get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion { get; set; }
        public string EstadoProducto { get; set; }
        //public decimal PrecioCompra { get; set; }
        //public decimal PrecioVenta { get; set; }
        public string Digitador { get; set; }
        public string TipoMaterial { get; set; }
        public decimal PrecioCompra { get; set; } = 0M;
        public decimal PrecioVenta { get; set; } = 0M;
        public virtual Producto Producto { get; set; }
    }
}
