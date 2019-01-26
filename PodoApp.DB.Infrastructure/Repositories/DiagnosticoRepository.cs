using PodoApp.DB.Infrastructure.Abstracts;
using PodoApp.DB.Infrastructure.Entities;
using PodoApp.DB.Infrastructure.Mappers;
using PodoApp.Library.Model;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Repositories
{
    public class DiagnosticoRepository : BaseRepository<Diagnostico>, IDiagnosticoRepository
    {
        public DiagnosticoRepository(PodologiaContext context) : base(context)
        {
        }

        #region Public Methods
        public void Delete(DiagnosticoModel model)
        {
            Delete(model.ModelToEntity());
        }

        public DiagnosticoModel GetByid(Guid id)
        {
            return GetById(id).EntityToModel();
        }

        public void Insert(DiagnosticoModel model)
        {
            Insert(model.ModelToEntity());
        }

        public void Update(DiagnosticoModel model)
        {
            Update(model.ModelToEntity());
        }

        #endregion
    }
}
