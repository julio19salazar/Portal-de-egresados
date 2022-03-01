using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Datosegresado
    {
        public int IdEgresado { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Ciudad { get; set; }
        public string Fotografia { get; set; }
        public string Perfil { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Curp { get; set; }

        public virtual Egresado IdEgresadoNavigation { get; set; }
    }
}
