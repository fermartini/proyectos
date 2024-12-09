using System;
using System.Collections.Generic;

namespace DycsysApi.Models
{
    public partial class NombreGasto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Icono { get; set; } = null!;
    }
}
