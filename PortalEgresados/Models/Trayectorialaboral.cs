using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Trayectorialaboral
    {
        public int Id { get; set; }
        public int IdEgresado { get; set; }
        public string Puesto { get; set; }
        public string AñoInicio { get; set; }
        public string AñoFin { get; set; }
        public string NombreEmpresa { get; set; }

        public virtual Egresado IdEgresadoNavigation { get; set; }
    }
}
