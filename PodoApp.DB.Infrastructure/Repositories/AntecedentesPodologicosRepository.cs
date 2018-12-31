using PodoApp.DB.Infrastructure.Abstracts;
using PodoApp.DB.Infrastructure.Entities;
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
    public class AntecedentesPodologicosRepository : BaseRepository<AntecedentesPodologicos>, IAntecedentesPodologicosRepository
    {

        public AntecedentesPodologicosRepository(PodologiaContext context) : base(context) { }

        public void Delete(AntecedentesPodologicosModel model)
        {
            throw new NotImplementedException();
        }

        public void Insert(AntecedentesPodologicosModel model)
        {
            var newAntecedentes = model.ModelToEntity();
            Insert(newAntecedentes);
        }

        public void Update(AntecedentesPodologicosModel model)
        {
            var newAntecedentes = model.ModelToEntity();
            var oldAntecedentes = GetById(newAntecedentes.idAPodologicos);

            newAntecedentes.MapChanges(ref oldAntecedentes);
            Update(oldAntecedentes);
        }
    }
}
