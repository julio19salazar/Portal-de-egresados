using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Redsocial
    {
        public int Id { get; set; }
        public int IdEgresado { get; set; }
        public int IdRed { get; set; }
        public string Enlace { get; set; }

        public virtual Egresado IdEgresadoNavigation { get; set; }
        public virtual Redessociale IdRedNavigation { get; set; }
    }
}
