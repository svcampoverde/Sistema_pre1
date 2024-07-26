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
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class InventarioService : IInventarioService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<InventarioService> _logger;

        public InventarioService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<InventarioService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<InventarioDto> RegistrarInventario(InventarioRequest request)
        {
            using (var context = _dbContextFactory())
            {
                //var entidad = _mapper.Map<Inventario>(request);
                var entidad = new Inventario()
                {
                    TipoMaterial = request.TipoMaterial,
                    PrecioVenta = request.PrecioVenta,
                    EstadoProducto = request.EstadoProducto,
                    Cantidad = request.Cantidad,
                    Ubicacion = request.Ubicacion,
                    Digitador = request.Digitador,
                    IdProducto = request.ProductoId,

                };
                await context.Inventarios.AddAsync(entidad);

                await context.SaveChangesAsync();

                return _mapper.Map<InventarioDto>(entidad);
            }
        }
        //public async Task<InventarioDto> RegistrarInventario(InventarioRequest request)
        //{
        //    using (var context = _dbContextFactory())
        //    {
        //        var entidad = _mapper.Map<Inventario>(request);

        //        // Depuración: Verificar entidad antes de añadirla al contexto
        //        if (entidad == null)
        //        {
        //            throw new Exception("El mapeo de la solicitud a la entidad Inventario resultó en un objeto nulo.");
        //        }

        //        // Depuración: Verificar valores de entidad
        //        //if (string.IsNullOrEmpty(entidad.Descripcion))
        //        //{
        //        //    throw new Exception("El campo Descripcion de la entidad Inventario es nulo o vacío.");
        //        //}

        //        await context.Inventarios.AddAsync(entidad);

        //        try
        //        {
        //            await context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateException dbEx)
        //        {
        //            // Depuración: Capturar detalles de la excepción interna
        //            var innerException = dbEx.InnerException?.Message ?? "No hay excepción interna.";
        //            throw new Exception($"Error al guardar los cambios en la base de datos: {dbEx.Message}. Detalles internos: {innerException}");
        //        }

        //        return _mapper.Map<InventarioDto>(entidad);
        //    }
        //}

        public async Task<InventarioDto> ActualizarInventario(int id, InventarioRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Inventarios.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Inventario no encontrada.");
                    throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<InventarioDto>(entidad);
            }
        }

        public async Task EliminarInventario(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Inventarios.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Inventario no encontrada.");
                    throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
                }

                context.Inventarios.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<InventarioDto>> ObtenerTodasInventarios()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Inventarios
                                            .ProjectTo<InventarioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
