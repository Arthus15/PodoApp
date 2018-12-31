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
    public class AntecedentesFamiliaresRepository : BaseRepository<AntecedentesFamiliares>, IAntecedentesFamiliaresRepository
    {
        public AntecedentesFamiliaresRepository(PodologiaContext context) : base(context) { }

        public void Delete(AntecedentesFamiliaresModel model)
        {
            throw new NotImplementedException();
        }

        public void Insert(AntecedentesFamiliaresModel model)
        {
            var antecedentesFamiliares = model.ModelToEntity();
            Insert(antecedentesFamiliares);
        }

        public void Update(AntecedentesFamiliaresModel model)
        {
            var newAntecedentes = model.ModelToEntity();
            var oldAntecedentes = GetById(newAntecedentes.idAFamiliares);

            newAntecedentes.MapChanges(ref oldAntecedentes);
            Update(oldAntecedentes);
        }
    }
}
