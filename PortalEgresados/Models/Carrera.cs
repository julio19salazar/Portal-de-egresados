using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoJefe { get; set; }
        public string ContraseñaJefe { get; set; }
        public ulong? Eliminado { get; set; }
    }
}
