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
    public class PodologoRepository : BaseRepository<Podologo>, IPodologoRepository
    {
        public PodologoRepository(PodologiaContext context) : base(context)
        {
        }

        public void Delete(PodologoModel model)
        {
            throw new NotImplementedException();
        }

        public List<PodologoModel> GetAllIds()
        {
            return dbSet.ToList().Select(x => x.EntityToModel()).ToList();
        }

        public void Insert(PodologoModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(PodologoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
