using Microsoft.EntityFrameworkCore;
using PortalEgresados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEgresados.Repositories
{
    public class CarreraRepository : Repository<Carrera>
    {
        public CarreraRepository(DbContext context) : base(context)
        {

        }
        public override IEnumerable<Carrera> GetAll()
        {
            return base.GetAll().Where(x=>x.Eliminado==0).OrderBy(x=>x.Nombre);
        }
    }
}
