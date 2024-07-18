using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IProductoService
    {
        Task<ProductoDto> RegistrarProducto(ProductoRequest request);
        Task<int> RegistrarProductos(ProductoRequest request);
        Task<ProductoDto> ActualizarProducto(int id, ProductoRequest request);
        Task EliminarProducto(int id);
        Task<ProductoDto> ObtenerProductoName(string nombre);
        //Task<ProductoDto> RegistrarProductoConInventario(ProductoRequest productoRequest, InventarioRequest inventarioRequest, AtributoRequest atributoRequest, AtributoProductoRequest atributoproRequest);
        Task<List<ProductoDto>> ObtenerTodoslosProductos();
    }
}
