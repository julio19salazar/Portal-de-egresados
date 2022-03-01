using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Egresado
    {
        public Egresado()
        {
            Gradosacademicos = new HashSet<Gradosacademico>();
            Habilidadesegresados = new HashSet<Habilidadesegresado>();
            Redsocials = new HashSet<Redsocial>();
            Trayectorialaborals = new HashSet<Trayectorialaboral>();
        }

        public int Id { get; set; }
        public int IdCarrera { get; set; }
        public string NunControl { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string AñoEgreso { get; set; }

        public virtual Datosegresado Datosegresado { get; set; }
        public virtual ICollection<Gradosacademico> Gradosacademicos { get; set; }
        public virtual ICollection<Habilidadesegresado> Habilidadesegresados { get; set; }
        public virtual ICollection<Redsocial> Redsocials { get; set; }
        public virtual ICollection<Trayectorialaboral> Trayectorialaborals { get; set; }
    }
}
