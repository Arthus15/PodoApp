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
    public class TratamientoRepository : BaseRepository<Tratamiento>, ITratamientoRepository
    {
        public TratamientoRepository(PodologiaContext context) : base(context)
        {
        }

        public void Delete(TratamientoModel model)
        {
            Delete(model.ModelToEntity());
        }

        public void Insert(TratamientoModel model)
        {
            Insert(model.ModelToEntity());
        }

        public void Update(TratamientoModel model)
        {
            Update(model.ModelToEntity());
        }
    }
}
