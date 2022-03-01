using System;
using System.Collections.Generic;

#nullable disable

namespace PortalEgresados.Models
{
    public partial class Redessociale
    {
        public Redessociale()
        {
            Redsocials = new HashSet<Redsocial>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Redsocial> Redsocials { get; set; }
    }
}
