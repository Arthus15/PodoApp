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
    public class PrimeraVisitaRepository : BaseRepository<PrimeraVisita>, IPrimeraVisitaRepository
    {
        public PrimeraVisitaRepository(PodologiaContext context) : base(context) { }

        #region Public Methods
        public void Delete(PrimeraVisitaModel model)
        {
            Delete(model.ModelToEntity());
        }

        public void Insert(PrimeraVisitaModel model)
        {
            //TODO
        }

        public void Update(PrimeraVisitaModel model)
        {
            var oldPrimeraVisita = GetById(model.idPrimeraVisita);
            model.ModelToEntity().MapChanges(ref oldPrimeraVisita);
            Update(oldPrimeraVisita);
        }

        public PrimeraVisitaModel Get(Guid id)
        {
            return GetById(id).EntityToModel();
        }

        #endregion
    }
}
