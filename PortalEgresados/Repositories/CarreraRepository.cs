using Microsoft.EntityFrameworkCore;
using PortalEgresados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalEgresados.Models;

namespace PortalEgresados.Repositories
{
    public class CarreraRepository : Repository<Carrera>
    {
      
        public CarreraRepository(itesrcne_egresadosContext context) : base(context)
        {
           
        }

        public override void Insert(Carrera entity)
        {
          
            base.Insert(entity);
        }
        public override void Update(Carrera entity)
        {
            base.Update(entity);
        }
        public override void Delete(Carrera entity)
        {
            base.Delete(entity);
        }

        public override IEnumerable<Carrera> GetAll()
        {
           
            return base.GetAll().Where(x=>x.Eliminado==0).OrderBy(x=>x.Nombre);
        }
        public override bool IsValid(Carrera entity, out List<string> validationErrors)
        {
            validationErrors = new List<string>();

            if (string.IsNullOrWhiteSpace(entity.Nombre))
            {
                validationErrors.Add("El nombre del contacto se encuentra vacio.");
            }
            if (string.IsNullOrWhiteSpace(entity.CorreoJefe))
            {
                validationErrors.Add("El correo del jefe se encuentra vacio.");
            }
            if (string.IsNullOrWhiteSpace(entity.ContraseñaJefe))
            {
                validationErrors.Add("La contraseña del jefe se encuentra vacio.");
            }
          
            if (Context.Set<Carrera>().Any(x => x.Nombre == entity.Nombre && x.Id != entity.Id))
            {
                validationErrors.Add("El nombre de la carrera ya se encuentra en la lista.");
            }
            return validationErrors.Count == 0;
        }
    }
}
