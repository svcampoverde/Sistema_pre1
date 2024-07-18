using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class ProductoService : IProductoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductoService> _logger;
        
        public ProductoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<ProductoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProductoDto> RegistrarProducto(ProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Producto>(request);
                await context.Productos.AddAsync(entidad);
                await context.SaveChangesAsync();
               // return _mapper.Map<ProductoDto>(entidad);
               var productodto = _mapper.Map<ProductoDto>(entidad);
                productodto.Id=entidad.Id;
                return productodto;
            }
        }
        //public async Task<ProductoDto> RegistrarProductoConInventario(ProductoRequest productoRequest, AtributoRequest atributoRequest, InventarioRequest inventarioRequest, AtributoProductoRequest atributoproRequest)
        //{
        //    using (var context = _dbContextFactory())
        //    using (var transaction = await context.Database.BeginTransactionAsync())
        //    {
        //        try
        //        {
        //            var producto = _mapper.Map<Producto>(productoRequest);
        //            await context.Productos.AddAsync(producto);
        //            await context.SaveChangesAsync();

        //            var atributo = _mapper.Map<Atributo>(atributoRequest);
        //            atributo.IdCategoriaAtributo = producto.Id; // Asignar el ID del producto recién creado
        //            await context.Atributos.AddAsync(atributo);
        //            await context.SaveChangesAsync();

        //            var inventario = _mapper.Map<Inventario>(inventarioRequest);
        //            inventario.IdProducto = producto.Id; // Asignar el ID del producto recién creado
        //            await context.Inventarios.AddAsync(inventario);
        //            await context.SaveChangesAsync();

        //            var atri_producto = _mapper.Map<AtributoProducto>(atributoproRequest);
        //            atri_producto.IdProducto = producto.Id; // Asignar el ID del producto recién creado
        //            atri_producto.IdAtributo = atributo.Id;
        //            await context.AtributoProductos.AddAsync(atri_producto);
        //           // await context.CategoriaAtributos.AddAsync(atri_producto);
        //            await context.SaveChangesAsync();

        //            await transaction.CommitAsync();

        //            return _mapper.Map<ProductoDto>(producto);
        //        }
        //        catch (Exception ex)
        //        {
        //            await transaction.RollbackAsync();
        //            throw new Exception("Error al registrar el producto y su inventario: " + ex.Message, ex);
        //        }
        //    }
        //}

        public async Task<int> RegistrarProductos(ProductoRequest request)
        {
            var producto = new Producto
            {
                Nombre = request.Nombre,
                Descripcion = request.Descripcion,
                Precio=request.Precio,
                IdTipoProducto = request.IdTipoProducto,
                IdCategoriaProducto = request.IdCategoriaProducto,
            };

            _dbContextFactory().Productos.Add(producto);
            await _dbContextFactory().SaveChangesAsync();

            return producto.Id; // Devolver el ID generado
        }
        public async Task<ProductoDto> ObtenerProductoName(string nombre)
        {
            using (var context = _dbContextFactory())
            {
                var query = context.Productos.AsQueryable();

                if (!string.IsNullOrEmpty(nombre))
                {
                    query = query.Where(p => p.Nombre.ToLower().Contains(nombre.ToLower()));
                }

                var producto = await query
                                        .ProjectTo<ProductoDto>(_mapper.ConfigurationProvider)
                                        .FirstOrDefaultAsync();

                return producto;
            }

        }
        public async Task<ProductoDto> ActualizarProducto(int id, ProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Productos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Producto no encontrada.");
                    throw new KeyNotFoundException($"Producto con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ProductoDto>(entidad);
            }
        }

        public async Task EliminarProducto(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Productos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Producto no encontrada.");
                    throw new KeyNotFoundException($"Producto con ID {id} no encontrado.");
                }

                context.Productos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ProductoDto>> ObtenerTodoslosProductos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Productos
                                            .ProjectTo<ProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
