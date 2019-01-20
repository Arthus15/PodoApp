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
    public class PersonaRepository : BaseRepository<Persona>, IPersonaRepository
    {        
        public PersonaRepository(PodologiaContext context) : base(context)
        {
        }

        #region Public Methods

        public void Delete(PersonaModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonaModel> GetByIdList(List<Guid> personaIdList)
        {
            var personas = dbSet.Where(x => personaIdList.Any(y => x.idPersona == y)).ToList();
            var personasModel = personas.Select(x => x.EntityToModel()).ToList();
            return personasModel;
        }

        public void Insert(PersonaModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonaModel model)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
