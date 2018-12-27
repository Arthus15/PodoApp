using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using PodoApp.DB.Infrastructure.Abstracts;
using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library;
using PodoApp.Library.Model;
using PodoApp.Library.Repositories;
using PodoApp.DB.Infrastructure.Mappers;

namespace PodoApp.DB.Infrastructure.Repositories
{
    public class PacienteRepository : BaseRepository<Paciente>, IPacienteRepository 
    {
        public PacienteRepository(PodologiaContext context) : base(context)
        {}


        #region Public Methods

        public void Delete(PacienteModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PacienteModel> GetAll()
        {
            var pacientes = dbSet.ToList();
            return pacientes.Select(x => x.EntityToModel());
        }

        public void Insert(PacienteModel model)
        {
            throw new NotImplementedException();
        }

        PacienteModel IBaseRepository<PacienteModel>.GetById(object id)
        {
            return GetById(id).EntityToModel();
        }

        #endregion
    }
}
