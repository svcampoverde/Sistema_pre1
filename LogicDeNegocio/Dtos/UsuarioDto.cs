using System;
using System.Collections.Generic;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Dtos
{
    public class UsuarioDto : UsuarioRequest
    {
        public int Id { get; set; }
        //para consulta
        public string CiudadDescripcion { get; set; }
        public string UsuarioDescripcion { get; set; }
        public string RolUsuario { get; set; }

    }
}
