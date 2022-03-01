using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Gradosacademico
    {
        public int Id { get; set; }
        public int IdEgresado { get; set; }
        public int IdNivelGrado { get; set; }
        public string Titulo { get; set; }
        public string AñoEgreso { get; set; }
        public string NombreInstituto { get; set; }

        public virtual Egresado IdEgresadoNavigation { get; set; }
        public virtual Nivelesegresado IdNivelGradoNavigation { get; set; }
    }
}
