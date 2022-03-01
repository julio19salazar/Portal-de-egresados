using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Nivelesegresado
    {
        public Nivelesegresado()
        {
            Gradosacademicos = new HashSet<Gradosacademico>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Gradosacademico> Gradosacademicos { get; set; }
    }
}
