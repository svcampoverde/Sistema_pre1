using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LogicDeNegocio.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> RegistrarUsuarioAsync(UsuarioRequest userDto);

        Task<UsuarioDto> ActualizarUsuarioAsync(int id, UsuarioRequest userDto);
        Task<List<UsuarioDto>> ObtenerUsuarios(string cedula);
        Task<UsuarioDto> ObtenerUsuarioPorId(int id);
        Task EliminarUsuario(int id);
        Task<bool> CambiarClaveAsync(int id, string nuevaClave);
    }
}