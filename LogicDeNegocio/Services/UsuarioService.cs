﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;

using FluentValidation;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Personas
{
    public class UsuarioService : IUsuarioService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly IValidator<UsuarioRequest> _validator;
        private readonly ILogger<UsuarioService> _logger;
        private readonly IPasswordHashService _passwordHashService;

        public UsuarioService(Func<SistemapContext> dbContextFactory, IMapper mapper,
            IValidator<UsuarioRequest> validator, ILogger<UsuarioService> logger,
            IPasswordHashService passwordHashService)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _validator = validator;
            _logger = logger;
            _passwordHashService = passwordHashService;
        }

        public async Task<UsuarioDto> RegistrarUsuarioAsync(UsuarioRequest request)
        {
            _logger.LogInformation("Inicio del método RegistrarUsuarioAsync.");

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                _logger.LogWarning("Errores de validación: {Errors}", validationResult.Errors);
                throw new ValidationException(validationResult.Errors);
            }

            try
            {
                using (var context = _dbContextFactory())
                {
                    var persona = _mapper.Map<Persona>(request);
                    var user = _mapper.Map<Usuario>(request);
                    // Crear el hash y el salt de la contraseña
                    _passwordHashService.CreatePasswordHash(request.Clave, out byte[] passwordHash, out byte[] passwordSalt);
                    user.ContrasenaHash = passwordHash;
                    user.ContrasenaSalt = passwordSalt;
                    persona.UsuarioNavegation = user;
                    await context.AddAsync(persona);
                    await context.SaveChangesAsync();
                    var userDto = _mapper.Map<UsuarioDto>(persona);
                    _logger.LogInformation("Usuario registrado exitosamente.");
                    return userDto;
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error al actualizar la base de datos.");
                throw new Exception("Error al registrar el usuario. Intente nuevamente más tarde.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al registrar el usuario.");
                throw new Exception("Ocurrió un error inesperado al registrar el usuario.", ex);
            }
        }
        public async Task<List<UsuarioDto>> ObtenerUsuarios(string cedula)
        {
            using (var context = _dbContextFactory())
            {
                var query = from p in context.Personas
                            join us in context.Usuarios on p.Id equals us.IdPersona
                            join ciu in context.Ciudades on p.IdCiudad equals ciu.Id
                            join r in context.Roles on us.IdRol equals r.Id
                            where p.Activo == true
                            select new
                            {
                                us.Id,
                                p.Cedula,
                                p.Nombre,
                                p.Apellido,
                                p.Genero,
                                p.Telefono,
                                p.Celular,
                                p.Correo,
                                p.Direccion,
                                Ciudaddescripcion = ciu.Nombre,
                                us.NombreUsuario,
                                RolUsuario = r.Descripcion,
                            };
                if (!string.IsNullOrEmpty(cedula))
                {
                    query = query.Where(e => e.Cedula.Contains(cedula));
                }
                var datos = await query.ToListAsync();
                return datos.Select(d => new UsuarioDto
                {
                    Id = d.Id,
                    Cedula = d.Cedula,
                    Nombre = d.Nombre,
                    Apellido = d.Apellido,
                    Celular = d.Celular,
                    Telefono = d.Telefono,
                    Genero = d.Genero,
                    Correo = d.Correo,
                    Direccion = d.Direccion,
                    CiudadDescripcion = d.Ciudaddescripcion,
                    NombreUsuario = d.NombreUsuario,
                    RolUsuario = d.RolUsuario,
                }).ToList();

            }
        }
        public async Task<UsuarioDto> ObtenerUsuarioPorId(int id)
        {
            using (var context = _dbContextFactory())
            {
                // Buscar la entidad del empleado por su ID
                var entidad = await context.Usuarios.FindAsync(id);

                if (entidad == null)
                {
                    _logger.LogWarning($"Empleado con ID {id} no encontrado.");
                    throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
                }

                // Mapear la entidad del empleado al DTO
                var usuarioDto = new UsuarioDto
                {
                    Id = entidad.Id,
                    IdPersona = entidad.IdPersona,
                };

                return usuarioDto;
            }
        }

        public async Task<UsuarioDto> ActualizarUsuarioAsync(int id, UsuarioRequest request)
        {
            _logger.LogInformation("Inicio del método ActualizarUsuarioAsync.");

         //   var validationResult = await _validator.ValidateAsync(request);
            //if (!validationResult.IsValid)
            //{
            //    _logger.LogWarning("Errores de validación: {Errors}", validationResult.Errors);
            //    throw new ValidationException(validationResult.Errors);
            //}

            try
            {
                using (var context = _dbContextFactory())
                {
                    var persona = await context.Personas.Include(p => p.UsuarioNavegation).FirstOrDefaultAsync(p => p.Id == id);
                    if (persona == null)
                    {
                        _logger.LogWarning("NombreUsuario no encontrado.");
                        throw new Exception("NombreUsuario no encontrado.");
                    }

                    _mapper.Map(request, persona);
                    var user = persona.UsuarioNavegation;
                    _mapper.Map(request, user);

                    // Actualizar la contraseña si se proporciona una nueva
                    if (!string.IsNullOrEmpty(request.Clave))
                    {
                        _passwordHashService.CreatePasswordHash(request.Clave, out byte[] passwordHash, out byte[] passwordSalt);
                        user.ContrasenaHash = passwordHash;
                        user.ContrasenaSalt = passwordSalt;
                    }

                    await context.SaveChangesAsync();
                    var userDto = _mapper.Map<UsuarioDto>(persona);
                    _logger.LogInformation("NombreUsuario actualizado exitosamente.");
                    return userDto;
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error al actualizar la base de datos.");
                throw new Exception("Error al actualizar el usuario. Intente nuevamente más tarde.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al actualizar el usuario.");
                throw new Exception("Ocurrió un error inesperado al actualizar el usuario.", ex);
            }
        }
        public async Task EliminarUsuario(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Usuarios.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Usuario no encontrado.");
                    throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
                }

                context.Usuarios.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }
        public async Task<bool> CambiarClaveAsync(int id, string nuevaClave)
        {
            _logger.LogInformation("Inicio del método CambiarClaveAsync.");

            try
            {
                using (var context = _dbContextFactory())
                {
                    var usuario = await context.Usuarios.FindAsync(id);
                    if (usuario == null)
                    {
                        _logger.LogWarning("NombreUsuario no encontrado.");
                        throw new Exception("NombreUsuario no encontrado.");
                    }

                    // Crear el hash y el salt de la nueva contraseña
                    _passwordHashService.CreatePasswordHash(nuevaClave, out byte[] passwordHash, out byte[] passwordSalt);
                    usuario.ContrasenaHash = passwordHash;
                    usuario.ContrasenaSalt = passwordSalt;

                    await context.SaveChangesAsync();
                    _logger.LogInformation("Contraseña cambiada exitosamente.");
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error al actualizar la base de datos.");
                throw new Exception("Error al cambiar la contraseña. Intente nuevamente más tarde.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al cambiar la contraseña.");
                throw new Exception("Ocurrió un error inesperado al cambiar la contraseña.", ex);
            }


        }
       
    
    }
}
