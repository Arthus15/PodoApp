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
    public class AntecedentesPatologicosRepository : BaseRepository<AntecedentesPatologicos>, IAntecedentesPatologicosRepository
    {
        public AntecedentesPatologicosRepository(PodologiaContext context) : base(context) { }

        public void Delete(AntecedentesPatologicosModel model)
        {
            throw new NotImplementedException();
        }

        public void Insert(AntecedentesPatologicosModel model)
        {
            var newAntecedentes = model.ModelToEntity();
            Insert(newAntecedentes);
        }

        public void Update(AntecedentesPatologicosModel model)
        {
            var newAntecedentes = model.ModelToEntity();
            var oldAntecedentes = GetById(newAntecedentes.idAPatologico);

            newAntecedentes.MapChanges(ref oldAntecedentes);
            Update(oldAntecedentes);
        }
    }
}
