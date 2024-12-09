using System;
using System.Collections.Generic;

namespace DycsysApi.Models
{
    public partial class Ingreso
    {
        public int Id { get; set; }
        public float Importe { get; set; }
        public string Dia { get; set; } = null!;
        public string Mes { get; set; } = null!;
        public string Anio { get; set; } = null!;
        public int NombreIngresoId { get; set; }
        public int TipoIngresoId { get; set; }
        public string UsuarioId { get; set; } = null!;
        public string? Detalle { get; set; }
        public int? Cobrado { get; set; }
    }
}
