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
    public class CalzadoHabitualRepository : BaseRepository<CalzadoHabitual>, ICalzadoHabitualRepository
    {
        public CalzadoHabitualRepository(PodologiaContext context) : base(context) { }

        public void Delete(CalzadoHabitualModel model)
        {
            Delete(model.ModelToEntity());
        }

        public void Insert(CalzadoHabitualModel model)
        {
            Insert(model.ModelToEntity());
        }

        public void Update(CalzadoHabitualModel model)
        {
            var oldCalzadoHabitual = GetById(model.idCalzado);
            model.ModelToEntity().MapChanges(ref oldCalzadoHabitual);
            Update(oldCalzadoHabitual);
        }
    }
}
