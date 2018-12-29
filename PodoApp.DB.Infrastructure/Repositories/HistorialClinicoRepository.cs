using PodoApp.DB.Infrastructure.Abstracts;
using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library;
using PodoApp.Library.Model;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodoApp.DB.Infrastructure.Mappers;

namespace PodoApp.DB.Infrastructure.Repositories
{
    public class HistorialClinicoRepository :  BaseRepository<HistorialClinico> ,IHistorialClínicoRepository
    {
        public HistorialClinicoRepository(PodologiaContext context) : base(context) { }

        public void Delete(HistorialClinicoModel entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(HistorialClinicoModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(HistorialClinicoModel entity)
        {
            var newHistorialMedico = entity.ModelToEntity();
            var historialMedico = GetById(entity.idHistorialClinico);

            newHistorialMedico.MapChanges(ref historialMedico);

            Update(historialMedico);
        }
    }
}
