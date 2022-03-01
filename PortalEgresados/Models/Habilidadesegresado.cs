using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Habilidadesegresado
    {
        public int Id { get; set; }
        public int IdEgresado { get; set; }
        public string Habilidades { get; set; }

        public virtual Egresado IdEgresadoNavigation { get; set; }
    }
}
