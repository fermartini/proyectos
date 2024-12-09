using System;
using System.Collections.Generic;

namespace DycsysApi.Models
{
    public partial class Usuario
    {
        public string NombreUsuario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string FotoPerfil { get; set; } = null!;
        public string Id { get; set; } = null!;
    }
}
