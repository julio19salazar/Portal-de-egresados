using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Docente
    {
        public int Id { get; set; }
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public ulong? Eliminado { get; set; }
    }
}
